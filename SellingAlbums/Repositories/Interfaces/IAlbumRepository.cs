using SellingAlbums.Models;

namespace SellingAlbums.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> Albums { get; }
        IEnumerable<Album> FavouriteAlbums { get; }
        Album GetAlbumById(int id);

    }
}
