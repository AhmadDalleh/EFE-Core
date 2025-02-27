using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFE_Core.Migrations
{
    /// <inheritdoc />
    public partial class EditStocksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Money",
                table: "Stocks",
                newName: "Balance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Stocks",
                newName: "Money");
        }
    }
}
