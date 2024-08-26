using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;

namespace TelemetryPortal_MVC.Repositoty
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context): base(context) 
        { 
        }

        public Project GetMoreRecentProject()
        {
            return _context.Projects.OrderByDescending(Project => Project.ProjectCreationDate).FirstOrDefault();
        }
    }
}
