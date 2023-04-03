using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampotila_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako astetta: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Muutetaanko mutoon Fahrenehit = F vai Celsius = C: ");
            char character = Convert.ToChar(Console.Read());
            double endTemperature;

            char[] c_Char = { 'c', 'C' };
            char[] f_Char = { 'f', 'F' };

            if (character == c_Char[0] || character == c_Char[1])
            {
                endTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"Lämpötila on {endTemperature} celsius astetta.");

            }
            if (character == f_Char[0] || character == f_Char[1])
            {
                endTemperature = temperature * 9 / 5 + 32;
                Console.WriteLine($"Lämpötila on {endTemperature} Fahrenheit astetta");

            }

            Console.ReadKey();




            
        }
    }
}
