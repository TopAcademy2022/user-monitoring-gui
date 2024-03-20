using System.Diagnostics;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class RunProgramReader : IRunProgramReader
    {
        public bool CheckRunProgram(string programName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                foreach (Process processByProgramName in Process.GetProcessesByName(programName))
                {
                    if (process.ProcessName == processByProgramName.ProcessName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool KillProgram(string programName)
        {
            foreach (Process processByProgramName in Process.GetProcessesByName(programName))
            {
                processByProgramName.Kill();
                return true;
            }

            return false;
        }
    }
}