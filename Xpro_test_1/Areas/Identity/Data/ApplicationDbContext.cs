using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Xpro_test_1.Areas.Identity.Data;
using Xpro_test_1.Models;

namespace Xpro_test_1.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<WorkLog> WorkLogs { get; set; }
    public DbSet<Absence> Absences { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        // Configure WorkLog to User relationship
        builder.Entity<WorkLog>()
            .HasOne(w => w.User)
            .WithMany(u => u.WorkLogs)
            .HasForeignKey(w => w.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure WorkLog to Absence relationship, make AbsenceId nullable
        builder.Entity<WorkLog>()
            .HasOne(w => w.Absence)
            .WithMany()  // No navigation property in Absence for this relation
            .HasForeignKey(w => w.AbsenceId)
            .OnDelete(DeleteBehavior.SetNull);

        // Set precision and scale for decimal properties
        builder.Entity<WorkLog>()
            .Property(w => w.LunchDuration)
            .HasPrecision(18, 2);

        builder.Entity<WorkLog>()
            .Property(w => w.OverExtensionLunch)
            .HasPrecision(18, 2);

        builder.Entity<WorkLog>()
            .Property(w => w.SumOfWorkedHours)
            .HasPrecision(18, 2);

        // Seed Absences data
        builder.Entity<Absence>().HasData(
            new Absence { Id = 1, Type = "Dopust" },
            new Absence { Id = 2, Type = "Bolniška" }
        );

        builder.Entity<WorkLog>().HasData(
            new WorkLog { Id = 1, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 9, 1), DayOfWeek = "Sunday", DayStatus = "Weekend", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 2, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 9, 3), DayOfWeek = "Tuesday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 9, StartOfLunch = new TimeSpan(11, 0, 0), EndOfLunch = new TimeSpan(11, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 3, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 9, 5), DayOfWeek = "Thursday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(8, 30, 0), EndOfWorkday = new TimeSpan(16, 30, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 4, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 9, 6), DayOfWeek = "Friday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 5, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 9, 8), DayOfWeek = "Sunday", DayStatus = "Weekend", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = 1, CreatedAt = DateTime.Now },
            new WorkLog { Id = 6, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 10, 2), DayOfWeek = "Wednesday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(8, 30, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8.5M, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 7, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 10, 4), DayOfWeek = "Friday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 8, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 10, 10), DayOfWeek = "Thursday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 7, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 9, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 10, 12), DayOfWeek = "Saturday", DayStatus = "Weekend", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 10, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 10, 14), DayOfWeek = "Monday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = 2, CreatedAt = DateTime.Now },
            new WorkLog { Id = 11, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 11, 1), DayOfWeek = "Friday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 12, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 11, 3), DayOfWeek = "Sunday", DayStatus = "Weekend", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 13, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 11, 7), DayOfWeek = "Thursday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(8, 30, 0), EndOfWorkday = new TimeSpan(16, 30, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 14, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 11, 10), DayOfWeek = "Sunday", DayStatus = "Weekend", StartOfWorkday = new TimeSpan(8, 0, 0), EndOfWorkday = new TimeSpan(16, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = null, CreatedAt = DateTime.Now },
            new WorkLog { Id = 15, UserId = "aa46bd12-6e15-448f-8b6d-943b41bef02b", Date = new DateTime(2024, 11, 15), DayOfWeek = "Friday", DayStatus = "Workday", StartOfWorkday = new TimeSpan(9, 0, 0), EndOfWorkday = new TimeSpan(17, 0, 0), SumOfWorkedHours = 8, StartOfLunch = new TimeSpan(12, 0, 0), EndOfLunch = new TimeSpan(12, 30, 0), LunchDuration = 0.5M, OverExtensionLunch = null, AbsenceId = 2, CreatedAt = DateTime.Now }
           
        );
    }


    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(30);

            builder.Property(u => u.Email).IsRequired().HasMaxLength(255);

            builder.Property(u => u.Name).IsRequired().HasMaxLength(30);

            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(15);

            builder.Property(u => u.Position).IsRequired().HasMaxLength(30);

            builder.Property(u => u.EmploymentType).IsRequired();

            builder.Property(u => u.EmploymentComment).IsRequired(false).HasMaxLength(100);

            builder.Property(u => u.IsActive).IsRequired();

        }
    }
}


