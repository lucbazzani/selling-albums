using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;
using SellingAlbums.ViewModels;
using System.Diagnostics;

namespace SellingAlbums.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumRepository _albumRepository;

        public HomeController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeViewModel
            {
                FavouriteAlbums = _albumRepository.FavouriteAlbums
            };

            return View(homeVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
