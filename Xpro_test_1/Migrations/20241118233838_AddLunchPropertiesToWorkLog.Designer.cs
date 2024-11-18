﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Xpro_test_1.Areas.Identity.Data;

#nullable disable

namespace Xpro_test_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241118233838_AddLunchPropertiesToWorkLog")]
    partial class AddLunchPropertiesToWorkLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Xpro_test_1.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmploymentComment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmploymentType")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Xpro_test_1.Models.Absence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Absences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Dopust"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Bolniška"
                        });
                });

            modelBuilder.Entity("Xpro_test_1.Models.WorkLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AbsenceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("EndOfLunch")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("EndOfWorkday")
                        .HasColumnType("time");

                    b.Property<decimal?>("LunchDuration")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OverExtensionLunch")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan?>("StartOfLunch")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("StartOfWorkday")
                        .HasColumnType("time");

                    b.Property<decimal?>("SumOfWorkedHours")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AbsenceId");

                    b.HasIndex("UserId");

                    b.ToTable("WorkLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4252),
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Sunday",
                            DayStatus = "Weekend",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4258),
                            Date = new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Tuesday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 11, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 11, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 9m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4262),
                            Date = new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Thursday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 30, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 30, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4267),
                            Date = new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Friday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 5,
                            AbsenceId = 1,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4271),
                            Date = new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Sunday",
                            DayStatus = "Weekend",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4275),
                            Date = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Wednesday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 30, 0, 0),
                            SumOfWorkedHours = 8.5m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4279),
                            Date = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Friday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4317),
                            Date = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Thursday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 7m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4322),
                            Date = new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Saturday",
                            DayStatus = "Weekend",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 10,
                            AbsenceId = 2,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4327),
                            Date = new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Monday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4332),
                            Date = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Friday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4336),
                            Date = new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Sunday",
                            DayStatus = "Weekend",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4341),
                            Date = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Thursday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 30, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 30, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4346),
                            Date = new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Sunday",
                            DayStatus = "Weekend",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 16, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 8, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        },
                        new
                        {
                            Id = 15,
                            AbsenceId = 2,
                            CreatedAt = new DateTime(2024, 11, 19, 0, 38, 38, 372, DateTimeKind.Local).AddTicks(4352),
                            Date = new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DayOfWeek = "Friday",
                            DayStatus = "Workday",
                            EndOfLunch = new TimeSpan(0, 12, 30, 0, 0),
                            EndOfWorkday = new TimeSpan(0, 17, 0, 0, 0),
                            LunchDuration = 0.5m,
                            StartOfLunch = new TimeSpan(0, 12, 0, 0, 0),
                            StartOfWorkday = new TimeSpan(0, 9, 0, 0, 0),
                            SumOfWorkedHours = 8m,
                            UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Xpro_test_1.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Xpro_test_1.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Xpro_test_1.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Xpro_test_1.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Xpro_test_1.Models.WorkLog", b =>
                {
                    b.HasOne("Xpro_test_1.Models.Absence", "Absence")
                        .WithMany()
                        .HasForeignKey("AbsenceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Xpro_test_1.Areas.Identity.Data.ApplicationUser", "User")
                        .WithMany("WorkLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Absence");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Xpro_test_1.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Navigation("WorkLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
