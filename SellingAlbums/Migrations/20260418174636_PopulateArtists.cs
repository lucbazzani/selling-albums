using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellingAlbums.Migrations
{
    public partial class PopulateArtists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Artists(Name) " +
                "VALUES('Um Resgate Não Será Possível')," +
                "('Nirvana'), " +
                "('Fin Del Mundo'), " +
                "('Title Fight'), " +
                "('Gorillaz'), " +
                "('Nadar De Noche'), " +
                "('Cianoceronte'), " +
                "('My Chemical Romance'), " +
                "('Deftones'), " +
                "('Turnstile')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM artists");
        }
    }
}
