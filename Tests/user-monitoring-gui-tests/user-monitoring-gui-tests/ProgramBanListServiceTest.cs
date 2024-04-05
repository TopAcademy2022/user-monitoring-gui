using System.Text;
using user_monitoring_gui.Models;
using user_monitoring_gui.Services;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui_tests
{
    /*!
     *  \test - Class ProgramBanListServiceTest for testing methods 
     */
    public class ProgramBanListServiceTest
    {
        private static IServerRequest _serverRequest;

        private ProgramBanListService programBanListService = new ProgramBanListService(_serverRequest);

        private ProgramBanList programBanList = new ProgramBanList();

        int numberTestEntries = 3;  /// Number of test records in the file

        /*!
         * \ brief SaveTest method to check if the transferred data is saved 
         */

        [Fact]
        public void SaveTest()
        {

            for (int i = 0; i < numberTestEntries; i++)
            {
                programBanList.AddProgram($"Test{i}");
            }

            programBanListService.Save(programBanList, DataStorageArea.FILE);

            Assert.True(File.ReadLines("ProgramBanList.txt").Count() == numberTestEntries);

            File.Delete("ProgramBanList.txt");
        }

        /*!
         *  \test - testing method to check if data is extracted from a file
         */

        [Fact]
        public void LoadTest()
        {
            List<string> list = new List<string>() {"Test", "Test1", "Test2", "Test3"};
            var byet = list.Select(i => Encoding.Default.GetBytes( $"{i}\n")).ToArray();
            FileStream fstream = new FileStream("ProgramBanList.txt", FileMode.Append);

            foreach(var item in byet)
            {
                fstream.Write(item, 0, item.Length);
            }
            fstream.Close();

            Assert.True(programBanListService.Load(programBanList, 0));
            File.Delete("ProgramBanList.txt");
        }
    }
}
