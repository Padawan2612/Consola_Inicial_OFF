using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;


namespace WebApplication1.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Mountain> Mountains { get; set; }
        public MainDbContext(DbContextOptions<MainDbContext>dbContextOptions): base (dbContextOptions)
        {

        }
        
    }
}
