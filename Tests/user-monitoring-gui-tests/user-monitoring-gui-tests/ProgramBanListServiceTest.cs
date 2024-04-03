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
        private static IServerRequest _serverReqwest;

        ProgramBanListService programBanListService = new ProgramBanListService( _serverReqwest );
        ProgramBanList programBanList = new ProgramBanList();

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
