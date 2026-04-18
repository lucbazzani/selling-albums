using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellingAlbums.Migrations
{
    public partial class PopulateAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                "VALUES(1, 1, 'Self-Titled', 2026, 5.00, 'https://drive.google.com/file/d/1xfMlQ6NU3PTWjM6bQh1qS70dLICItu8b/view?usp=sharing', 'https://drive.google.com/file/d/1uqS9Mw2hSyE_85Mp9WQX3dSXTYrDf40j/view?usp=drive_link', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                "VALUES(2, 2, 'In Utero', 1993, 10.00, 'https://drive.google.com/file/d/1lAk0QLJ1TuPhc8KEyrd8m5mmgXWHf6CK/view?usp=drive_link', 'https://drive.google.com/file/d/1EBws2qWlFforX3mLQkDqV_xwi1PauC1N/view?usp=drive_link', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                 "VALUES(3, 12, 'Todo Va Hacia El Mar', 2023, 7.00, 'https://drive.google.com/file/d/1GDveww4liM0h4NR6kmfHgQs9DZkYb3wW/view?usp=drive_link', 'https://drive.google.com/file/d/1nFsSr0j3dPeirmjjMXJ2ChrSXJYflAzI/view?usp=sharing', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                 "VALUES(4, 4, 'Hyperview', 2015, 8.50, 'https://drive.google.com/file/d/1eyOp_BCD8o6Y8Z5Nrl2CPMHlhnXiHXGV/view?usp=drive_link', 'https://drive.google.com/file/d/1qYLrHN6k_0gRny05MYTk4IFuL__mVpuY/view?usp=drive_link', 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Albums");
        }
    }
}
