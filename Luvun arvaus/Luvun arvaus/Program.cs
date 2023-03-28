using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luvun_arvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctGuess = false;

            while (correctGuess == false)
            {

                Console.Write("Syötä luku: ");
                int guess = int.Parse(Console.ReadLine());
                int target = 7;

                if (guess == target) // oikea vastaus
                {
                    correctGuess = true;
                    Console.WriteLine("Arvasit oikein!");
                }

                else if (guess < target) // liian pieni
                {
                Console.WriteLine("Arvauksesi oli liian pieni");
                }
                else // liian suuri
                {
                Console.WriteLine("Arvauksesi oli liian suuri");
                }
                }
            Console.ReadKey();

        }
    }
}
