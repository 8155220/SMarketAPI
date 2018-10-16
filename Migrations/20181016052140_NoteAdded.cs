using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class NoteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ReceivedBy = table.Column<string>(nullable: true),
                    DeliveredTo = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    NoteType = table.Column<string>(nullable: true),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NoteId);
                });

            migrationBuilder.CreateTable(
                name: "ProductNoteDetail",
                columns: table => new
                {
                    ProductNoteDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReceivedBy = table.Column<string>(nullable: true),
                    NoteType = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductNoteDetail", x => x.ProductNoteDetailId);
                    table.ForeignKey(
                        name: "FK_ProductNoteDetail_Note_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Note",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductNoteDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Fantástico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Cotton", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Artesanal" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Soft", "Práctica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Elegante" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Genérica" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductNoteDetail_NoteId",
                table: "ProductNoteDetail",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductNoteDetail_ProductId",
                table: "ProductNoteDetail",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductNoteDetail");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Ergonómico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Hecho a mano" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Frozen", "Elegante" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Soft", "Refinado" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Hecho a mano" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Práctica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Rústico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Soft", "Rústico" });
        }
    }
}
