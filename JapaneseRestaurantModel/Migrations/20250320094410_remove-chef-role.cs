using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JapaneseRestaurantModel.Migrations
{
    /// <inheritdoc />
    public partial class removechefrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Chefs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Chefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: "Chef");

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Role",
                value: "Chef");
        }
    }
}
