using GameStoreApp.Data.Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Card> Card{ get; set; } = null!;
        public DbSet<Developer> Developer { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<GameTag> GameTag { get; set; } = null!;
        public DbSet<Genre> Genre { get; set; } = null!;
        public DbSet<Purchase> Purchase { get; set; } = null!;
        public DbSet<Tag> Tag { get; set; } = null!;

        public DbSet<User> User { get; set; } = null!;

    }
}
