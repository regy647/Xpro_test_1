using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Xpro_test_1.Models;
using Xpro_test_1.Controllers;
using Xpro_test_1.Areas;

namespace Xpro_test_1.ViewModels
{
    public class HomePageViewModel
    {
        public List<DayStatusViewModel> WeekStatus { get; set; }
    }

}
