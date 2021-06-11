using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalBusinesses",
                columns: table => new
                {
                    LocalBusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BusinessType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    BusinessName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Review = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    RateReview = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalBusinesses", x => x.LocalBusinessId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalBusinesses");
        }
    }
}
