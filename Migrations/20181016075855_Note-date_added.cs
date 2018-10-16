using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class Notedate_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Note",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Refinado" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Ergonómico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Elegante" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Práctica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                column: "Name",
                value: "Licencia");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Sabrosa" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Cotton", "Refinado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Note");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Genérica" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Pequeño" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Elegante" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                column: "Name",
                value: "Pequeño");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fresco", "Hecho a mano" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Plástico", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Refinado" });

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
        }
    }
}
