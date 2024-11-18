using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp32.Migrations
{
    /// <inheritdoc />
    public partial class aaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomersCount",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomCount",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomersCount",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "RoomCount",
                table: "Hotels");
        }
    }
}
