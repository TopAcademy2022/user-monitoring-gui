using user_monitoring_gui.Models;

namespace user_monitoring_gui.Services.Interfaces
{
    public interface IWordBanListService
    {
        public bool Save(WordBanList wordBanList, DataStorageArea dataStorageArea);

        public bool Load(WordBanList wordBanList, DataStorageArea dataStorageArea);
    }
}