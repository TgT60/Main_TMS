using Microsoft.EntityFrameworkCore.Migrations;

namespace HwWithoutDeadLine.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "SupportRequest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "SupportRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
