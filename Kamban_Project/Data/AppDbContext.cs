using Microsoft.EntityFrameworkCore;

namespace Kamban_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>Options) : base(Options)
        {
            
        }



    }
}
