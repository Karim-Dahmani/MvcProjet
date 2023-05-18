using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomDotNet.Migrations
{
    /// <inheritdoc />
    public partial class ISBNmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductISBN",
                table: "Produit",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductISBN",
                table: "Produit");
        }
    }
}
