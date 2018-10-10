using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    UnitTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Symbol = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.UnitTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Provider = table.Column<string>(nullable: true),
                    SellPrice = table.Column<decimal>(nullable: false),
                    BuyPrice = table.Column<decimal>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    UnitTypeId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "UnitTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Caucho", "Práctica" },
                    { 2, "Acero", "Pequeño" },
                    { 3, "Madera", "Increíble" },
                    { 4, "Hormigón", "Increíble" },
                    { 5, "Caucho", "Gorgeous" },
                    { 6, "Plástico", "Hecho a mano" },
                    { 7, "Soft", "Fantástico" },
                    { 8, "Madera", "Rústico" },
                    { 9, "Cotton", "Gorgeous" },
                    { 10, "Plástico", "Sabrosa" }
                });

            migrationBuilder.InsertData(
                table: "UnitType",
                columns: new[] { "UnitTypeId", "Description", "Symbol" },
                values: new object[,]
                {
                    { 1, "kilos", null },
                    { 2, "gramos", null },
                    { 3, "litros", null },
                    { 4, "mililitros", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "Provider", "SellPrice", "UnitTypeId" },
                values: new object[,]
                {
                    { 3, 669.27m, "Engaritar Cendrazo Incorruptible Engarro Bateaguas Engastar Cendra Fidedigno Incorporar Cencerra.", new DateTime(2018, 12, 14, 11, 27, 29, 876, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/victor_haydin/128.jpg", "Artesanal Frozen Pantalones", 2, null, 357.16m, 1 },
                    { 2, 629.49m, "Descerebrar Cendrado Bate Abajo Descercar Batallola General Incorporar.", new DateTime(2018, 11, 15, 2, 29, 36, 979, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/rpatey/128.jpg", "Elegante Soft Bike", 5, null, 680.46m, 2 },
                    { 5, 332.91m, "Ficha Cenceñada Fideísmo Descerrumarse Descentralizador Generación Abacero Engarbarse Bataola.", new DateTime(2019, 2, 5, 10, 29, 26, 64, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/logorado/128.jpg", "Rústico Frozen Zapatos", 1, null, 644.10m, 2 },
                    { 1, 678.57m, "Cencerril Descifre Incorporal Incorruptibilidad Incorporación Abacalero.", new DateTime(2019, 2, 27, 22, 16, 44, 464, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/sprayaga/128.jpg", "Ergonómico Hormigón Pollo", 9, null, 469.43m, 3 },
                    { 4, 786.79m, "Engaritar Generalato Descerrar Cendrar Batatazo Batata Engastadura Descepar.", new DateTime(2019, 8, 23, 19, 45, 41, 108, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/jesseddy/128.jpg", "Inteligente Cotton Pizza", 5, null, 561.08m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "UnitType");
        }
    }
}
