using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoberles.Migrations
{
    /// <inheritdoc />
    public partial class auto02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ResEnd",
                table: "Car",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ResStart",
                table: "Car",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResEnd",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ResStart",
                table: "Car");
        }
    }
}
