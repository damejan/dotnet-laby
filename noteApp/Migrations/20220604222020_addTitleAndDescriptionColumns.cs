using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace noteApp.Migrations
{
    public partial class addTitleAndDescriptionColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Notes");
        }
    }
}
