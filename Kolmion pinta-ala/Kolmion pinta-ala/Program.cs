using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmion_pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            double Kanta;
            double Korkeus;
            double Triangle;
            Console.Write("Anna kanta: ");
            input = Console.ReadLine();
            Kanta = double.Parse(input);

            Console.Write("Anna korkeus: ");
            input = Console.ReadLine();
            Korkeus = double.Parse(input);

            // Laskukaavio.

            Triangle = (Kanta * Korkeus) / 2;
            Console.WriteLine($"Kolmion pinta-ala on: {Triangle}");

            Console.ReadKey();






        }
    }
}
