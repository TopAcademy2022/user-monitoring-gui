using System.Text;
using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{

    /*!
      * @brief Service responsible for managing the Program Ban List, including saving and loading data
      * from different storage areas (file or server).
      */
    public class ProgramBanListService : IProgramBanListService
    {
        private IServerRequest _serverRequest;


        /*!
         * @brief Initializes a new instance of the class.
         * @param serverRequest An instance of used for server communication.
         */
        public ProgramBanListService (IServerRequest serverRequest)
        {
            this._serverRequest = serverRequest;
        }

        /*!
         * @brief Saves the program ban list to the specified data storage area.
         * @param[in] programBanList object to save.
         * @param[in] dataStorageArea 	Selecting a storage location option.
         * @return returns the true when the data is successfully saved.
         */
        public bool Save(ProgramBanList programBanList, DataStorageArea dataStorageArea)
        {

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
        * @brief Loads the program ban list from the specified data storage area.
        * @param[in] programBanList object to save.
        * @param[in] dataStorageArea Selecting a storage location option.
        * @return returns the true when the data is successfully loaded.
        */
        public bool Load (ProgramBanList programBanList, DataStorageArea dataStorageArea)
        {
            switch(dataStorageArea)
            {
            case DataStorageArea.FILE:

                    List<string> lines = File.ReadAllLines("ProgramBanList.txt").ToList();

                    foreach (var line in lines)
                {
                    programBanList.AddProgram(line);
                }

                return true;

            case DataStorageArea.SERVER: 

                    var rezult = this._serverRequest.LoadData(programBanList.GetType()).GetData();

                    programBanList.AddProgram(Encoding.Default.GetString(rezult));
            
                    return true;
            }

            return false;
        }
    }
}