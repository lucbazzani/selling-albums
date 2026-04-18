using SellingAlbums.Models;

namespace SellingAlbums.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        // Genres in this case is a read only property.
        // IEnumerable is a read only collection that iterates sequentially through the collection
        IEnumerable<Genre> Genres { get; }
    }
}
