using System.Text;
using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class ProgramBanListService : IProgramBanListService
    {

        private IServerRequest _serverReqwest;


        public ProgramBanListService ( IServerRequest serverReqwest )
        {
            this._serverReqwest = serverReqwest;
        }

        public bool Save ( ProgramBanList programBanList )
        {
            return false;
        }

        /*!
         * @brief Load method reads data for ProgramBanList
         * @param programBanList - the class is passed
         * @param dataStorageArea - the class is passed
         * @return True if data was received, false otherwise.
         */

        public bool Load ( ProgramBanList programBanList, DataStorageArea dataStorageArea)
        {
            switch( dataStorageArea )
            {
            case DataStorageArea.FILE:

                List<string> lines = File.ReadAllLines("ProgramBanList.txt").ToList();

                foreach( var line in lines )
                {
                    programBanList.AddProgram( line );
                }
                return true;

            case DataStorageArea.SERVER:

                var byat = this._serverReqwest.LoadData( programBanList.GetType()).GetData();

                programBanList.AddProgram( Encoding.Default.GetString( byat ) );

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