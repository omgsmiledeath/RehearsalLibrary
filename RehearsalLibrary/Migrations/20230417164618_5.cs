using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehearsalLibrary.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudioClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Client_StudioClientId",
                        column: x => x.StudioClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RehearsalHourCount = table.Column<int>(type: "int", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryType = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AdditionMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupEntries_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RehearsalHourCount = table.Column<int>(type: "int", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryType = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AdditionMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualEntries_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocalEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RehearsalHourCount = table.Column<int>(type: "int", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryType = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AdditionMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocalEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VocalEntries_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StudioClientId",
                table: "Comment",
                column: "StudioClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupEntries_ClientId",
                table: "GroupEntries",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualEntries_ClientId",
                table: "IndividualEntries",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_VocalEntries_ClientId",
                table: "VocalEntries",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "GroupEntries");

            migrationBuilder.DropTable(
                name: "IndividualEntries");

            migrationBuilder.DropTable(
                name: "VocalEntries");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
