using Microsoft.EntityFrameworkCore;

namespace TechCheckWeb.Models
{
    public class TechCheckContext : DbContext
    {
        public TechCheckContext(DbContextOptions<TechCheckContext> options) : base(options)
        {

        }

        //C# modellerini, sql tablolarına bağladım.
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
