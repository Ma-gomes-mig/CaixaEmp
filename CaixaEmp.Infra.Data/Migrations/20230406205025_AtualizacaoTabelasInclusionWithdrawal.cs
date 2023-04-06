using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaixaEmp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelasInclusionWithdrawal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Months_MonthId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_MonthId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "MonthId",
                table: "Withdrawals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonthId",
                table: "Inclusions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Withdrawals_MonthId",
                table: "Withdrawals",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Inclusions_MonthId",
                table: "Inclusions",
                column: "MonthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inclusions_Months_MonthId",
                table: "Inclusions",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Withdrawals_Months_MonthId",
                table: "Withdrawals",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inclusions_Months_MonthId",
                table: "Inclusions");

            migrationBuilder.DropForeignKey(
                name: "FK_Withdrawals_Months_MonthId",
                table: "Withdrawals");

            migrationBuilder.DropIndex(
                name: "IX_Withdrawals_MonthId",
                table: "Withdrawals");

            migrationBuilder.DropIndex(
                name: "IX_Inclusions_MonthId",
                table: "Inclusions");

            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "Withdrawals");

            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "Inclusions");

            migrationBuilder.AddColumn<int>(
                name: "MonthId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_MonthId",
                table: "Expenses",
                column: "MonthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Months_MonthId",
                table: "Expenses",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
