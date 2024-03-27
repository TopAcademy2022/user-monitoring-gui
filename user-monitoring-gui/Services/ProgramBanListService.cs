using System.Text;
using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class ProgramBanListService:IProgramBanListService
    {

   private IServerRequest _serverReqwest;

        public ProgramBanListService(IServerRequest serverReqwest)
        {
            this._serverReqwest = serverReqwest;
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
                        this._serverReqwest.SendData(item);
                    }
                    return true;
            }

            return false;
        }

        public bool Load()
        {
            return false;
        }
    }
}