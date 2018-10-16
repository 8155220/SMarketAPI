using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class notefixedatribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
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
                columns: new[] { "Description", "Name" },
                values: new object[] { "Soft", "Pequeño" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Note",
                nullable: true);

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
        }
    }
}
