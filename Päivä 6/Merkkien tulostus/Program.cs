using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Merkkijono
            // string - immutable == arvoa ei pysty muokkaamaan muistissa
            // string text1 = "123";
            // text1 = text1 + "test"; <= Varataan uusi lohko RAM-muistista

            // Merkkijonoa voi ajatella kokoelmana iksittäisiä merkejä. "monitor" => [ 'm', 'o' jne...]

            // Uudet termit: Method ja Property
            // Yleisiä string datatyypin metodeja:
            // - Lenght: (property) palauttaa merkkijonon pituuden. Esim: "word".Lenght == 4
            // - IndexOf: palauttaa merkin tai merkkijonon sijainnin merkkijonossa. Esim: "Tuesday".IndexOf("e") == 2 tai "wednesday".IndexOf
            // - ToUpper tai ToLower: "Cat".ToLower() == "cat"
            // - Substring: palauttaa osan merkkijonosta. Esim "Potato".Substring(2) == "tato" tai "Potato".Substring(2,2) == "ta"
            // - Replace: palauttaa merkkijonon, johon on korvattu tietyt merkit. Esim: "honday".Replace("h", "m") == "monday"
            // - Trim: palauttaa merkkijonon, josta on poistettu merkkijonon alusta ja lopusta välilöynnit.

            // string muuttujaa voidaan käsitellä silmukassa samalla tavalla kuin taulukoita.

            string text = "Hello";

            // Aloitetaan arvosta 0, koska indeksit alkavat nollasta
            for (int i = 0; i < text.Length; i++)
            {
                // Tiettyyn indeksiin päästään käsiksi hakasuluilla, joiden sisällä on indeksin arvo
                Console.WriteLine(text[i]);
            }

            // Huomioitavaa, että string on immutable datatyyppi. Kun string muuttujan arvoa muokataan, se korvataan muistissa
            // Eli alkuoeräistä arvoa ei muokata, vaan luodaan uusi muokattu kopio.
            // Tämän vuoksi jossakin tilainteissa kun muokataan toistuvasti string muuttujaa, suorityskyvyn vuoksi käytetään


            // 2. Taulukko
            //Array - mutable = arvoa pystytään muokkaamaan muistissa

            // 3. Lista
            // List - mutable

            // 4. Datarakenteet
            // Data structures

            Console.ReadKey();
        }
    }
}
