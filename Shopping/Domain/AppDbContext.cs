using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Campaing> Campaigns { get; set; }
    }


}
