using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class changeNameOfColInTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "ProductDetails",
                newName: "Flavor");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Carts",
                newName: "Flavor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Flavor",
                table: "ProductDetails",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Flavor",
                table: "Carts",
                newName: "Color");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
