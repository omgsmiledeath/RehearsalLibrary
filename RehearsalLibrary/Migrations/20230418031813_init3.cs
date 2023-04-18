using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehearsalLibrary.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CymbalsRent",
                table: "IndividualEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CymbalsRent",
                table: "GroupEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CymbalsRent",
                table: "IndividualEntries");

            migrationBuilder.DropColumn(
                name: "CymbalsRent",
                table: "GroupEntries");
        }
    }
}
