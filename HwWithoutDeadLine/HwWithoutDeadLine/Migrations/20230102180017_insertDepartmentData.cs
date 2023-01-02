using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwWithoutDeadLine.Migrations
{
    public partial class insertDepartmentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "ID", "Title" },
                values: new object[] { new Guid("1c056f18-2284-4664-984d-384d49f1cc2d"), "Emotional support" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "ID", "Title" },
                values: new object[] { new Guid("808e75a3-e715-4861-b9d3-407db73674bd"), "Emergency support" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "ID", "Title" },
                values: new object[] { new Guid("7292adfd-f499-487c-9e7d-43e9c1778cb9"), "User support" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "ID",
                keyValue: new Guid("1c056f18-2284-4664-984d-384d49f1cc2d"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "ID",
                keyValue: new Guid("7292adfd-f499-487c-9e7d-43e9c1778cb9"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "ID",
                keyValue: new Guid("808e75a3-e715-4861-b9d3-407db73674bd"));
        }
    }
}
