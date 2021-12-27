using Microsoft.EntityFrameworkCore.Migrations;

namespace HWusingDbInProject.Migrations
{
    public partial class HeroChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Button",
                table: "Heroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Button",
                table: "Heroes");
        }
    }
}
