using LogisticsCenterMODELS.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticsCenterAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            :base(options) 
        {
        
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<External_User> External_User { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}
