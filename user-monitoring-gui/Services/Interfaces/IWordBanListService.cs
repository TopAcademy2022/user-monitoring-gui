using user_monitoring_gui.Models;

namespace user_monitoring_gui.Services.Interfaces
{
    public interface IWordBanListService
    {
        /*!
       * @brief this method shows if there are saves or not.
       * @param[in] wordBanList defines a word list.
       * @param[in] dataStorageArea defines the data storage area.
       */       
        public bool Save(WordBanList wordBanList, DataStorageArea dataStorageArea);

        /*!
       * @brief a method that has a comparison of whether there is a load or not.
       * @param[in] wordBanList defines a word list.
       * @param[in] dataStorageArea defines the data storage area.
       */
        public bool Load(WordBanList wordBanList, DataStorageArea dataStorageArea);
    }
}