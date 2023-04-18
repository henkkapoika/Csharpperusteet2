using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria6
{
    class Program // Luokka
    {
        static void Main(string[] args) // Funktio / Metodi
        {
            // 1. Funktio / Function
            // Funktio on keino kapsuloida tietty toiminnallisuus, jota voidaan käyttää uudelleen
            // eri kohdissa prjektia. 


            // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti.
            // Metodi on termi funktiolle, joka on osana luokkaa.    

            // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen funktioon / metodiin
            // "Main"

            // Funktion / Metodi koodi tulee tiettyyn kohtaan tiedostoa

            // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle muiden
            // metodien / funktioiden kanssa, luokan sisälle.

            // Tänne ei voi luoda uutta funktiota, koska olemme jo "Main"-funktion sisällä.
            // Metodi luotiin "Main"-funktion alapuolelle

            // Täällä voidaan käyttää metodia

            // UUSI TERMI: olio / object
            // olio on instanssi luokasta.
            // Oletuksena metodeja voi ainoastaan käyttää, kun luokasta on luotu objekti.
            // Nyt uutta "printText()".metodia ei voida käyttää, ellei luoda luokasta "Program"
            // uutta objektia.

            Program test = new Program(); // Luodaan tämän tiedoston "Program" luokasta objekti
            test.printText("Hello", 123);
            test.printText("World", 321);

            // Poikkeuksena staattinen metodi
            // Jos metodista luodaan staattinen, sitä voi käyttää suoraan ilman objektia.

            // Esim:
            Console.WriteLine(""); // Tämä on "Console"-luokan staattinen "WriteLine()"-metodi
            //Program.multiplyNumbers(2, 10); // Viittaus "Program" luokkaan ei ole pakollinen
            // koska olemme sen luokan sisällä.
            // metodi palauttaa arvon, se pitää ottaa talteen.
            int fiveTimesThree = multiplyNumbers(5, 3);
            // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa
            // Nyt metodin "multiplyNumbers()" palautettava arvo toimii parametrinä metodille "WriteLine".

            Console.WriteLine(multiplyNumbers(5, 3)); 



            // 2. Luokka / Class
            // 2a. Constructor
            // 2b. Property
            // 2c. Metodi / Method


            // 3. struct


            // 4. enum



            // Pysäytetään sovellus lopussa.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }// Main function

        // Luodaan uusi metodi, muiden metodien ulkopuolelle, mutta luokan sisälle.

        // [näkyvyys] [palautettavaDatatyyppi] [metodinNimi] ( [parametrit], pilkulla eroteltuna )
        // Tämä funktio ottaa vastan kaksi arvoa: string message ja int number
        // Metodi kirjoittaa konsoliin parametrien sisällön
        private void printText(string message, int number)
        {
            // Private näkyvyys tarkoittaa, että sitä ei voida käyttää luokan ulkopuolelta
            // void -datatyyppi, ei palauta mitään
            // parametrit -dataa, joka lähetetään funktioon.
            Console.WriteLine($"Text: {message}{number}");
        }

        // Luodaan staattinen metodi
        // avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin.
        // Tämä metodi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen.
        public static int multiplyNumbers (int number1, int number2)
        {
            // public -näkyy luokan ulkopuolelle
            // static -tekee metodista staattisen (voi käyttää ilman objektia)
            // int - tämä metodi palauttaa int-arvon

            return number1*number2; // Return avainsanalla palautetaan arvo.
        }


    }// Class Program

}// Namespace
