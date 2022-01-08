using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Denominacion" },
                values: new object[] { 23, "jejejeej" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Denominacion" },
                values: new object[] { 20, "jejejeej" });
        }
    }
}
