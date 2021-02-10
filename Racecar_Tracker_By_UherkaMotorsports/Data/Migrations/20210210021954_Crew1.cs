using Microsoft.EntityFrameworkCore.Migrations;

namespace Racecar_Tracker_By_UherkaMotorsports.Data.Migrations
{
    public partial class Crew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nights = table.Column<int>(nullable: false),
                    Tires = table.Column<int>(nullable: false),
                    Springs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crew");
        }
    }
}
