using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwWithoutDeadLine.Migrations
{
    public partial class CreateOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupporSpecialist_Department_DepartmentID",
                table: "SupporSpecialist");

            migrationBuilder.DropIndex(
                name: "IX_SupporSpecialist_DepartmentID",
                table: "SupporSpecialist");

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

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "SupporSpecialist");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SupportRequest",
                newName: "SupportRequestID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SupporSpecialist",
                newName: "SupporSpecialistID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "DepartmentID");

            migrationBuilder.AddColumn<Guid>(
                name: "SupporSpecialistID",
                table: "Department",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_SupporSpecialistID",
                table: "Department",
                column: "SupporSpecialistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_SupporSpecialist_SupporSpecialistID",
                table: "Department",
                column: "SupporSpecialistID",
                principalTable: "SupporSpecialist",
                principalColumn: "SupporSpecialistID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_SupporSpecialist_SupporSpecialistID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_SupporSpecialistID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "SupporSpecialistID",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "SupportRequestID",
                table: "SupportRequest",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SupporSpecialistID",
                table: "SupporSpecialist",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Department",
                newName: "ID");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentID",
                table: "SupporSpecialist",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_SupporSpecialist_DepartmentID",
                table: "SupporSpecialist",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupporSpecialist_Department_DepartmentID",
                table: "SupporSpecialist",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
