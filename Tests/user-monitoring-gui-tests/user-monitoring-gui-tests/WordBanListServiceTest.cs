using user_monitoring_gui.Models;
using user_monitoring_gui.Services;
using user_monitoring_gui.Services.Interfaces;


namespace user_monitoring_gui_tests
{
    /*!
    * \ brief Class  WordBanListServiceTest for testing methods 
    */
    public class WordBanListServiceTest
    {
        private static readonly IServerRequest request;   /// Itialization of the required parameter

        private WordBanList wordBanList = new WordBanList();  /// Implementation of the class under test

        private WordBanListService wordBanListService = new WordBanListService(request);  /// Implementation of the class under test

        const string FILE_NAME = "WordBanList.txt";  /// Initialization of the file name constant variable

        int numberTestEntries = 3;  /// Number of test records in the file

        /*!
         * \ brief SaveFileTest method to check if the transferred data is saved 
         */
        [Fact]
        public void SaveFileTest()
        {
            /*
             * - file exist verification
             */
            FileInfo file = new FileInfo(FILE_NAME);

            if (file.Exists)
            {
                file.Delete();
            }

            for (int i = 0; i < numberTestEntries; i++)
            {
                wordBanList.AddWord($"Test{i}");
            }

            wordBanListService.Save(wordBanList, DataStorageArea.FILE);

            var result = File.ReadLines(FILE_NAME);

            Assert.True(result.Count() == numberTestEntries);

        }

        /*!
        * \ brief LoadFileTest method to test data loading 
        */
        [Fact]
        public void LoadFileTest()
        {
            FileInfo file = new FileInfo(FILE_NAME);

            if (file.Exists)
            {
                file.Delete();
            }

            for (int i = 0; i < numberTestEntries; i++)
            {
                wordBanList.AddWord($"Test{i}");
            }

            wordBanListService.Save(wordBanList, DataStorageArea.FILE);

            var result = wordBanListService.Load(wordBanList, DataStorageArea.FILE);

            Assert.True(result);
        }
    }
}