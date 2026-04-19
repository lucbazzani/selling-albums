using Microsoft.EntityFrameworkCore;
using SellingAlbums.Models;

namespace SellingAlbums.Context
{
    public class AppDbContext : DbContext
    {
        // DbContextOptions<> defines the options used by a DbContext
        // and loads the necessaries information for setting up the DbContext.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Classes that will be mapped into the Database and their respectives table names
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
