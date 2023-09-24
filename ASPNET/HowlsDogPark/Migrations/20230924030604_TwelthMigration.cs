using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HowlsDogPark.Migrations
{
    public partial class TwelthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoRenewal",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Memberships");

            migrationBuilder.RenameColumn(
                name: "MemberType",
                table: "Memberships",
                newName: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Memberships",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MembershipType",
                table: "Memberships",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Memberships",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "MembershipType",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Memberships");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Memberships",
                newName: "MemberType");

            migrationBuilder.AddColumn<bool>(
                name: "AutoRenewal",
                table: "Memberships",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Memberships",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
