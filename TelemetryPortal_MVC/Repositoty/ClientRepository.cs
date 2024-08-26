using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositoty
{
    public class ClientRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }
    }
}
