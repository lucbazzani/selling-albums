using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Models;
using SellingAlbums.Repositories.Interfaces;
using SellingAlbums.ViewModels;

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
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                CartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartVM);
        }
        
        public RedirectToActionResult AddItemToShoppingCart(int albumId)
        {
            var selectedAlbum = _albumRepository.Albums.FirstOrDefault(a => a.AlbumId == albumId);
            if (selectedAlbum != null)
            {
                _shoppingCart.AddToCart(selectedAlbum);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveItemFromShoppingCart(int albumId)
        {
            var selectedAlbum = _albumRepository.Albums.FirstOrDefault(a => a.AlbumId == albumId);
            if (selectedAlbum != null)
            {
                _shoppingCart.RemoveFromCart(selectedAlbum);
            }
            return RedirectToAction("Index");
        }
    }
}
