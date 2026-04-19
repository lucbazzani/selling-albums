using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Repositories.Interfaces;

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
            var albums = _albumRepository.Albums;
            return View(albums);
        }
    }
}
