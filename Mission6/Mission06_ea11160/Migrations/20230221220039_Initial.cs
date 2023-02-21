using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ea11160.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "MovieEntries",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryID = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_MovieEntries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "Sports" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 9, "Western" });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 1, "John McTiernan", false, "", "Awesome Movie!", "PG", "The Hunt for Red October", 1990 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 2, "Disney", true, "Rosey", "Jake's pre-church movie this week.", "G", "Pocahontas", 1995 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 7, "Netflix", false, "", "Cute, but why can't Ryan Reynolds be in every movie?", "PG-13", "Your Place Or Mine", 2023 });

            migrationBuilder.CreateIndex(
                name: "IX_MovieEntries_CategoryID",
                table: "MovieEntries",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieEntries");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
