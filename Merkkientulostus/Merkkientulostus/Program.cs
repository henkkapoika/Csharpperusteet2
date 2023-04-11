using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkientulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // merkki " - voidaan näyttää käyttäjälle kenoviivalla \ ennen "-merkkiä.
            Console.Write("Syötä sana ja tulostus suunta (\"Lattia A\"): ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            // inputSplit[0] == "terve"
            // inputSplit[1] == "L"

            // Tarvitaan valintarakenne, jolla tutkitaan tulostuksen suuntaa
            // Ehtorakenne kääntää string merkkien järjestyksen
            if (inputSplit[1] == "A") // Alusta
            {
                // Tätä ei periaattessa tarvita   
            }
            else if (inputSplit[1] == "L") // Lopusta
            {
                char[] chars = inputSplit[0].ToCharArray(); // "Testi" => ['T', 'e', 's', 't', 'i']
                Array.Reverse(chars);                        // ['i', 't', 's', 'e', 'T']
                string test = new string(chars);        // => "itseT"
                inputSplit[0] = test;                   // Tallenetaan uusi "itseT"-string taulukon indeksiin 0
            }

            foreach (char jokinNimi in inputSplit[0])
            {
                Console.WriteLine(jokinNimi);
            }



            Console.ReadKey();
        }
    }
}
