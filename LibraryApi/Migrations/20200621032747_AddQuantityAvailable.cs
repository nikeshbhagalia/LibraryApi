using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApi.Migrations
{
    public partial class AddQuantityAvailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "Books");
        }
    }
}
