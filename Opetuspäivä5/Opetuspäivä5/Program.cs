using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parillinen Pariton

            // Console.Write("Syötä luku: ");
            // int number = int.Parse(Console.ReadLine());

            // int i = 1; // iterointi: 1++ => i++ => i == 3 jne

            // kysytään käyttäjältä halutaanko parillinen vai pariton
            // Console.Write("Parillinen / Pariton: ");
            // string input = Console.ReadLine();



            // while (i <= number)
            // {
            // Lisätään ehto, joka tulostaa vain parittoman numeron
            // if (i % 2 != 0 && input == "Pariton")
            // {
            // Console.WriteLine(i);
            // }
            // else if (i % 2 == 0 && input == "Parillinen")
            // {
            //   Console.WriteLine(i);
            // }
            //  i++; // suoritetaan iteraatio jokaisella silmukan kierroksella
            //  }



            // for-silmukka
            string EVEN_TEXT = "Parillinen";
            string ODD_TEXT = "Pariton";

            Console.Write("Syötä luku: ");
            int number = int.Parse(Console.ReadLine());

            // while tarkistaa, että käyttäjä syöttää hyväksyttävän arvon
            string input = ""; // Muuttuja luodaan ennen silmukkaa, jotta sitä voi käyttää ehdossa
            bool inputFalse = true;

            while (inputFalse == true) // Silmukka toistetaan, niin kauan kuin käyttäjän syöte on väärin
            {
                Console.Write($"{EVEN_TEXT} / {ODD_TEXT}: ");
                input = Console.ReadLine();

                if (input == EVEN_TEXT)
                {
                    inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
                }
                else if (input == ODD_TEXT)
                {
                    inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
                }
            }
            
            
            // Käyttäjän syöte tarkistetaan aiemmin
            int startingPoint = input == EVEN_TEXT ? 2 : 1;

            // Parillinen alkaa 2
            // Pariton alkaa 1

            for (int i = startingPoint; i <= number; i += 2)
            {
                Console.WriteLine(i);
            }




            Console.ReadKey();
        }
    }
}
