namespace user_monitoring.Models
{
    public class ProgramBanList
    {
        private List<string> _programBanList;

        public ProgramBanList()
        {
            this._programBanList = new List<string>();
        }

        public List<string> GetProgramBanList()
        {
            return this._programBanList;
        }

        public void AddProgram(string programName)
        {

        }

        public void RemoveProgram(string programName)
        {

        }
    }
}