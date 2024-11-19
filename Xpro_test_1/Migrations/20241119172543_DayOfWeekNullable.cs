using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xpro_test_1.Migrations
{
    public partial class DayOfWeekNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DayOfWeek",
                table: "WorkLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 25, 43, 373, DateTimeKind.Local).AddTicks(407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DayOfWeek",
                table: "WorkLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 18, 17, 28, 813, DateTimeKind.Local).AddTicks(7769));
        }
    }
}
