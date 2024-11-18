using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xpro_test_1.Migrations
{
    public partial class SeedWorkLogData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkLogs",
                columns: new[] { "Id", "AbsenceId", "CreatedAt", "Date", "DayOfWeek", "DayStatus", "EndOfLunch", "EndOfWorkday", "LunchDuration", "OverExtensionLunch", "StartOfLunch", "StartOfWorkday", "SumOfWorkedHours", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 2, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 9m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 3, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 4, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 5, 1, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 6, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3416), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8.5m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 7, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 8, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 7m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 9, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 10, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 11, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3437), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 12, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 13, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 14, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 15, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "aa46bd12-6e15-448f-8b6d-943b41bef02b" },
                    { 16, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 17, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 9m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 18, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3499), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 19, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 20, 1, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 21, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3512), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8.5m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 22, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 23, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 7m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 24, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 25, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3526), new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 26, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 27, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 28, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 29, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 30, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "39e9c620-5615-48ec-be74-422eedd30964" },
                    { 31, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 32, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 9m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 33, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 34, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 35, 1, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 36, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8.5m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 37, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3570), new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 38, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 7m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 39, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3577), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 40, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 41, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" },
                    { 42, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" }
                });

            migrationBuilder.InsertData(
                table: "WorkLogs",
                columns: new[] { "Id", "AbsenceId", "CreatedAt", "Date", "DayOfWeek", "DayStatus", "EndOfLunch", "EndOfWorkday", "LunchDuration", "OverExtensionLunch", "StartOfLunch", "StartOfWorkday", "SumOfWorkedHours", "UserId" },
                values: new object[] { 43, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", "Workday", null, new TimeSpan(0, 16, 30, 0, 0), null, null, null, new TimeSpan(0, 8, 30, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" });

            migrationBuilder.InsertData(
                table: "WorkLogs",
                columns: new[] { "Id", "AbsenceId", "CreatedAt", "Date", "DayOfWeek", "DayStatus", "EndOfLunch", "EndOfWorkday", "LunchDuration", "OverExtensionLunch", "StartOfLunch", "StartOfWorkday", "SumOfWorkedHours", "UserId" },
                values: new object[] { 44, null, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", "Weekend", null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, new TimeSpan(0, 8, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" });

            migrationBuilder.InsertData(
                table: "WorkLogs",
                columns: new[] { "Id", "AbsenceId", "CreatedAt", "Date", "DayOfWeek", "DayStatus", "EndOfLunch", "EndOfWorkday", "LunchDuration", "OverExtensionLunch", "StartOfLunch", "StartOfWorkday", "SumOfWorkedHours", "UserId" },
                values: new object[] { 45, 2, new DateTime(2024, 11, 19, 0, 21, 0, 314, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", "Workday", null, new TimeSpan(0, 17, 0, 0, 0), null, null, null, new TimeSpan(0, 9, 0, 0, 0), 8m, "7e191d2f-5c46-4485-80bc-766ca548f934" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WorkLogs",
                keyColumn: "Id",
                keyValue: 45);
        }
    }
}
