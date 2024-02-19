using user_monitoring.Models;
using user_monitoring.Services.Interfaces;

namespace user_monitoring.Services
{
    public class ProgramBanListService : IProgramBanListService
    {
        public bool SaveProgramBanList(ProgramBanList programBanList)
        {
            return false;
        }

        public bool LoadProgramBanList(string? pathForLoad)
        {
            return false;
        }
    }
}