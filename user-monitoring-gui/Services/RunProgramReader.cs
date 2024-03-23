using System.Diagnostics;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class RunProgramReader : IRunProgramReader /*объявление класса RunProgramReader, который реализует интерфейс IRunProgramReader.*/
    {
        /*!
         * @brief Checks if the specified program is running.
         * @details Iterates through all processes to find a match for the program name.
         * @param programName The name of the program to check.
         * @return True if the program is running, false otherwise.
         */
        public bool CheckRunProgram( string programName ) /*метод для проверки запущен ли указанный программный процесс.*/
        {
            Process[] allProcesses = Process.GetProcesses(); /*получение массива запущенных процессов.*/
            bool isProgramRunning = false; /*инициализация переменной для хранения статуса запущен ли искомый процесс.*/
            int i = 0;

            while (i < allProcesses.Length && !isProgramRunning) /*циклы while проходят через все процессы и проверяют, есть ли среди них искомый процесс.*/
            
            {
                Process process = allProcesses[i];

                Process[] processesByName = Process.GetProcessesByName( programName );
                int j = 0;

                while (j < processesByName.Length && !isProgramRunning)
                {
                    Process processByProgramName = processesByName[j];

                    if (process.ProcessName == processByProgramName.ProcessName) /*Если процесс найден, переменная isProgramRunning становится равной true.*/
                    {
                        isProgramRunning = true;
                    }
                    j++;
                }

                i++;
            }

            return isProgramRunning;
        }

        /*!
         * @brief Kills the specified program.
         * @details Iterates through processes with the specified name and terminates them.
         * @param programName The name of the program to kill.
         * @return True if at least one process is successfully killed, false otherwise.
         */
                        public bool KillProgram( string programName )  /*метод для завершения указанного программного процесса.*/
        {
            bool isAnyProcessKilled = false;/* Переменные isAnyProcessKilled и processFound используются для отслеживания успешного завершения процесса.*/
            bool processFound = false;
            Process[] allProcesses = Process.GetProcesses();/*получение массива запущенных процессов.*/
            int i = 0;

            while (i < allProcesses.Length) /*перебором всех процессов в системе с помощью цикла while, находим процесс с именем, совпадающим с programName.*/ 
            {
                Process process = allProcesses[i];

                if (process.ProcessName == programName) /*если такой процесс найден, он завершается методом Kill().*/
                {
                    process.Kill();

                    if (process.HasExited) /*Если процесс завершился*/ 
                    {
                        isAnyProcessKilled = true; /*Возвращается isAnyProcessKilled – true, если хотя бы один процесс был успешно завершен.*/
                    }
                    processFound = true; 
                }

                i++;
            }

            if (!processFound) /*если процесс не найден то выводим*/
            {
                Console.WriteLine( "No process found with the specified name." );
            }

            return isAnyProcessKilled;
        }
    }
}
