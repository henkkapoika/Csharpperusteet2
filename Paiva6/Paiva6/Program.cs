using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiva6
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 12;

            // Luodaan for silmukka, joka tapahtuu 4 kertaa
            for (int i = 1; i <= 4; i++)
            {
                switch (i) // Sulkujen sisällä tutkittava arvo
                {
                    case 1:
                        // Koodi
                        initialValue += i;
                        break; // Päättää switch rakenteen suorituksen
                    case 2:
                        initialValue = initialValue * i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue = initialValue - i;
                        break;
                }
            }
            Console.WriteLine($"Lopputulos: {initialValue}");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
