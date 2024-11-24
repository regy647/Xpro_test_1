using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using Xpro_test_1.Areas.Identity.Data;
using Xpro_test_1.Models;
using Xpro_test_1.ViewModels;
using OfficeOpenXml;

[Authorize]
public class WorkLogController : Controller
{
    private readonly ApplicationDbContext _context;

    public WorkLogController(ApplicationDbContext context)
    {
        _context = context;
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }

    //[HttpGet("WorkLog/CreateWithDate")]
    public IActionResult Create(string date)
    {

        var workDate = DateTime.Parse(date);
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
        var workLog = new WorkLog
        {
            Date = workDate,
            UserId = userId 
        };

        ViewBag.AbsenceList = _context.Absences
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Type.ToString(),
                }).ToList();

        return View(new WorkLog { Date = workDate });
    }

    public IActionResult Index(int? year, int? month)
    {
        var currentDate = DateTime.Now;

        int selectedYear = year ?? currentDate.Year;
        int selectedMonth = month ?? currentDate.Month;

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var workLogs = _context.WorkLogs
            .Where(w => w.UserId == userId && w.Date.Year == selectedYear && w.Date.Month == selectedMonth)
            .OrderBy(w => w.Date)
            .Include(w => w.Absence) 
            .ToList();

        var model = new WorkLogMonthViewModel
        {
            UserId = userId,
            Year = selectedYear,
            Month = selectedMonth,
            WorkLogs = workLogs, 
            MonthSelectList = GetMonths(),
            YearSelectList = GetYears()
        };

        return View(model);
    }

    //[HttpGet("WorkLog/CreateNoArgument")]
    //public IActionResult Create()
    //{
    //    return View();
    //}

    private List<SelectListItem> GetMonths()
    {
        return Enumerable.Range(1, 12)
            .Select(m => new SelectListItem
            {
                Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m),
                Value = m.ToString()
            })
            .ToList();
    }


    private List<SelectListItem> GetYears()
    {
        var currentYear = DateTime.Now.Year;
        return Enumerable.Range(currentYear - 5, 11) 
            .Select(year => new SelectListItem
            {
                Text = year.ToString(),
                Value = year.ToString()
            })
            .ToList();
    }

    public IActionResult Edit(int id)
    {
        var workLog = _context.WorkLogs.FirstOrDefault(w => w.Id == id);
        if (workLog == null) return NotFound();

        ViewBag.AbsenceList = _context.Absences
            .Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Type.ToString()
            }).ToList();

        return View(workLog);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(WorkLog workLog)
    {
        if (!ModelState.IsValid)
        {
            // Log the ModelState errors for debugging
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                }
            }

            ViewBag.AbsenceList = _context.Absences
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Type.ToString(),
                }).ToList();

            return View(workLog); 
        }

        var existingWorkLog = _context.WorkLogs.FirstOrDefault(w => w.Id == workLog.Id);
        if (existingWorkLog != null)
        {
            existingWorkLog.UserId = existingWorkLog.UserId ?? User.FindFirstValue(ClaimTypes.NameIdentifier);
            existingWorkLog.Date = workLog.Date;
            existingWorkLog.DayOfWeek = workLog.Date.DayOfWeek.ToString();
            existingWorkLog.DayStatus = workLog.DayStatus.ToString();
            existingWorkLog.StartOfWorkday = workLog.StartOfWorkday;
            existingWorkLog.EndOfWorkday = workLog.EndOfWorkday;
            existingWorkLog.StartOfLunch = workLog.StartOfLunch;
            existingWorkLog.EndOfLunch = workLog.EndOfLunch;
            existingWorkLog.AbsenceId = workLog.AbsenceId;

            var lunchDuration = (workLog.EndOfLunch - workLog.StartOfLunch)?.TotalMinutes ?? 0;
            var standardLunchDuration = 30;
            existingWorkLog.LunchDuration = (decimal?)lunchDuration;
            existingWorkLog.OverExtensionLunch = lunchDuration > standardLunchDuration ? (decimal?)(lunchDuration - standardLunchDuration) : 0;

            var workedHours = (workLog.EndOfWorkday - workLog.StartOfWorkday)?.TotalHours ?? 0;
            existingWorkLog.SumOfWorkedHours = (decimal?)(workedHours);

            _context.SaveChanges();

            return RedirectToAction("Index", new { year = workLog.Date.Year, month = workLog.Date.Month });
        }

        return View(workLog); 
    }

   

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(WorkLog workLog)
    {

        if (!ModelState.IsValid)
        {

            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                }
            }

            ViewBag.AbsenceList = _context.Absences
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Type.ToString(),
                }).ToList();

            return View(workLog); 
        }

        workLog.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
        workLog.DayOfWeek = workLog.Date.DayOfWeek.ToString();
        workLog.DayStatus = workLog.DayStatus.ToString();

        var lunchDuration = (workLog.EndOfLunch - workLog.StartOfLunch)?.TotalMinutes ?? 0;
        var standardLunchDuration = 30;
        workLog.LunchDuration = (decimal?)lunchDuration;
        workLog.OverExtensionLunch = lunchDuration > standardLunchDuration ? (decimal?)(lunchDuration - standardLunchDuration) : 0;

        var workedHours = (workLog.EndOfWorkday - workLog.StartOfWorkday)?.TotalHours ?? 0;
        workLog.SumOfWorkedHours = (decimal?)workedHours;

        _context.WorkLogs.Add(workLog);
        _context.SaveChanges();

        return RedirectToAction("Index", "Home");
    }

    public IActionResult PreviousMonth(int year, int month)
    {
        var previousMonth = new DateTime(year, month, 1).AddMonths(-1);
        return RedirectToAction("Index", new { year = previousMonth.Year, month = previousMonth.Month });
    }

    public IActionResult NextMonth(int year, int month)
    {
        var nextMonth = new DateTime(year, month, 1).AddMonths(1);
        return RedirectToAction("Index", new { year = nextMonth.Year, month = nextMonth.Month });
    }

    public IActionResult ExportToExcel(int year, int month)
    {
        var workLogs = _context.WorkLogs
            .Where(w => w.Date.Year == year && w.Date.Month == month)
            .OrderBy(w => w.Date)
            .ToList();

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Work Logs");

            worksheet.Cells[1, 1].Value = "Date";
            worksheet.Cells[1, 2].Value = "Day";
            worksheet.Cells[1, 3].Value = "Day Status";
            worksheet.Cells[1, 4].Value = "Start Time";
            worksheet.Cells[1, 5].Value = "End Time";
            worksheet.Cells[1, 6].Value = "Lunch Start";
            worksheet.Cells[1, 7].Value = "Lunch End";
            worksheet.Cells[1, 8].Value = "Lunch Duration";
            worksheet.Cells[1, 9].Value = "Break Extension";
            worksheet.Cells[1, 10].Value = "Absence Type";
            worksheet.Cells[1, 11].Value = "Worked Hours";

            for (int i = 0; i < workLogs.Count; i++)
            {
                var log = workLogs[i];
                worksheet.Cells[i + 2, 1].Value = log.Date.ToString("yyyy-MM-dd");
                worksheet.Cells[i + 2, 2].Value = log.Date.ToString("dddd");
                worksheet.Cells[i + 2, 3].Value = log.DayStatus;
                worksheet.Cells[i + 2, 4].Value = log.StartOfWorkday;
                worksheet.Cells[i + 2, 5].Value = log.EndOfWorkday;
                worksheet.Cells[i + 2, 6].Value = log.StartOfLunch;
                worksheet.Cells[i + 2, 7].Value = log.EndOfLunch;
                worksheet.Cells[i + 2, 8].Value = log.LunchDuration;
                worksheet.Cells[i + 2, 9].Value = log.OverExtensionLunch;
                worksheet.Cells[i + 2, 10].Value = log.AbsenceId;
                worksheet.Cells[i + 2, 11].Value = log.SumOfWorkedHours;
            }

            var fileContents = package.GetAsByteArray();

            return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "WorkLogs.xlsx");
        }
    }



}

