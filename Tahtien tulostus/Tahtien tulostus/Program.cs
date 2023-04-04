using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahtien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako merkkiä tulostetaan: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Mitä merkkiä tulostetaan: ");
            char symbol = char.Parse(Console.ReadLine());
            
            
            // 2. Lisätään silmukka, joka suoritetaan käyttäjän numeron verran
            // Tulostetaan yksi tähti, toistetaan käyttäjän syöttämän numeron verran

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(symbol);
            }

            


            Console.ReadKey();
        }
    }
}
