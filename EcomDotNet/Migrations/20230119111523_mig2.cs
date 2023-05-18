using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panier",
                columns: table => new
                {
                    PanierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanierDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panier", x => x.PanierID);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    CmdID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanierID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.CmdID);
                    table.ForeignKey(
                        name: "FK_Commande_Panier_PanierID",
                        column: x => x.PanierID,
                        principalTable: "Panier",
                        principalColumn: "PanierID");
                });

            migrationBuilder.CreateTable(
                name: "LignePanier",
                columns: table => new
                {
                    LignePanierID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LigneQuantité = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ProduitProductID = table.Column<int>(type: "int", nullable: true),
                    CommandeCmdID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LignePanier", x => x.LignePanierID);
                    table.ForeignKey(
                        name: "FK_LignePanier_Commande_CommandeCmdID",
                        column: x => x.CommandeCmdID,
                        principalTable: "Commande",
                        principalColumn: "CmdID");
                    table.ForeignKey(
                        name: "FK_LignePanier_Produit_ProduitProductID",
                        column: x => x.ProduitProductID,
                        principalTable: "Produit",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_PanierID",
                table: "Commande",
                column: "PanierID");

            migrationBuilder.CreateIndex(
                name: "IX_LignePanier_CommandeCmdID",
                table: "LignePanier",
                column: "CommandeCmdID");

            migrationBuilder.CreateIndex(
                name: "IX_LignePanier_ProduitProductID",
                table: "LignePanier",
                column: "ProduitProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LignePanier");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Panier");
        }
    }
}
