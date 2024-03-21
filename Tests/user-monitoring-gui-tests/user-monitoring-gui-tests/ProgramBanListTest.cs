using user_monitoring_gui.Models;

namespace user_monitoring_gui_tests
{
    /*!
     *  \test - Class ProgramBanListTest for testing methods 
     */
    public class ProgramBanListTest
    {
        private ProgramBanList programBanList = new ProgramBanList(); /// - Implementation of the class under test

        /*!
         *  \test - Test Method for checking the transferred sheet for initialization 
         */
        [Fact]
        public void GetProgramBanListTest( )
        {
            var result = programBanList.GetProgramBanList();
            Assert.NotNull(result);
        }

        /*!
         *  \test - Test Verification method adds value to the list
         */
        [Fact]
        public void AddProgramTest()
        {
            programBanList.AddProgram("Test1");
            programBanList.AddProgram("Test2");
            programBanList.AddProgram("Test3");

            var result = programBanList.GetProgramBanList();

            Assert.Contains( "Test2", result );
        }

        /*!
         *  \test - Test Method for checking whether a value is removed from a list
         */
        [Fact]
        public void RemoveProgramTest()
        {
            programBanList.AddProgram("Test1");
            programBanList.AddProgram("Test2");
            programBanList.AddProgram("Test3");

            programBanList.RemoveProgram("Test2");

            var result = programBanList.GetProgramBanList();

            Assert.DoesNotContain("Test2", result);
        }
    }
}
