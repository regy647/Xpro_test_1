// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xpro_test_1.Areas.Identity.Data; // Replace with your actual namespace

namespace Xpro_test_1.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        // Enum for Employment Type
        public enum EmploymentType
        {
            DoločenČas,
            NedoločenČas,
            Student,
            Avtorsko,
            SP,
            Drugo
        }

        public class InputModel
        {
            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Required]
            [Display(Name= "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Phone]
            [Required]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Required]
            [Display(Name = "Job position")]
            public string Position { get; set; }

            [Display(Name = "Employment Type")]
            public EmploymentType EmploymentType { get; set; } 

            [Display(Name = "Employment Comment")]
            public string EmploymentComment { get; set; }

            [Display(Name = "Is Active")]
            public bool IsActive { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            Input = new InputModel
            {
                UserName = user.UserName,
                Email = user.Email,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                Position = user.Position,
                EmploymentType = (EmploymentType)user.EmploymentType, 
                EmploymentComment = user.EmploymentComment,
                IsActive = user.IsActive
            };
        }

        public async Task<IActionResult> OnGetAsync(string userId)
        {
            var user = string.IsNullOrEmpty(userId)
                ? await _userManager.GetUserAsync(User) 
                : await _userManager.FindByIdAsync(userId); 

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            await LoadAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string userId)
        {
            //var user = await _userManager.GetUserAsync(User);
            var user = string.IsNullOrEmpty(userId)
            ? await _userManager.GetUserAsync(User) 
            : await _userManager.FindByIdAsync(userId); 

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (Input.UserName != user.UserName)
            {
                var setUserNameResult = await _userManager.SetUserNameAsync(user, Input.UserName);
                if (!setUserNameResult.Succeeded)
                {
                    foreach (var error in setUserNameResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return Page();
                }
            }

            user.Name = Input.Name;
            user.Email = Input.Email; 
            user.PhoneNumber = Input.PhoneNumber;
            user.Position = Input.Position;
            user.EmploymentType = (Data.EmploymentType)Input.EmploymentType; 
            user.EmploymentComment = Input.EmploymentComment;
            user.IsActive = Input.IsActive;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            if (user.Id == _userManager.GetUserId(User))
            {
                await _signInManager.RefreshSignInAsync(user);
            }

            //await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            //return RedirectToPage();
            return RedirectToPage(new { userId });
        }
    }
}


