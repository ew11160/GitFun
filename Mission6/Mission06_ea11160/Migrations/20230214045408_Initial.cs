using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ea11160.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieEntries",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieEntries", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Rom-Com", "Netflix", false, "", "Cute, but why can't Ryan Reynolds be in every movie?", "PG-13", "Your Place Or Mine", 2023 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "John McTiernan", false, "", "Awesome Movie!", "PG", "The Hunt for Red October", 1990 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Animated", "Disney", true, "Rosey", "Jake's pre-church movie this week.", "G", "Pocahontas", 1995 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieEntries");
        }
    }
}
