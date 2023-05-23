using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOE
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public Product(string name, int id, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
        public decimal CalculateDiscountedPrice(decimal DiscountPercentage)
        {
            decimal discountAmount = Price * (DiscountPercentage / 100);
            decimal discountedPrice = Price - discountAmount;

            return discountedPrice;
        }
    
    
    }
}
