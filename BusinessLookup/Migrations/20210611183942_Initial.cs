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

            migrationBuilder.InsertData(
                table: "LocalBusinesses",
                columns: new[] { "LocalBusinessId", "BusinessName", "BusinessType", "RateReview", "Review" },
                values: new object[,]
                {
                    { 1, "Pok Pok", "Restaurant", 4, "I love this restautant. It is SE Asian inspired and the food is sooo delicious. The only downside is you do have to wait a long time" },
                    { 2, "Loving Hut", "Restaurant", 5, "Even though i'm not vegan, the food here is absolutely delicious. I've eaten here numerous times and everything I've tryied is mouthwatering" },
                    { 3, "Chowder Tavern", "Bar", 4, "Its a must. All their drinks are super different. I had the clammy blody mary and it was one of the best I've had" },
                    { 4, "Happy Orchid", "Flowe Shop", 5, "They have a wide veriety of flowers and they also offer classes with a pretty awesome instructor" },
                    { 5, "Crazy Hammer", "Hardware Shop", 3, "Its your regular well-stock hardware store. But their staff is limited and hard to get help." },
                    { 6, "Freemont", "Grocery Shop", 5, "Even though its a small neighborhood store, it is very well stocked, you can find just about anything" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalBusinesses");
        }
    }
}
