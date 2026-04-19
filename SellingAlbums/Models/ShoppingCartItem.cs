using System.ComponentModel.DataAnnotations.Schema;

namespace SellingAlbums.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Album Album { get; set; }

        public int Quantity { get; set; }

        public int ShoppingCartId { get; set; }
    }
}
