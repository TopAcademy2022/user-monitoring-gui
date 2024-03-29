using user_monitoring_gui.Models;

namespace user_monitoring_gui.Services.Interfaces
{
    public interface IProgramBanListService
    {
        public bool Save(ProgramBanList programBanList);

        public bool Load (ProgramBanList programBanList, DataStorageArea dataStorageArea);
    }
}