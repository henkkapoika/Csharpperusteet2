using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luvun_vertailu
{
    class Program
    {
        static void Main(string[] args)
        {
          


            Console.Write("Anna luku: ");

            string userInput = Console.ReadLine(); // int value = int.Parse(Console.ReadLine());
            int Number = int.Parse(userInput);

            if (Number == 0)
            {
                Console.WriteLine("Number is 0");
            }

            else if (Number < 0)
            {
                Console.WriteLine("Number is smaller than 0");
            }
            else
            {
                Console.WriteLine("Number is larger than 0");
            }








            // Pysäytetään ohjelma.

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
