using System.Diagnostics;
using user_monitoring_gui.Services;

namespace user_monitoring_gui_tests
{
    /*!
     *  \test - Class RunProgramReaderTest for testing methods 
     */
    public class RunProgramReaderTest
    {
        private RunProgramReader runProgramReader = new RunProgramReader(); /// - Implementation of the class under test

        /*!
         *  \test - test method to check if a program is open
         */
        [Fact]
        public void CheckRunProgramTest() 
        {
            Process p = Process.Start( "notepad" );
            var rezult = runProgramReader.CheckRunProgram( "notepad" );
            Assert.True( rezult );
            runProgramReader.KillProgram( "notepad" );
        }

        /*!
         *  \test - Test method to check if it closes open program
         */
        [Fact]
        public void KillProgramTest()
        {
            Process p = Process.Start( "notepad" );
            var rezult = runProgramReader.KillProgram( "notepad" );
            Assert.True( rezult );
        }
    }
}
