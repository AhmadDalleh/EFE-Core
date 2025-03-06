using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFE_Core.Migrations
{
    /// <inheritdoc />
    public partial class EditBlogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddeOn",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddeOn",
                table: "Blogs");
        }
    }
}
