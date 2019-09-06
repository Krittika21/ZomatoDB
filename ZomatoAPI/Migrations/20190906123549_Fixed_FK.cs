using Microsoft.EntityFrameworkCore.Migrations;

namespace ZomatoAPI.Migrations
{
    public partial class Fixed_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantID",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurants",
                newName: "RestaurantName");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Dishes",
                newName: "RestaurantsID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dishes",
                newName: "DishesName");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_RestaurantID",
                table: "Dishes",
                newName: "IX_Dishes_RestaurantsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantsID",
                table: "Dishes",
                column: "RestaurantsID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantsID",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "RestaurantName",
                table: "Restaurants",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RestaurantsID",
                table: "Dishes",
                newName: "RestaurantID");

            migrationBuilder.RenameColumn(
                name: "DishesName",
                table: "Dishes",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_RestaurantsID",
                table: "Dishes",
                newName: "IX_Dishes_RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantID",
                table: "Dishes",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
