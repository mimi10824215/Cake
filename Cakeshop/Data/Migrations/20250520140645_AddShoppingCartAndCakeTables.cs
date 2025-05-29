using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cakeshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartAndCakeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingAddess",
                table: "Orders",
                newName: "ShoppingAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingAddress",
                table: "Orders",
                newName: "ShoppingAddess");
        }
    }
}
