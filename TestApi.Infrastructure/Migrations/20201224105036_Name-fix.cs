using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApi.Infrastructure.Migrations
{
    public partial class Namefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAd",
                table: "ToDos",
                newName: "CreatedAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ToDos",
                newName: "CreatedAd");
        }
    }
}
