using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwWithoutDeadLine.Migrations
{
    public partial class FerstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupporSpecialist",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    DepartmentID = table.Column<Guid>(nullable: true),
                    StatusSpecialist = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupporSpecialist", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupporSpecialist_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupportRequest",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    SpecialistStatusID = table.Column<Guid>(nullable: true),
                    SpecialistID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupportRequest_SupporSpecialist_SpecialistID",
                        column: x => x.SpecialistID,
                        principalTable: "SupporSpecialist",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportRequest_SupporSpecialist_SpecialistStatusID",
                        column: x => x.SpecialistStatusID,
                        principalTable: "SupporSpecialist",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupporSpecialist_DepartmentID",
                table: "SupporSpecialist",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequest_SpecialistID",
                table: "SupportRequest",
                column: "SpecialistID");

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequest_SpecialistStatusID",
                table: "SupportRequest",
                column: "SpecialistStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportRequest");

            migrationBuilder.DropTable(
                name: "SupporSpecialist");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
