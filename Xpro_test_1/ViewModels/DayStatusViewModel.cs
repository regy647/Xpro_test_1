using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Xpro_test_1.Models;
using Xpro_test_1.Controllers;
using Xpro_test_1.Areas;


namespace Xpro_test_1.ViewModels
{
    public class DayStatusViewModel
    {
        public string DayOfWeek { get; set; }
        public DateTime Date { get; set; }
        public bool HasEntry { get; set; }
    }
}
