namespace user_monitoring_gui.Services.Interfaces
{

    public interface IRunProgramReader
    {

       /*! 
       * @brief Interface for managing and checking running programs.
       * @param[in] The name of the program to check.
       * @return True if the program is running; otherwise, false.
       */
        public bool CheckRunProgram(string programName);

        /*! 
        * @brief Interface for managing programs.,Kills a running program by its name.
        * @param[in] The name of the program to kill.
        * @return true</c> if the program was successfully killed; otherwise, <c>false</c>
        */
        public bool KillProgram(string programName);
    }
}