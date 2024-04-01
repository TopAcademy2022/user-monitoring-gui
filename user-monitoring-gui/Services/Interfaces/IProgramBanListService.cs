using user_monitoring_gui.Models;

namespace user_monitoring_gui.Services.Interfaces
{
    public interface IProgramBanListService
    {
        public bool Save(ProgramBanList programBanList, DataStorageArea dataStorageArea);

        public bool Load();
    }
}