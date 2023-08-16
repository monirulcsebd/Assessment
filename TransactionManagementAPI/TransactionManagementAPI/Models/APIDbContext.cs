using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TransactionManagementAPI.Models;

namespace StudentAPI.Models
{
    public class APIDbContex : DbContext
    {
        public APIDbContex(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClientTransaction> client_transaction { get; set; }
    }
}
