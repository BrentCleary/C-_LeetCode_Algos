using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HowlsDogPark.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "Boardings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Boardings_DogId",
                table: "Boardings",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boardings_Dogs_DogId",
                table: "Boardings",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "DogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boardings_Dogs_DogId",
                table: "Boardings");

            migrationBuilder.DropIndex(
                name: "IX_Boardings_DogId",
                table: "Boardings");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "Boardings");
        }
    }
}
