using user_monitoring_gui.Models;

namespace user_monitoring_gui_tests
{
    /*!
     * \ brief Class WordBanListTest for testing methods 
     */
    public class WordBanListTest
    {
        private WordBanList wordBanList = new WordBanList(); // Implementation of the class under test

        /*!
         * \ brief GetWordBanListTest method for checking the transferred sheet for initialization 
         */
        [Fact]
        public void GetWordBanListTest()
        {
            var result = wordBanList.GetWordBanList();
            Assert.NotNull(result);
        }

        /*!
         * \ brief AddProgramTest method adds value to the list
         */
        [Fact]
        public void AddWordTest()
        {
            wordBanList.AddWord("Test1");
            wordBanList.AddWord("Test2");
            wordBanList.AddWord("Test3");

            var result = wordBanList.GetWordBanList();

            Assert.Contains("Test2", result);
        }

        /*!
         * \ brief RemoveProgramTest method for checking whether a value is removed from a list
         */
        [Fact]
        public void RemoveWordTest()
        {
            wordBanList.AddWord("Test1");
            wordBanList.AddWord("Test2");
            wordBanList.AddWord("Test3");

            wordBanList.RemoveWord("Test2");

            var result =  wordBanList.GetWordBanList();

            Assert.DoesNotContain("Test2", result);
        }
    }
}
