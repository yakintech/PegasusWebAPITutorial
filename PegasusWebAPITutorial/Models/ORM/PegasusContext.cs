using Microsoft.EntityFrameworkCore;

namespace PegasusWebAPITutorial.Models.ORM
{
    public class PegasusContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT;Database=PegasusDb;trusted_connection=true");
        }

        public DbSet<User> Users { get; set; }

    }
}
