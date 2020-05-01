using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class addFavor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "IsFavorite",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "IsFavorite",
                value: false);
        }
    }
}
