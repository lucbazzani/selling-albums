using SellingAlbums.Context;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext _context;

        public GenreRepository()
        {
        }

        // ASP.NET Native Dependency Injection (through a constructor parameter) injects a Context instance into the repository, allowing it to access the database
        public GenreRepository(AppDbContext context)
        {
            // AppDbContext instance
            _context = context;
        }

        // Implements Genres property that returns a collection of all Genres in the database, which is obtained through the AppDbContext instance
        public IEnumerable<Genre> Genres => _context.Genres; // Expression Bodied Member returns every Genres in the context.
    }
}
