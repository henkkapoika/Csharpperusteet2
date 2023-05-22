using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituskoe
{
    class Pizza
    {
        public List<Topping> Toppings { get; set; }
        public decimal BasePrice { get; set; }

        public Pizza(decimal basePrice)
        {
            Toppings = new List<Topping>();
            BasePrice = basePrice;
        }

        public decimal CalculatePrice()
        {
            return BasePrice + Toppings.Count;
        }




    }
}
