namespace user_monitoring_gui.Services.Interfaces
{
    public interface IUserInterface
    {
        public void PrintMenu();

        public void PrintMenuSettings();

        public void PrintMenuWordBanList();

        public void PrintMenuProgramBanList();

        public void RunProgram();

        public void PrintMenuStatistic();
    }
}