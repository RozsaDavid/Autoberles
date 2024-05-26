using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoberles.Migrations {
    /// <inheritdoc />
    public partial class auto03 :Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "ResEnd",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ResStart",
                table: "Car");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Car",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Car",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Car");

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

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Car");
        }
    }
}
