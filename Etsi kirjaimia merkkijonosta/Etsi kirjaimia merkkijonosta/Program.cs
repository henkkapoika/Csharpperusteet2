using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etsi_kirjaimia_merkkijonosta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen sana: ");
            string word1 = Console.ReadLine();

            Console.Write("Syötä toinen sana: ");
            string word2 = Console.ReadLine();

            // Taulukon käytön ongelma:
            // 1. Ei voi tietää sanan pituutta
            // 2. Ei voi tietää montako merkeistä ovat samoja

            // TODO: Luo taulukkoon pituus tarkalleen oikein.

            // charsInCommon sisältää merkit, jotka ilmenevät molemmissa sanoissa ja montako kertaa ne ilmenee
            // Tässä datatyyppi on "Tuple" johon voi tallentaa kaksi eri datatyyppiä yhdessä
            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            string charsTested = "";
            
            // Luodaan silmukka, joka käy läpi kaikki word1 merkit ja tarkistetaan ilmeneekö se word2-muuttujassa
            for (int i = 0; i < word1.Length; i++) // word1 indeksi == i
            {
                int numberOfTimesFound = 0;
                for (int j = 0; j < word2.Length; j++) // word2 indeksi == j
                {
                    // Onko sanan 1 indeksissä i sama kirjain kuin sanan 2 indeksissä j
                    // Ja ei ole vielä tallennettu kirjainta taulukkoon
                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false) 
                    {
                        // Estetään saman kirjaimen tallennus uudestaan
                        
                        numberOfTimesFound++;
                        charsInCommon[i] = (word1[i], numberOfTimesFound);
                    }
                }
                // Lisätään löydetty merkki, vasta sisemmän silmukan jälkeen

                charsTested += word1[i];
            }

            // Silmukka, jossa käydään läpi taulukko löydetyistä kirjaimista
            foreach( (char, int) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }

            
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
