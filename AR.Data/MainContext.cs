using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
    }
}
