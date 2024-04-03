using System.Text;
using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class ProgramBanListService : IProgramBanListService
    {
        private IServerRequest _serverRequest;

        public ProgramBanListService (IServerRequest serverRequest)
        {
            this._serverRequest = serverRequest;
        }

        public bool Save(ProgramBanList programBanList, DataStorageArea dataStorageArea)
        {
            /* ! decoding incoming data into a byte array */

            var bytes = programBanList.GetProgramBanList().Select(i => Encoding.Default.GetBytes($"{i}\n")).ToArray();

            switch (dataStorageArea)
            {
                case DataStorageArea.FILE:
                    using (FileStream fstream = new FileStream("ProgramBanList.txt", FileMode.Append))
                    {
                        foreach (var item in bytes)
                        {
                            fstream.Write(item, 0, item.Length);
                        }
                    }
                    
                    return true;

                case DataStorageArea.SERVER:
                    foreach (var item in bytes)
                    {
                        this._serverRequest.SendData(item);
                    }
                    
                    return true;
            }
            
            return false;
        }

        /*!
         * @brief Load method reads data for ProgramBanList
         * @param programBanList - the class is passed
         * @param dataStorageArea - the class is passed
         * @return True if data was received, false otherwise.
         */
        public bool Load (ProgramBanList programBanList, DataStorageArea dataStorageArea)
        {
            switch(dataStorageArea)
            {
            case DataStorageArea.FILE:

                List<string> lines = File.ReadAllLines("ProgramBanList.txt").ToList();

                foreach(var line in lines)
                {
                    programBanList.AddProgram(line);
                }

                return true;

            case DataStorageArea.SERVER:

                var rezult = this._serverReqwest.LoadData(programBanList.GetType()).GetData();

                programBanList.AddProgram(Encoding.Default.GetString(rezult));

                //TODO: Update tu this
                //foreach( var line in byat )
                //{
                //    programBanList.AddProgram( Encoding.Default.GetString(line));
                //}
                return true;
            }

            return false;
        }
    }
}