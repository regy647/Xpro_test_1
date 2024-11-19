using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Xpro_test_1.Areas.Identity.Data;
using Xpro_test_1.Models;
using Xpro_test_1.ViewModels;

namespace Xpro_test_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        

        public IActionResult Index()
        {
            var currentDate = DateTime.Now;

            var workdays = new List<DateTime>();

            int daysToCheck = 0;
            while (workdays.Count < 5)
            {
                var day = currentDate.AddDays(-daysToCheck); 
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday) 
                {
                    workdays.Add(day);
                }
                daysToCheck++;
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workLogsThisWeek = _context.WorkLogs
                .Where(w => w.UserId == userId && workdays.Contains(w.Date.Date))
                .ToList();

            var workdayStatus = new List<DayStatusViewModel>();
            foreach (var day in workdays)
            {
                var entry = workLogsThisWeek.FirstOrDefault(w => w.Date.Date == day.Date);

                workdayStatus.Add(new DayStatusViewModel
                {
                    DayOfWeek = day.DayOfWeek.ToString(),
                    Date = day.Date,
                    HasEntry = entry != null 
                });
            }

            var model = new HomePageViewModel
            {
                WeekStatus = workdayStatus
            };

            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}