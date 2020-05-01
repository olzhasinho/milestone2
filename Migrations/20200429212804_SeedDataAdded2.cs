using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class SeedDataAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "/images/4.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "/images/4.jpg");
        }
    }
}
