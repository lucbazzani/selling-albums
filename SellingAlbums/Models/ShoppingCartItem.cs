using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingAlbums.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Album Album { get; set; }

        public int Quantity { get; set; }

        [MaxLength(200)]
        public string ShoppingCartId { get; set; }
    }
}
