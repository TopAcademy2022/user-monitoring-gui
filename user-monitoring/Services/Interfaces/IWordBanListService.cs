using user_monitoring.Models;

namespace user_monitoring.Services.Interfaces
{
    public interface IWordBanListService
    {
        public bool Save(WordBanList wordBanList, bool save_file);

        public bool Load();
    }
}