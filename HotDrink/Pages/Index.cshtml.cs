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
    public class IndexModel : PageModel
    {
        private readonly IItemService ItemService;
        //public List<Item> Items { get; set; }
        public DrinksJson drinks { get; set; }

        public IndexModel(IItemService itemService)
        {
            ItemService = itemService;
        }

        public void OnGet()
        {            
           drinks = ItemService.ReadAll();                     
        }
    }
}
