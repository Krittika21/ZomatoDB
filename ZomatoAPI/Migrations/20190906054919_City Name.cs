using Microsoft.EntityFrameworkCore.Migrations;

namespace ZomatoAPI.Migrations
{
    public partial class CityName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Country",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "City",
                newName: "CityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Country",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "City",
                newName: "Name");
        }
    }
}
