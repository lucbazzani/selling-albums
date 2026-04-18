using SellingAlbums.Models;

namespace SellingAlbums.Repositories.Interfaces
{
    public interface IArtistRepository
    {
        // Artists in this case is a read only property.
        // IEnumerable is a read only collection that iterates sequentially through the collection
        IEnumerable<Artist> Artists { get; }
    }
}
