using Dating_webapp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating_webapp.Data
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, UserName = "Kevin" },
                new AppUser { Id = 2, UserName = "Levin" },
                new AppUser { Id = 3, UserName = "Cevin" },
                new AppUser { Id = 4, UserName = "Mevin" },
                new AppUser { Id = 5, UserName = "Fevin" }
                );
        }
    }
}
