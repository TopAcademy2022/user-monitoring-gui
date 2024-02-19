using user_monitoring.Models;

namespace user_monitoring.Services.Interfaces
{
    public interface IProgramBanListService
    {
        public bool SaveProgramBanList(ProgramBanList programBanList);

        public bool LoadProgramBanList(string? pathForLoad);
    }
}