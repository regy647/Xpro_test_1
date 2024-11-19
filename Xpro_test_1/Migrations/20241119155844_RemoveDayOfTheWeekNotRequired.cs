using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xpro_test_1.Migrations
{
    public partial class RemoveDayOfTheWeekNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 16, 58, 43, 945, DateTimeKind.Local).AddTicks(2283));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4352));
        }
    }
}
