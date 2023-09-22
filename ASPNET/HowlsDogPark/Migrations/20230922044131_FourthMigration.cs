using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HowlsDogPark.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Boardings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Boardings_UserId",
                table: "Boardings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boardings_Users_UserId",
                table: "Boardings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boardings_Users_UserId",
                table: "Boardings");

            migrationBuilder.DropIndex(
                name: "IX_Boardings_UserId",
                table: "Boardings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Boardings");
        }
    }
}
