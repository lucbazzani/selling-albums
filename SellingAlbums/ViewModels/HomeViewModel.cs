using SellingAlbums.Models;

namespace SellingAlbums.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Album> FavouriteAlbums { get; set; }
    }
}
