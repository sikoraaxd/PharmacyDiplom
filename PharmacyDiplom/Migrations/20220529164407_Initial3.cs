using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDiplom.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "PharmacyItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PharmMarket",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmMarket", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PharmMarketPharmacyItem",
                columns: table => new
                {
                    PharmMarketsID = table.Column<Guid>(type: "uuid", nullable: false),
                    PharmacyItemsID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmMarketPharmacyItem", x => new { x.PharmMarketsID, x.PharmacyItemsID });
                    table.ForeignKey(
                        name: "FK_PharmMarketPharmacyItem_PharmacyItems_PharmacyItemsID",
                        column: x => x.PharmacyItemsID,
                        principalTable: "PharmacyItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PharmMarketPharmacyItem_PharmMarket_PharmMarketsID",
                        column: x => x.PharmMarketsID,
                        principalTable: "PharmMarket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PharmMarketPharmacyItem_PharmacyItemsID",
                table: "PharmMarketPharmacyItem",
                column: "PharmacyItemsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PharmMarketPharmacyItem");

            migrationBuilder.DropTable(
                name: "PharmMarket");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "PharmacyItems");
        }
    }
}
