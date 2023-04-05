using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaixaEmp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelaMonth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonthId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Months_MonthId",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_MonthId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "Expenses");
        }
    }
}
