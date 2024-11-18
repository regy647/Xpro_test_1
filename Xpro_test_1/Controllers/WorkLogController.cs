using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System;
using Xpro_test_1.Areas.Identity.Data;
using Xpro_test_1.Models;

namespace Xpro_test_1.Controllers
{
    public class WorkLogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkLogController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? year, int? month)
        {
            var currentDate = DateTime.Now;

            // Set default to the current month if no year or month is selected
            int selectedYear = year ?? currentDate.Year;
            int selectedMonth = month ?? currentDate.Month;

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);  // Get the logged-in user's ID

            // Fetch work logs for the user for the selected month and year
            var workLogs = _context.WorkLogs
                .Where(w => w.UserId == userId && w.Date.Year == selectedYear && w.Date.Month == selectedMonth)
                .ToList();

            // Prepare the view model
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

        private List<SelectListItem> GetMonths()
        {
            return Enum.GetValues(typeof(Month))
                .Cast<Month>()
                .Select(m => new SelectListItem
                {
                    Text = m.ToString(),
                    Value = ((int)m).ToString()
                })
                .ToList();
        }

        private List<SelectListItem> GetYears()
        {
            var currentYear = DateTime.Now.Year;
            return Enumerable.Range(currentYear - 5, 10)
                .Select(year => new SelectListItem
                {
                    Text = year.ToString(),
                    Value = year.ToString()
                })
                .ToList();
        }

        // Action for editing work log data
        public IActionResult Edit(int id)
        {
            var workLog = _context.WorkLogs.FirstOrDefault(w => w.Id == id);
            if (workLog == null) return NotFound();

            // Pass the work log to the view for editing
            return View(workLog);
        }

        // Action to update work log data
        [HttpPost]
        public IActionResult Edit(WorkLog workLog)
        {
            if (ModelState.IsValid)
            {
                _context.Update(workLog);
                _context.SaveChanges();
                return RedirectToAction("Index", new { year = workLog.Date.Year, month = workLog.Date.Month });
            }

            return View(workLog);
        }

        // Actions for navigating between months
        public IActionResult PreviousMonth()
        {
            var currentMonth = DateTime.Now.Month - 1;
            return RedirectToAction("Index", new { year = DateTime.Now.Year, month = currentMonth });
        }

        public IActionResult NextMonth()
        {
            var currentMonth = DateTime.Now.Month + 1;
            return RedirectToAction("Index", new { year = DateTime.Now.Year, month = currentMonth });
        }
    }
}
