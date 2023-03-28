using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ian_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ageCorrect = false;

            while (!ageCorrect)
            {
            
                Console.Write("Syötä ikäsi: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0;
                int maxAge = 120;


            // Tarkistetaan, että ikä on sopiva
                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Tallennus onnistui");
                }
                else
                {
                    Console.WriteLine($"Arvo ei ole hyväksyttävällä välillä ({minAge}-{maxAge})");
                }
            } // ctrl + a, ctrl + k, ctrl + d


            Console.WriteLine();
            Console.Write("Press any key to stop");
            Console.ReadKey();


        }
    }
}
