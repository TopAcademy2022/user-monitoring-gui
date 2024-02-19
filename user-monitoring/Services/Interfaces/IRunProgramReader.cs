namespace user_monitoring.Services.Interfaces
{
    public interface IRunProgramReader
    {
        public bool CheckRunProgram(string programName);

        public bool KillProgram(string programName);
    }
}
