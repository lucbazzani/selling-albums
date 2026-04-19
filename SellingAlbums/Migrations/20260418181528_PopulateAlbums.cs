using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellingAlbums.Migrations
{
    public partial class PopulateAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                "VALUES(1, 1, 'Um Resgate Não Será Possível', 2026, 5.00, '/images/um-resgate-nao-sera-possivel-urnsp-cover.jpg', '/images/um-resgate-nao-sera-possivel-urnsp-thumbnail.jpg', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                "VALUES(2, 2, 'In Utero', 1993, 10.00, '/images/in-utero-nirvana-cover.jpg', '/images/in-utero-nirvana-thumbnail.jpg', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                 "VALUES(3, 12, 'Todo Va Hacia El Mar', 2023, 7.00, '/images/todo-va-hacia-el-mar-fdm-cover.jpg', '/images/todo-va-hacia-el-mar-fdm-thumbnail.jpg', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Albums(ArtistId, GenreId, Title, Year, Price, CoverUrl, CoverThumbnailUrl, IsAlbumFavourite, IsAvailable) " +
                 "VALUES(4, 4, 'Hyperview', 2015, 8.50, '/images/hyperview-tf-cover.jpg', '/images/hyperview-tf-thumbnail.jpg', 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Albums");
        }
    }
}
