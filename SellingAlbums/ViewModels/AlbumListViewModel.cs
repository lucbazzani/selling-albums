using SellingAlbums.Models;

namespace SellingAlbums.ViewModels
{
    public class AlbumListViewModel
    {
        public IEnumerable<Album> Albums { get; set; }
        public string GenreName { get; set; }
    }
}
