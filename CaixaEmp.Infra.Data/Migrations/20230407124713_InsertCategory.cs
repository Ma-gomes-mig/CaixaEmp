using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaixaEmp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Todo material que seja para uso da higiene da area de trabalho como: Esponja, detergente, papel higiênico, etc...", "Insumos Higiene" },
                    { 2, "Todo material que seja para uso do escritório como:Fita adesiva, lápis, grampos, papel para impressão, etc...", "Insumos Papelaria" },
                    { 3, "Todo material que seja para uso dos colaboradores como: Biscoito, agua, etc", "Insumos Alimentares" },
                    { 4, "Todo material que seja para uso dos colaboradores como: Remedio, band-aid", "Insumos Saude" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
