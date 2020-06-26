using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeziDunyam.Areas.Admin.ViewModels
{
    public class DashboardViewModel
    {
        public int CategoryCount { get; set; }
        public int PostCount { get; set; }
        public int UserCount { get; set; }
        public int AdminCount { get; set; }
    }
}