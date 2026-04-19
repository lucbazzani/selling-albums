using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;
using SellingAlbums.ViewModels;

namespace SellingAlbums.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IActionResult List(string genre)
        {
            IEnumerable<Album> albums;
            string currentGenre = string.Empty;

            if (string.IsNullOrEmpty(genre))
            {
                albums = _albumRepository.Albums.OrderBy(a => a.Title);
                currentGenre = "All";
            }
            else
            {
                albums = _albumRepository.Albums
                            .Where(a => a.Genre.Name
                            .Equals(genre, StringComparison.OrdinalIgnoreCase))
                            .OrderBy(a => a.Title);
            }
            currentGenre = genre;

            var albumsListViewModel = new AlbumListViewModel
            {
                Albums = albums,
                GenreName = currentGenre
            };

            return View(albumsListViewModel);
        }
    }
}
