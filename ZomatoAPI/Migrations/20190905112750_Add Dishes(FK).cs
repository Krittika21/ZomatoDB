using Microsoft.EntityFrameworkCore.Migrations;

namespace ZomatoAPI.Migrations
{
    public partial class AddDishesFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Locations_LocationID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Locations_LocationID",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_LocationID",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_City_LocationID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Locations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityID",
                table: "Locations",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryID",
                table: "Locations",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_City_CityID",
                table: "Locations",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Country_CountryID",
                table: "Locations",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_City_CityID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Country_CountryID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CityID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CountryID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "City",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_LocationID",
                table: "Country",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_City_LocationID",
                table: "City",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Locations_LocationID",
                table: "City",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Locations_LocationID",
                table: "Country",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
