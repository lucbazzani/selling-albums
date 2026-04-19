using Microsoft.EntityFrameworkCore;
using SellingAlbums.Context;

namespace SellingAlbums.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            // defines a session
            // if GetRequiredService<IHttpContextAccessor>() returns null, it will throw an exception, otherwise it will return the service instance
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // gets a service of type AppDbContext from the service provider
            var context = service.GetService<AppDbContext>();

            // gets the CartId from the session, if it doesn't exist, it creates a new one using Guid.NewGuid().ToString()
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            // sets the CartId in the session
            session.SetString("CartId", cartId);

            // returns a new instance of ShoppingCart with the context and CartId
            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId,
            };
        }

        public void AddToCart(Album album)
        {
            var shoppingCartItem = FindCartItem(album);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Album = album,
                    Quantity = 1,
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public int RemoveFromCart(Album album)
        {
            var shoppingCartItem = FindCartItem(album);
            int itemQuantity = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    itemQuantity = shoppingCartItem.Quantity;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);

                }
                _context.SaveChanges();
            }
            return itemQuantity;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = 
                                            _context.ShoppingCartItems
                                            .Where(c => c.ShoppingCartId == ShoppingCartId)
                                            .Include(i => i.Album)
                                            .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems
                            .Where(c => c.ShoppingCartId == ShoppingCartId);
            _context.ShoppingCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems
                        .Where(c => c.ShoppingCartId == ShoppingCartId)
                        .Select(c => c.Album.Price * c.Quantity).Sum();
            return total;
        }

        private ShoppingCartItem FindCartItem(Album album)
        {
            return _context.ShoppingCartItems.SingleOrDefault(
                s => s.Album.AlbumId == album.AlbumId &&
                s.ShoppingCartId == ShoppingCartId);
        }
    }
}
