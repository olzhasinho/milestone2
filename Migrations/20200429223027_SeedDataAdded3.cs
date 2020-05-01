using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class SeedDataAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/kill1.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/kill1.jpg");
        }
    }
}
