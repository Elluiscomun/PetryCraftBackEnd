using Microsoft.EntityFrameworkCore;
using Swagger5._0.Model;

namespace Swagger5._0.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }

        public DbSet<User> Users { get; set; }
       
    }
}
