using Microsoft.EntityFrameworkCore.Migrations;

namespace MopShop.Migrations
{
    public partial class MopShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CleaningPurpose = table.Column<string>(nullable: true),
                    TypeOfSurface = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CustomerRating = table.Column<int>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mops", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mops");
        }
    }
}
