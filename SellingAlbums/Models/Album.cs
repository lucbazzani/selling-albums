using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingAlbums.Models
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Album title is required")]
        [StringLength(100, ErrorMessage = "Album title exceed 100 characters")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Album price is required")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, 999.99, ErrorMessage = "Price must be between 0.01 and 999.99")]
        public decimal Price { get; set; }

        [Display(Name = "Cover URL")]
        [StringLength(200, ErrorMessage = "Cover URL cannot exceed 200 characters")]
        public string CoverUrl { get; set; }

        [Display(Name = "Cover Thumbnail URL")]
        [StringLength(200, ErrorMessage = "Cover Thumbnail URL cannot exceed 200 characters")]
        public string CoverThumbnailUrl { get; set; }

        [Display(Name = "Is favorite?")]
        public bool IsAlbumFavourite { get; set; }

        [Required(ErrorMessage = "Album availability is required")]
        [Display(Name = "Is available?")]
        public bool IsAvailable { get; set; }


        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
