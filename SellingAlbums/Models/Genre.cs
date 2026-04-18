namespace SellingAlbums.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}
