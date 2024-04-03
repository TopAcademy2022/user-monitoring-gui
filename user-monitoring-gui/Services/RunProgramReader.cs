using System.Diagnostics;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class RunProgramReader : IRunProgramReader
    {
        /*!
         * @brief Checks if the specified program is currently running.
         * This method iterates through all processes to find a match for the program name.
         * @param programName The name of the program to check for.
         * @return True if the program is currently running, false otherwise.
         */
        public bool CheckRunProgram( string programName )
        {
            foreach (Process process in Process.GetProcesses()) /* Iterate through all processes*/
            {
                foreach (Process processByProgramName in Process.GetProcessesByName( programName ))/* Iterate through processes with the specified program name*/
                {
                    if (process.ProcessName == processByProgramName.ProcessName) /* Check if process names match*/
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*!
        * @brief Kills the specified program.
        * @details Iterates through processes with the specified name and terminates them.
        * @param programName The name of the program to kill.
        * @return True if at least one process is successfully killed, false otherwise.
        */
        public bool KillProgram(string programName)  
        {
            bool isAnyProcessKilled = false;
            bool processFound = false;
            Process[] allProcesses = Process.GetProcesses();
            int i = 0;

            while (i < allProcesses.Length) 
            {
                Process process = allProcesses[i];

                if (process.ProcessName.ToLower() == programName.ToLower()) 
                {
                    process.Kill();

                    if (process.HasExited) 
                    {
                        isAnyProcessKilled = true; 
                    }
                    processFound = true;
                }
                i++;
            }

            if (!processFound) 
            {
                Console.WriteLine( "No process found with the specified name." );
            }
            return isAnyProcessKilled;
        }
    }
}
