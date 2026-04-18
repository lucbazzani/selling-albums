using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellingAlbums.Migrations
{
    public partial class PopulateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genres(Name) " +
                "VALUES('Rock')," +
                "('Grunge'), " +
                "('Indie'), " +
                "('Hardcore'), " +
                "('Punk'), " +
                "('Alternative Metal'), " +
                "('Jazz Rock'), " +
                "('Emo'), " +
                "('Nu Metal'), " +
                "('MPB (Brazilian Popular Music'), " +
                "('Post-Rock'), " +
                "('Post-Punk'), " +
                "('Alternative')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM genres");
        }
    }
}
