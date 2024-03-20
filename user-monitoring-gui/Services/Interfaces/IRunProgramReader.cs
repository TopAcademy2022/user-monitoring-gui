namespace user_monitoring_gui.Services.Interfaces
{
    public interface IRunProgramReader
    {
        public bool CheckRunProgram(string programName);

        public bool KillProgram(string programName);
    }
}