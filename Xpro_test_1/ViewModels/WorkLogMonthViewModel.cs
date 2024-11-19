using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Xpro_test_1.Models;
using Xpro_test_1.Controllers;
using Xpro_test_1.Areas;

namespace Xpro_test_1.ViewModels
{
    public class WorkLogMonthViewModel
    {
        public string UserId { get; set; }  
        public int Year { get; set; }  
        public int Month { get; set; }  
        public List<WorkLog> WorkLogs { get; set; }  

        public List<SelectListItem> MonthSelectList { get; set; }
        public List<SelectListItem> YearSelectList { get; set; }
    }

    public class WorkLogViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DayStatus { get; set; }
        public string StartOfWorkday { get; set; }
        public string EndOfWorkday { get; set; }
        public string StartOfLunch { get; set; }
        public string EndOfLunch { get; set; }
        public string LunchDuration { get; set; }
        public string OverExtensionLunch { get; set; }
        public string AbsenceType { get; set; } // Add this
        public string SumOfWorkedHours { get; set; }
    }
}