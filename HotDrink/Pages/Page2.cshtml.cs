using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDrink.Models;
using HotDrink.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HotDrink.Pages
{
    [BindProperties]
    public class Page2Model : PageModel
    {
        //private readonly ILogger<PrivacyModel> _logger;
        //[BindProperty(SupportsGet = true)]
        private readonly IItemService ItemService;

        public Hotdrink Item { get; set;  }
        public string Strength { get; set; }
        public string Sweetner { get; set; }
        public string Extra { get; set; }
        public string Delivery { get; set; }

        public Page2Model(IItemService itemService)
        {
            ItemService = itemService;
        }

        public void OnGet(string name)
        {
            DrinksJson drinks = ItemService.ReadAll();
            Hotdrink d = drinks.HotDrinks.Where(i => i.name == name).FirstOrDefault();            
            Item  = d;
        }
        //public IActionResult OnPost()
        //{
        //    var d = new Dictionary<string, string>() { { "Strength", Strength },
        //                                               { "Sweetner", Sweetner },
        //                                               { "Extra", Extra },
        //                                                { "Delivery", Delivery },
        //        {"Name", Item.name }
        //    };

        //    return new RedirectToPageResult("orderSummary", d);
        //}
    }
}