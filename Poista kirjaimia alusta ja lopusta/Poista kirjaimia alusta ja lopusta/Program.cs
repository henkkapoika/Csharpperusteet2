using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poista_kirjaimia_alusta_ja_lopusta
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] splitInput = new string[1]; // Placeholder taulukko
            bool inputHasErrors = true;

            while (inputHasErrors == true)
            {

                Console.Write("Syötä sana ja poistettavien merkkien määrä (\"Omena\" 1): ");
                input = Console.ReadLine();

                splitInput = input.Split(' ');

                // splitInput[0] == käyttäjän syöttämä sana
                // splitInput[1] == käyttäjän syöttämä numero
                // 0 == vähintään poistettavien merkkien määrä
                // 2 == lasketaan yhteensä poistettavien merkkien määrä kertomalla poistettavat merkit kahdella
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1]) * 2 < splitInput[0].Length)
                {
                    inputHasErrors = false;
                }

            }
           


            // Vaihtoehto 1
            // Otetaan käyttäjän sanasta Substring
            // Substring vaatii aloitus indeksin ja montako merkkiä otetaan talteen aloituskohdasta lähtien

            // Esimerkiksi: "testaus" 2
            // Tarvittavat arvot Substring-metodiin alla:
            // Aloitusindeksi: 2
            // Tallennettavien merkkien määrä: 3 => sanan pituus - alun poisto - lopun poisto = merkkien määrä
            //                                   splitInput[0].Length - poistettavat merkit * 2 = merkkien määrä

            // UUSI TERMI: parametri, on metodin sulkujen sisälle syötetyt arvot.
            //              overload, metodi voi ottaa vastaan eri määrän parametrejä. Overload ilmaisee montako vaihtoehtoa on.
            //              Hiiri metodin päällä: ctrl+K sitten ctrl+P, voi käydä läpi kaikki eri overload vaihtoehdot
            string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            Console.WriteLine(result1);
            // Vaihtoehto 1



            // Vaihtoehto 2
            // Tehdään silmukka, jossa tallenetaan merkkejä yksi kerrallaan
            // "testaus 2" Aloitetaan silmukka kolmannesta merkistä ja jatketaan viimeiseen kopioitavaan indeksiin.
            // => "sta"

            string result2 = ""; // Tähän lisätään merkkejä yksi kerrallaan
            // StringBuilder => jos suorituskyky ongelmia
            
            // Silmukka alkaa ensimmäisen tallennettavan merkin indeksistä ja loppuu viimeiseen tallennettavaan indeksiin.
            for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)
            {
                result2 += splitInput[0][i]; // kopioidaan merkki käyttäjän sanan tietystä indeksistä
                // splitInput[0] viittaa käyttäjän sanaan eli => "testaus"[i]
            }
            Console.WriteLine(result2);

            // Vaihtoehto 2



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
