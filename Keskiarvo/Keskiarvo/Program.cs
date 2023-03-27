using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double averageNumber;
            double keskiArvo;
            Console.Write("Anna ensimmäinen luku: ");
            input = Console.ReadLine();
            firstNumber = double.Parse(input);

            Console.Write("Anna toinen luku: ");
            input = Console.ReadLine();
            secondNumber = double.Parse(input);

            Console.Write("Anna kolmas luku: ");
            input = Console.ReadLine();
            thirdNumber = double.Parse(input);

            // Laskukaavio.

            averageNumber = firstNumber + secondNumber + thirdNumber;
            keskiArvo = averageNumber / 3;

            Console.WriteLine($"Keskiarvo on: {keskiArvo}");

                
               







        }
    }
}
