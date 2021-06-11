using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Review" },
                values: new object[,]
                {
                    { 1, "Saddle Mountain State Park Rd, Seaside, OR, 97138", "Saddle Mountain", "This park is open year round, but is only open for day use at the moment. Make sure to bring your own water and hand sanitizer, if need be. The hike can be difficult, but I will say the view is worth the work put in! You can see the ocean horizon at the very top!" },
                    { 2, "East Historic Columbia River, Bridal Veil, OR, 97010", "Angel's Rest Trailhead", "This hike can be pretty intensive, but totally worth the view, at least from the photos I've seen. Make sure you're endurance is up for this hike, or you might have to turn back like me." },
                    { 3, "20024 Silver Falls Hwy SE, Sublimity, OR, 97385", "Silver Falls", "Some trails have been closed due to the recent wildfires, but there are still some trails open at the moment. The many falls around are quite beautiful and refreshing. Some of the trails are quite narrow, so if you don't feel comfortable around many others, wear a mask and go during a time it's not so busy." },
                    { 4, "Wallowa Lake State Park, Joseph, OR, 97846", "Wallowa Lake", "Lots of camping and activities around and the lake is gorgeous! It is located in Easter Oregon, but worth the drive! The mountains surrounding the lake are breathtaking too." },
                    { 5, "Crater Lake National Park, Rim Dr, OR, 97604", "Crater Lake", "This is a must see Park! The water is so blue and beautiful! There are little critters everywhere too. Make sure you check the weather conditions before you go, the north entrance might be snowed in if it's too cold. Overall, lovely place!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
