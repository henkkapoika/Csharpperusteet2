using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int userNumber = int.Parse(Console.ReadLine());
            //                  ehto                        arvo jos true           :           arvo jos false
            string message = (userNumber % 2 == 0) ? $"Numero {userNumber} on parillinen" : $"Numero {userNumber} on pariton";
            //                                                                              Tässä kohtaa voi ketjuttaa uuden ternary operaation
            Console.WriteLine(message); // Näytetään tulos käyttäjälle



            Console.ReadKey();


        }

    }
}
