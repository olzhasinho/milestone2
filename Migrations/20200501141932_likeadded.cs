using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class likeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtLike",
                table: "Arts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtLike",
                table: "Arts");
        }
    }
}
