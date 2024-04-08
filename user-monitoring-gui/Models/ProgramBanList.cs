/*!
 * @namespace user_monitoring_gui.Models
 * @brief Contains the classes related to the user monitoring GUI.
 */
namespace user_monitoring_gui.Models
{
    /*!
     * @class ProgramBanList
     * @brief Represents a list of banned programs.
     */
    public class ProgramBanList
    {
        private List<string> _programBanList;

        /*!
         * @brief Initializes a new instance of the ProgramBanList class.
         */
        public ProgramBanList()
        {
            this._programBanList = new List<string>();
        }

        /*!
         * @brief Gets the list of banned programs.
         * @return The list of banned programs.
         */
        public List<string> GetProgramBanList()
        {
            return this._programBanList;
        }

        /*!
         * @brief Adds a program to the list of banned programs.
         * @param programName The name of the program to add.
         */
        public void AddProgram( string programName )
        {
            this._programBanList.Add(programName);
        }

        /*!
         * @brief Removes a program from the list of banned programs.
         * @param programName The name of the program to remove.
         */
        public void RemoveProgram( string programName )
        {
            this._programBanList.Remove(programName);
        }
    }
}