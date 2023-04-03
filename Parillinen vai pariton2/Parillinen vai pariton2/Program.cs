using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parillinen_vai_pariton2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber % 2) // Suoritetaan jakojäännöksen laskeminen
            {
                case 0: // Verrataan jakojäännöksen tulosta. Jakojäännös on 0, eli parillinen
                    Console.WriteLine($"Numero {userNumber} on parillinen.");
                    break;
                case 1: // Jakojäännökseen jäi 1, eli pariton
                        // default: // Voi käyttää myös defaulttia, koska luku on pariton, se ei ollut parillinen.
                    Console.WriteLine($"Numero {userNumber} on parillinen.");
                    break;

                    Console.ReadKey();
            }
        }
    }
}
