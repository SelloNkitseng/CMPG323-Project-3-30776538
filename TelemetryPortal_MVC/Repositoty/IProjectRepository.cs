using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositoty
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Project GetMostRecentProject();
    }
}
