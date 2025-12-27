
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corvus.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Members",
                newName: "level");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Installments",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "terminolog3",
                table: "Configurations",
                newName: "terminologi3");

            migrationBuilder.RenameColumn(
                name: "updateOn",
                table: "Balances",
                newName: "UpdateOn");

            migrationBuilder.RenameColumn(
                name: "transactionName",
                table: "Balances",
                newName: "TransactionName");

            migrationBuilder.RenameColumn(
                name: "flow",
                table: "Balances",
                newName: "Flow");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Balances",
                newName: "Amount");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Inhouses",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.CreateTable(
                name: "BalanceHistories",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceHistories");

            migrationBuilder.RenameColumn(
                name: "level",
                table: "Members",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Installments",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "terminologi3",
                table: "Configurations",
                newName: "terminolog3");

            migrationBuilder.RenameColumn(
                name: "UpdateOn",
                table: "Balances",
                newName: "updateOn");

            migrationBuilder.RenameColumn(
                name: "TransactionName",
                table: "Balances",
                newName: "transactionName");

            migrationBuilder.RenameColumn(
                name: "Flow",
                table: "Balances",
                newName: "flow");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Balances",
                newName: "amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "Remarks",
                table: "Inhouses",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
