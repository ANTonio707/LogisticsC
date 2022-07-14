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
        public DbSet<User> user { get; set; }
    }
}
