using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotDrink.Models
{
    public class HotDrinkContext : DbContext
    {
        public HotDrinkContext (DbContextOptions<HotDrinkContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}
