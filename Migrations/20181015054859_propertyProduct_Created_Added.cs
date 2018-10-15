using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class propertyProduct_Created_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Artesanal" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                column: "Name",
                value: "Sin marca");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                column: "Description",
                value: "Madera");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                column: "Name",
                value: "Rústico");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Artesanal" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                column: "Name",
                value: "Fantástico");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                column: "Description",
                value: "Metal");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Frozen", "Sin marca" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Hecho a mano" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                column: "Name",
                value: "Inteligente");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                column: "Description",
                value: "Granito");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                column: "Name",
                value: "Genérica");

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
                column: "Name",
                value: "Increíble");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                column: "Description",
                value: "Madera");

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
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hormigón", "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Increíble" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BuyPrice", "Description", "ExpirationDate", "Image", "Name", "ProductTypeId", "Provider", "SellPrice", "UnitTypeId" },
                values: new object[,]
                {
                    { 1, 331.22m, "Gencianáceo Desceñir Cencivera Cenceño Ficción Gemiqueo Abacial.", new DateTime(2018, 10, 16, 15, 57, 51, 289, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/giancarlon/128.jpg", "Licencia Frozen Pelota", 5, null, 696.82m, 4 },
                    { 2, 391.05m, "Descerrumarse Fichero Bastonero Abadejo Cencerrear Descifrable Gemonias Incrédulo Descenso.", new DateTime(2019, 6, 2, 11, 59, 2, 714, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/benefritz/128.jpg", "Rústico Madera Zapatos", 4, null, 345.08m, 3 },
                    { 3, 323.50m, "Bastonear Incorrupción Generable Abadengo Ceñar Fido Fideero Bastonada Incremento.", new DateTime(2019, 4, 22, 11, 14, 35, 526, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/kylefrost/128.jpg", "Artesanal Soft Pelota", 10, null, 1.30m, 1 },
                    { 4, 925.64m, "Descerebrado Engarrafar Engargantar Cencero Fideísmo Abada Abacora Descerebración Incorrupto Batallar.", new DateTime(2019, 8, 21, 21, 58, 37, 284, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/aio___/128.jpg", "Refinado Soft Pescado", 7, null, 923.80m, 1 },
                    { 5, 582.82m, "Descerrajado Genealogista Genealógico Batavia.", new DateTime(2019, 6, 3, 19, 46, 44, 316, DateTimeKind.Local), "https://s3.amazonaws.com/uifaces/faces/twitter/tur8le/128.jpg", "Pequeño Metal Bike", 8, null, 842.84m, 4 }
                });
        }
    }
}
