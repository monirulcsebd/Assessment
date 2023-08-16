using Microsoft.EntityFrameworkCore;

namespace ReportGenerationAPI.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClientTransaction> client_transaction{ get; set; }
    }
}
