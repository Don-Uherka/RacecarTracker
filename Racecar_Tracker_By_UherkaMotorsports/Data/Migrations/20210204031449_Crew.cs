using Microsoft.EntityFrameworkCore.Migrations;

namespace Racecar_Tracker_By_UherkaMotorsports.Data.Migrations
{
    public partial class Crew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(10, 8)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(11, 8)", nullable: false),
                    Gears = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Track");
        }
    }
}
