using Microsoft.EntityFrameworkCore.Migrations;

namespace Racecar_Tracker_By_UherkaMotorsports.Data.Migrations
{
    public partial class Crew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fuel",
                table: "Crew",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Gears",
                table: "Crew",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Crew");

            migrationBuilder.DropColumn(
                name: "Gears",
                table: "Crew");
        }
    }
}
