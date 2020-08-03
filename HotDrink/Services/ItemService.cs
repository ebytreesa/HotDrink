using HotDrink.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrink.Services
{
    public interface IItemService
    {
        DrinksJson ReadAll();
    }
    public class ItemService:IItemService
    {
        public DrinksJson ReadAll()
        {            
            DrinksJson drinks = JsonConvert.DeserializeObject<DrinksJson>(File.ReadAllText(@"Data/drinks.json"));
           
            return drinks;
        }
    }

}
