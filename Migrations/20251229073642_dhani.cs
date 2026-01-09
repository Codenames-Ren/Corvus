using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corvus.Migrations
{
    /// <inheritdoc />
    public partial class dhani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                ALTER TABLE "Inhouses"
                ALTER COLUMN "Remarks" TYPE numeric
                USING NULLIF("Remarks",'')::numeric;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Inhouses",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }
    }
}
