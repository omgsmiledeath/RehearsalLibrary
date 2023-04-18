using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehearsalLibrary.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    StudioClientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Clients_StudioClientId",
                        column: x => x.StudioClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RehearsalHourCount = table.Column<int>(type: "INTEGER", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryType = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdditionMessage = table.Column<string>(type: "TEXT", nullable: false),
                    EntryStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupEntries_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RehearsalHourCount = table.Column<int>(type: "INTEGER", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryType = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdditionMessage = table.Column<string>(type: "TEXT", nullable: false),
                    EntryStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualEntries_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocalEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RehearsalHourCount = table.Column<int>(type: "INTEGER", nullable: false),
                    EntryStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EntryType = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdditionMessage = table.Column<string>(type: "TEXT", nullable: false),
                    EntryStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocalEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VocalEntries_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
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
                name: "Clients");
        }
    }
}
