using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingAlbums.Models
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Artist name is required")]
        [StringLength(100, ErrorMessage = "Artist name cannot exceed 100 characters")]
        [Display(Name= "Artist name")]
        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}
