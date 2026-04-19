using Microsoft.AspNetCore.Mvc;
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

        public IActionResult List()
        {
            var albumsListViewModel = new AlbumListViewModel();
            albumsListViewModel.Albums = _albumRepository.Albums;
            albumsListViewModel.GenreName = "All";

            return View(albumsListViewModel);
        }
    }
}
