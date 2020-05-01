using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Dead Inside Theme", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Naruto Frames", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Manga Frames", null });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "ArtId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsArtOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Deep inside Photo", "/images/2.jpg", "/images/1.jpg", true, true, "Kaneki Ken", 2000m },
                    { 2, 1, "Deep inside Photo2", "/images/4.jpg", "/images/3.jpg", true, false, "Kaneki Ken2", 2000m },
                    { 3, 1, "Deep inside Photo3", "/images/6.jpg", "/images/5.jpg", false, true, "Kaneki Ken3", 2000m },
                    { 4, 1, "Deep inside Photo", "/images/8.jpg", "/images/7.jpg", false, false, "Kaneki Ken4", 2000m },
                    { 5, 2, "Deep inside Photo", "/images/naruto2.jpg", "/images/naruto1.jpg", false, true, "Naruto", 2000m },
                    { 6, 2, "Deep inside Photo", "/images/naruto4.jpg", "/images/naruto3.jpg", true, false, "Naruto2", 2000m },
                    { 7, 3, "Deep inside Photo", "/images/kill2.jpg", "/images/kill1.jpg", true, true, "Killing Stalking", 2000m },
                    { 8, 3, "Deep inside Photo4", "/images/kill4.jpg", "/images/kill3.jpg", false, false, "Killing Stalking2", 2000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
