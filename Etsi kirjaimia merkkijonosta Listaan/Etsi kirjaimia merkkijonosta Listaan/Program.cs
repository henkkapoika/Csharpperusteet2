using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etsi_kirjaimia_merkkijonosta_Listaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana 1: ");
            string word1 = Console.ReadLine(); 

            Console.Write("Syötä sana 2: ");
            string word2 = Console.ReadLine();

            List<(char, int)> charsInCommon = new List<(char, int)>();


            string charsTested = "";

            for (int i = 0; i < word1.Length; i++) // word1 indeksi == i
            {
                int numberOftimesFound = 0;

                for (int j = 0; j < word2.Length; j++) // word2 indeksi == j
                {
                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false)
                    {
                        numberOftimesFound++;
                        charsInCommon.Add((word1[i], numberOftimesFound));

                    }
                }
                charsTested += word1[i];
            }

            foreach ((char c, int i) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.c} löytyi {pair.i} kerran/kertaa");
            }




            Console.ReadKey();
        }
    }
}
