using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JapaneseRestaurantModel.Migrations
{
    /// <inheritdoc />
    public partial class ReviewDishRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DishId",
                table: "Reviews",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Dishes_DishId",
                table: "Reviews",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Dishes_DishId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_DishId",
                table: "Reviews");
        }
    }
}
