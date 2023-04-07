using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaixaEmp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelaExpense2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Emplooyers_EmplooyerId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_EmplooyerId",
                table: "Expenses");

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

            migrationBuilder.DropColumn(
                name: "EmplooyerId",
                table: "Expenses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmplooyerId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmplooyerId",
                table: "Expenses",
                column: "EmplooyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Emplooyers_EmplooyerId",
                table: "Expenses",
                column: "EmplooyerId",
                principalTable: "Emplooyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
