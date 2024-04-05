namespace user_monitoring_gui.Services.Interfaces
{ /*!
   * @brief Public interfaceinterface starting the reader program
   */
    public interface IRunProgramReader
    {/*!
      * @brief public the method of checking the launch of the program
      * @param the name of the program in the form of a string
      * @return true or false
      */
        public bool CheckRunProgram(string programName);
        /*!
      * @brief public the method removing the program
      * @param the name of the program in the form of a string
      * @return true or false
      */
        public bool KillProgram(string programName);
    }
}