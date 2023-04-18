using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verolaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paljonko bruttopalkkasi on: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Paljonko veroprosenttisi on: ");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nettopalkkasi on: {taxCalculator(salary, taxPercentage)}");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static decimal taxCalculator (decimal salary, decimal taxPercentage)
        {
            decimal taxes = salary / 100 * taxPercentage;

            return salary - taxes;
            
        }
        


    }
}
