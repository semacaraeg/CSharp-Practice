using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Migrations
{
    public partial class CustomProperties2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age1",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Salary",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Age1",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
