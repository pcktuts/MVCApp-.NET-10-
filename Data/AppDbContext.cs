using Microsoft.EntityFrameworkCore;
using MVCApp.Model;

namespace MVCApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
       
    }
}
