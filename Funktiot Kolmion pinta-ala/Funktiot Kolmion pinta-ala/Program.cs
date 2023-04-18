using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Kolmion_pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä kanta: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            Console.Write("Syötä korkeus: ");
            double heightTriangle = double.Parse(Console.ReadLine());

            double area = triangleArea(heightTriangle, baseTriangle);

            Console.WriteLine($"Kolmion pinta-ala: {area}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static double triangleArea (double baseTriangle, double heightTriangle)
        {

            return heightTriangle * baseTriangle / 2;
        }


    }
}
