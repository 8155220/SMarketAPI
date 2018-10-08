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
                    SellPrice = table.Column<string>(nullable: true),
                    BuyPrice = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<string>(nullable: true),
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
                    ImageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Caucho", "Genérica" },
                    { 2, "Caucho", "Gorgeous" },
                    { 3, "Plástico", "Artesanal" },
                    { 4, "Soft", "Licencia" },
                    { 5, "Fresco", "Increíble" },
                    { 6, "Soft", "Increíble" },
                    { 7, "Metal", "Elegante" },
                    { 8, "Plástico", "Pequeño" },
                    { 9, "Frozen", "Increíble" },
                    { 10, "Acero", "Rústico" }
                });

            migrationBuilder.InsertData(
                table: "UnitType",
                columns: new[] { "UnitTypeId", "Description" },
                values: new object[,]
                {
                    { 1, "kilos" },
                    { 2, "gramos" },
                    { 3, "litros" },
                    { 4, "mililitros" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[,]
                {
                    { 3, "787.17", "Fidalgo Cencellada Gemiquear Bastonazo Incorporeidad.", "8/6/2019 8:41:18 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/kanickairaj/128.jpg", "Elegante Fresco Jabón", 7, "287.00", 1 },
                    { 6, "280.29", "Descervigar Abadiado Cendrada Bátavo Genealogía Generacional.", "8/7/2019 6:57:05 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/ntfblog/128.jpg", "Pequeño Soft Camisa", 7, "613.77", 1 },
                    { 8, "426.95", "Bástulo Fideicomiso Descensión Engarbullar Ceneque.", "7/26/2019 10:47:17 AM", "https://s3.amazonaws.com/uifaces/faces/twitter/mattdetails/128.jpg", "Ergonómico Frozen Ratón", 9, "933.04", 1 },
                    { 9, "467.13", "Incorrección Fideísmo Cenero Bateador.", "3/27/2019 12:31:35 AM", "https://s3.amazonaws.com/uifaces/faces/twitter/idiot/128.jpg", "Sin marca Madera Auto", 2, "511.47", 1 },
                    { 5, "404.89", "Ceñar Fidalgo Abajamiento Cenefa Batalán Incorruptamente Incorregibilidad.", "6/17/2019 11:00:50 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/rohixx/128.jpg", "Elegante Acero Sombrero", 7, "844.63", 2 },
                    { 1, "180.12", "Batallola Engarbullar Descerebrado Incorregibilidad Géminis Generador Batanear.", "9/7/2019 8:16:55 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/scottiedude/128.jpg", "Pequeño Fresco Zapatos", 6, "403.85", 3 },
                    { 7, "308.04", "Cencuate Engarbullar Cenco.", "12/28/2018 10:42:14 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/RussellBishop/128.jpg", "Práctica Acero Toallas", 2, "511.04", 3 },
                    { 10, "0.58", "Abadí Descimbramiento Batanero Incorporación.", "6/1/2019 6:05:31 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/alsobrooks/128.jpg", "Licencia Metal Jabón", 4, "673.11", 3 },
                    { 2, "381.71", "Cencío Descervigar Incorporeidad.", "8/31/2019 3:10:52 AM", "https://s3.amazonaws.com/uifaces/faces/twitter/beshur/128.jpg", "Inteligente Fresco Ratón", 6, "155.92", 4 },
                    { 4, "874.22", "Incrementar Cencellada Abad Gendarme Descenso Cencuate Gendarme Gemíparo Batallar.", "10/7/2018 5:32:45 PM", "https://s3.amazonaws.com/uifaces/faces/twitter/txcx/128.jpg", "Hecho a mano Soft Jabón", 5, "244.26", 4 }
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
