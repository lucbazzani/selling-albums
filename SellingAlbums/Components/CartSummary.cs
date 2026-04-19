using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Models;
using SellingAlbums.ViewModels;

namespace SellingAlbums.Components
{
    public class CartSummary : ViewComponent
    {
        public readonly ShoppingCart _shoppingCart;

        public CartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
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
    }
}
