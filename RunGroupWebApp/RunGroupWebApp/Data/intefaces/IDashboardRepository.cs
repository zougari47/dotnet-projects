using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data.intefaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
    }
}
