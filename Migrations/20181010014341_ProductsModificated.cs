using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class ProductsModificated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isMain",
                table: "Image",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                column: "Name",
                value: "Sabrosa");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Inteligente" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Rústico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Cotton", "Genérica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Genérica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                column: "Description",
                value: "Hormigón");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Increíble" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 331.22m, "Gencianáceo Desceñir Cencivera Cenceño Ficción Gemiqueo Abacial.", new DateTime(2018, 10, 16, 15, 57, 51, 289, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/giancarlon/128.jpg", "Licencia Frozen Pelota", 5, 696.82m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 391.05m, "Descerrumarse Fichero Bastonero Abadejo Cencerrear Descifrable Gemonias Incrédulo Descenso.", new DateTime(2019, 6, 2, 11, 59, 2, 714, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/benefritz/128.jpg", "Rústico Madera Zapatos", 4, 345.08m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice" },
                values: new object[] { 323.50m, "Bastonear Incorrupción Generable Abadengo Ceñar Fido Fideero Bastonada Incremento.", new DateTime(2019, 4, 22, 11, 14, 35, 526, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/kylefrost/128.jpg", "Artesanal Soft Pelota", 10, 1.30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 925.64m, "Descerebrado Engarrafar Engargantar Cencero Fideísmo Abada Abacora Descerebración Incorrupto Batallar.", new DateTime(2019, 8, 21, 21, 58, 37, 284, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/aio___/128.jpg", "Refinado Soft Pescado", 7, 923.80m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 582.82m, "Descerrajado Genealogista Genealógico Batavia.", new DateTime(2019, 6, 3, 19, 46, 44, 316, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/tur8le/128.jpg", "Pequeño Metal Bike", 8, 842.84m, 4 });

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 1,
                column: "Symbol",
                value: "kg");

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 2,
                column: "Symbol",
                value: "gr");

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 3,
                column: "Symbol",
                value: "lt");

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 4,
                column: "Symbol",
                value: "ml");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMain",
                table: "Image");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                column: "Name",
                value: "Práctica");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Hecho a mano" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Soft", "Fantástico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Rústico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                column: "Description",
                value: "Cotton");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 678.57m, "Cencerril Descifre Incorporal Incorruptibilidad Incorporación Abacalero.", new DateTime(2019, 2, 27, 22, 16, 44, 464, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/sprayaga/128.jpg", "Ergonómico Hormigón Pollo", 9, 469.43m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 629.49m, "Descerebrar Cendrado Bate Abajo Descercar Batallola General Incorporar.", new DateTime(2018, 11, 15, 2, 29, 36, 979, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/rpatey/128.jpg", "Elegante Soft Bike", 5, 680.46m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice" },
                values: new object[] { 669.27m, "Engaritar Cendrazo Incorruptible Engarro Bateaguas Engastar Cendra Fidedigno Incorporar Cencerra.", new DateTime(2018, 12, 14, 11, 27, 29, 876, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/victor_haydin/128.jpg", "Artesanal Frozen Pantalones", 2, 357.16m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 786.79m, "Engaritar Generalato Descerrar Cendrar Batatazo Batata Engastadura Descepar.", new DateTime(2019, 8, 23, 19, 45, 41, 108, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/jesseddy/128.jpg", "Inteligente Cotton Pizza", 5, 561.08m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "SellPrice", "UnitTypeId" },
                values: new object[] { 332.91m, "Ficha Cenceñada Fideísmo Descerrumarse Descentralizador Generación Abacero Engarbarse Bataola.", new DateTime(2019, 2, 5, 10, 29, 26, 64, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/logorado/128.jpg", "Rústico Frozen Zapatos", 1, 644.10m, 2 });

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 1,
                column: "Symbol",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 2,
                column: "Symbol",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 3,
                column: "Symbol",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "UnitTypeId",
                keyValue: 4,
                column: "Symbol",
                value: null);
        }
    }
}
