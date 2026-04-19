using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IAlbumRepository albumRepository, ShoppingCart shoppingCart)
        {
            _albumRepository = albumRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
