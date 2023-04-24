using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehearsalLibrary.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupEntries_Clients_ClientId",
                table: "GroupEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualEntries_Clients_ClientId",
                table: "IndividualEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_VocalEntries_Clients_ClientId",
                table: "VocalEntries");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "VocalEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "IndividualEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "GroupEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MessageOwnerId",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudioUserType",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MessageOwnerId",
                table: "Comments",
                column: "MessageOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_MessageOwnerId",
                table: "Comments",
                column: "MessageOwnerId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupEntries_Clients_ClientId",
                table: "GroupEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualEntries_Clients_ClientId",
                table: "IndividualEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VocalEntries_Clients_ClientId",
                table: "VocalEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_MessageOwnerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupEntries_Clients_ClientId",
                table: "GroupEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualEntries_Clients_ClientId",
                table: "IndividualEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_VocalEntries_Clients_ClientId",
                table: "VocalEntries");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MessageOwnerId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "VocalEntries");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "IndividualEntries");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "GroupEntries");

            migrationBuilder.DropColumn(
                name: "MessageOwnerId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "StudioUserType",
                table: "Clients");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Clients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupEntries_Clients_ClientId",
                table: "GroupEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualEntries_Clients_ClientId",
                table: "IndividualEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VocalEntries_Clients_ClientId",
                table: "VocalEntries",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
