using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingAlbums.Models
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Genre name is required")]
        [StringLength(100, ErrorMessage = "Artist name cannot exceed 100 characters")]
        [Display(Name = "Genre name")]
        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}
