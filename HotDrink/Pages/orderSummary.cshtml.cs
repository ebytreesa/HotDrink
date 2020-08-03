using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDrink.Services;
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
        public string image { get; set; }
        //public string Name { get; set; }
        private readonly IItemService ItemService;

        public orderSummaryModel(IItemService itemService)
        {
            ItemService = itemService;
        }
        public void OnGet(string name)
            {
                DrinksJson drinks = ItemService.ReadAll();
                Hotdrink d = drinks.HotDrinks.Where(i => i.name == name).FirstOrDefault();
                image = d.image;
                Name = d.name;

            }
            //ViewData["confirmation"] = $"{Name} with {Strength}, will be made with {Sweetner}";
                
    }
}