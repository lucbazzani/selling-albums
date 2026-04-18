using Microsoft.EntityFrameworkCore;
using SellingAlbums.Context;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly AppDbContext _context;

        public AlbumRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Album> Albums => _context.Albums
                                    .Include(a => a.Artist)
                                    .Include(a => a.Genre);

        public IEnumerable<Album> FavouriteAlbums => _context.Albums
                                    .Where(a => a.IsAlbumFavourite)
                                    .Include(a => a.Artist)
                                    .Include(a => a.Genre);

        public Album GetAlbumById(int id)
        {
            return _context.Albums
                    .FirstOrDefault(a => a.AlbumId == id);
        }
    }
}
