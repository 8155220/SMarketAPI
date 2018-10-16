using Microsoft.EntityFrameworkCore.Migrations;

namespace SMarketAPI.Migrations
{
    public partial class ProductDetailNotemodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductNoteDetail");

            migrationBuilder.DropColumn(
                name: "NoteType",
                table: "ProductNoteDetail");

            migrationBuilder.DropColumn(
                name: "ReceivedBy",
                table: "ProductNoteDetail");

            migrationBuilder.DropColumn(
                name: "UnitType",
                table: "ProductNoteDetail");

            migrationBuilder.RenameColumn(
                name: "UnitCost",
                table: "ProductNoteDetail",
                newName: "Amount");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                column: "Name",
                value: "Ergonómico");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                column: "Description",
                value: "Plástico");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Acero", "Fantástico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Granito", "Refinado" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 5,
                column: "Description",
                value: "Plástico");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Madera", "Increíble" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Metal", "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 8,
                column: "Name",
                value: "Increíble");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Frozen", "Ergonómico" });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Caucho", "Hecho a mano" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ProductNoteDetail",
                newName: "UnitCost");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductNoteDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoteType",
                table: "ProductNoteDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceivedBy",
                table: "ProductNoteDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitType",
                table: "ProductNoteDetail",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 1,
                column: "Name",
                value: "Refinado");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ProductTypeId",
                keyValue: 2,
                column: "Description",
                value: "Granito");

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
                column: "Description",
                value: "Soft");

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
                column: "Name",
                value: "Sabrosa");

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
    }
}
