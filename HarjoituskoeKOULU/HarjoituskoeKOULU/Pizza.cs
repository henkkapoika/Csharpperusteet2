using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoituskoeKOULU
{
    class Pizza
    {
        // Properties
        public List<Topping> Toppings { get; set; }
        public int BasePrice { get; set; }

        // Constructor
        public Pizza()
        {
            Toppings = new List<Topping>(); // Tyhjä lista
            BasePrice = 15; // Voisi hakea tietokannasta
        }

        // Methods
        public int CalculatePrice()
        {
            int result = 0;
            
            // Onko täytteitä yli kolme
            if (Toppings.Count > 3)
            {
                result += Toppings.Count - 3; // Lisätään hintaan täytteiden lukumäärä - 3
            }

            return BasePrice + result;
        }

    }
}
