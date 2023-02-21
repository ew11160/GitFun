using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MajorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CreeperStalker = table.Column<bool>(nullable: false),
                    MajorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Responses_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "MajorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 1, "Information Systems" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 2, "Ancient Near Eastern Studies: Greek New Testament" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 3, "Accounting" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 4, "Actuarial Science" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 5, "Undeclared" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorId", "Phone" },
                values: new object[] { 1, (byte)45, false, "Michael", "Scott", 4, "555-555-1234" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationID", "Age", "CreeperStalker", "FirstName", "LastName", "MajorId", "Phone" },
                values: new object[] { 2, (byte)90, true, "Creed", "Bratton", 5, "555-123-555" });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_MajorId",
                table: "Responses",
                column: "MajorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Majors");
        }
    }
}
