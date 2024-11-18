using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xpro_test_1.Areas.Identity.Data;
using Xpro_test_1.Models;

namespace Xpro_test_1.Controllers
{
    [Authorize]
    public class UserDisplayController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserDisplayController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string filter = "all", string searchQuery = "")
        {
            var users = _userManager.Users.AsQueryable();

            if (filter == "active")
            {
                users = users.Where(u => u.IsActive);
            }
            else if (filter == "inactive")
            {
                users = users.Where(u => !u.IsActive);
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                users = users.Where(u => u.Name.Contains(searchQuery));
            }

            var userList = await users.ToListAsync();

            ViewData["searchQuery"] = searchQuery; 
            ViewData["filter"] = filter; 

            return View(userList);
        }


    }
}
