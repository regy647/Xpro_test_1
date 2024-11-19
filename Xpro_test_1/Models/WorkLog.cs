using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xpro_test_1.Areas.Identity.Data;

namespace Xpro_test_1.Models
{
    public class WorkLog
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } 
        //public ApplicationUser User { get; set; } 

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string? DayOfWeek { get; set; }

        [Required]
        public string DayStatus { get; set; } 

        [DataType(DataType.Time)]
        public TimeSpan? StartOfWorkday { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? EndOfWorkday { get; set; }

        public decimal? SumOfWorkedHours { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? StartOfLunch { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? EndOfLunch { get; set; }

        public decimal? LunchDuration { get; set; }
        public decimal? OverExtensionLunch { get; set; }

        public int? AbsenceId { get; set; } 
        public Absence? Absence { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
