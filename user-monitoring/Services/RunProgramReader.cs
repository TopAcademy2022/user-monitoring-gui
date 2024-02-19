using user_monitoring.Services.Interfaces;

namespace user_monitoring.Services
{
    public class RunProgramReader : IRunProgramReader
    {
        public bool CheckRunProgram(string programName)
        {
            return false;
        }

        public bool KillProgram(string programName)
        {
            return false;
        }
    }
}