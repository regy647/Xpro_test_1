using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xpro_test_1.Migrations
{
    public partial class AddWorkLogsAndAbsencesV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DayStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartOfWorkday = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndOfWorkday = table.Column<TimeSpan>(type: "time", nullable: true),
                    SumOfWorkedHours = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    StartOfLunch = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndOfLunch = table.Column<TimeSpan>(type: "time", nullable: true),
                    LunchDuration = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    OverExtensionLunch = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    AbsenceId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkLogs_Absences_AbsenceId",
                        column: x => x.AbsenceId,
                        principalTable: "Absences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_WorkLogs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Dopust" });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Bolniška" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_AbsenceId",
                table: "WorkLogs",
                column: "AbsenceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_UserId",
                table: "WorkLogs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkLogs");

            migrationBuilder.DropTable(
                name: "Absences");
        }
    }
}
