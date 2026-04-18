namespace SellingAlbums.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string CoverUrl { get; set; }
        public string CoverThumbnailUrl { get; set; }
        public bool IsAlbumFavourite { get; set; }
        public bool IsAvailable { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
