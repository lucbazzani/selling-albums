using SellingAlbums.Context;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _context;

        // ASP.NET Native Dependency Injection (through a constructor parameter) injects a Context instance into the repository, allowing it to access the database
        public ArtistRepository(AppDbContext context)
        {
            _context = context;
        }

        // Implements Artists property that returns a collection of all Artists in the database, which is obtained through the AppDbContext instance
        public IEnumerable<Artist> Artists => _context.Artists; // Expression Bodied Member returns every Artist in the context.
    }
}
