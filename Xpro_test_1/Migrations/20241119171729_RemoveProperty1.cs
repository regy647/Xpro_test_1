using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xpro_test_1.Migrations
{
    public partial class RemoveProperty1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "WorkLogs",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_ApplicationUserId",
                table: "WorkLogs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_AspNetUsers_ApplicationUserId",
                table: "WorkLogs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_AspNetUsers_ApplicationUserId",
                table: "WorkLogs");

            migrationBuilder.DropIndex(
                name: "IX_WorkLogs_ApplicationUserId",
                table: "WorkLogs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "WorkLogs");

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
    }
}
