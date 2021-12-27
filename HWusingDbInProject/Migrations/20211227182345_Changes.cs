using Microsoft.EntityFrameworkCore.Migrations;

namespace HWusingDbInProject.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardFeaturesBuyCards_CardFeatures_CardFeatureId",
                table: "CardFeaturesBuyCards");

            migrationBuilder.DropColumn(
                name: "CardFeaturesId",
                table: "CardFeaturesBuyCards");

            migrationBuilder.AlterColumn<int>(
                name: "CardFeatureId",
                table: "CardFeaturesBuyCards",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassParameter",
                table: "CardFeatures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "CardFeatures",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CardFeaturesBuyCards_CardFeatures_CardFeatureId",
                table: "CardFeaturesBuyCards",
                column: "CardFeatureId",
                principalTable: "CardFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardFeaturesBuyCards_CardFeatures_CardFeatureId",
                table: "CardFeaturesBuyCards");

            migrationBuilder.DropColumn(
                name: "ClassParameter",
                table: "CardFeatures");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "CardFeatures");

            migrationBuilder.AlterColumn<int>(
                name: "CardFeatureId",
                table: "CardFeaturesBuyCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CardFeaturesId",
                table: "CardFeaturesBuyCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CardFeaturesBuyCards_CardFeatures_CardFeatureId",
                table: "CardFeaturesBuyCards",
                column: "CardFeatureId",
                principalTable: "CardFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
