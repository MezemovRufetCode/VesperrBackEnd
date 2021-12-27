using Microsoft.EntityFrameworkCore.Migrations;

namespace HWusingDbInProject.Migrations
{
    public partial class ManyToManyRelationForBuying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    MeasureTime = table.Column<string>(nullable: true),
                    Feature1 = table.Column<string>(nullable: true),
                    Feature2 = table.Column<string>(nullable: true),
                    Feature3 = table.Column<string>(nullable: true),
                    Feature4 = table.Column<string>(nullable: true),
                    Feature5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardFeaturesBuyCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardFeaturesId = table.Column<int>(nullable: false),
                    CardFeatureId = table.Column<int>(nullable: true),
                    BuyCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFeaturesBuyCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardFeaturesBuyCards_BuyCards_BuyCardId",
                        column: x => x.BuyCardId,
                        principalTable: "BuyCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardFeaturesBuyCards_CardFeatures_CardFeatureId",
                        column: x => x.CardFeatureId,
                        principalTable: "CardFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardFeaturesBuyCards_BuyCardId",
                table: "CardFeaturesBuyCards",
                column: "BuyCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardFeaturesBuyCards_CardFeatureId",
                table: "CardFeaturesBuyCards",
                column: "CardFeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardFeaturesBuyCards");

            migrationBuilder.DropTable(
                name: "BuyCards");

            migrationBuilder.DropTable(
                name: "CardFeatures");
        }
    }
}
