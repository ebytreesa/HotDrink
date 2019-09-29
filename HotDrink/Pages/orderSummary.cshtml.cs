using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotDrink.Pages
{
    [BindProperties(SupportsGet = true)]
    public class orderSummaryModel : PageModel
    {
        public string Strength { get; set; }
        public string Sweetner { get; set; }
        public string Extra { get; set; }
        public string Delivery { get; set; }
        public string Name { get; set; }
        //public string Name { get; set; }
        public void OnGet()
        {
            ViewData["confirmation"] = $"{Name} with {Strength}, will be made with {Sweetner}";
        }
        
    }
}