using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control structure - ohjausrakenne
            // 1. if - rakenne

            // if (ehto - condition) // lopputulos true / false
            // { <- start of the code block
            // if condition == true
            // Suoritetaan if blokin koodi
            // } <- end of the code block
            // jos condition == false
            // hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if (50 > 10) // true
            {
                Console.WriteLine("sisällä if");
            }
            Console.WriteLine("Jälkeen if");

            // 2. if - else
            // Joko suoritetaan if code block
            // Tai suoritetaan else code block

            Console.WriteLine("before if-else");
            if ("moi" != "terve")
            {
                Console.WriteLine("inside if");
            }
            else
            {
                Console.WriteLine("inside else");
            }
            Console.WriteLine("after if-else");

            Console.WriteLine();

            // 3. if - else if - else
            // Rakenteessa voi olla myös muita vertailuja
            // ainoastaan yksi code block suoritetaan
            // Vaikka useampi kohta olisi oikein

            if (6.5 >= 5.5)
            {
                Console.WriteLine("inside if");
            }
            else if (10 <= 10)
            {
                Console.WriteLine("inside else-if");
            }
            else
            {
                Console.WriteLine("inside else");
            }

            // Vertailuoperaattorit - Comparison operators
            // Vertailujen lopputulos on totuusarvo - boolean
            // true / false

            // == samat arvot
            // != eri arvot
            // < vasen pienempi kuin oikea
            // > vasen isompi kuin oikea
            // <= vasen pienempi tai yhtä suuri kuin oikea
            // >= vasen isompi tai yhtä suuri kuin oikea

            // Loogiset operaattorit - Logical operators
            // Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta -and-
            // age >= ageLimit && length == targetHeight 

            // || toinen totta -or-  ctrl+alt+<
            // age >= ageLimit || length == targetHeight

            // !  kääntää totuusarvon
            // bool accountDeleted = true;
            // if(!accountDeleted)
            //{
            // Jos EI ole poistettu, voidaan käyttää
            //}

            // if sulkujen sisällä pitää olla true
            // jos vertaillaan arvoa, jonka halutaan olla false
            // ! ennen muuttujaa

            // 4. Silmukat - Loops

            // while(condition)
            // {
            //      Execute done
            //      As long as condition == true
            // }

            // ensin maalataan koodia
            // kommentointi ctrl + k sitten ctrl + c
            // poisto ctrl + k sitten ctrl + u
            // while (true)
            //{
            //    Console.write("moi");
            //}

            string input = "";
            while (input != "exit")
            {
                Console.Write("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }

            //




            // Pysäytetään sovellus
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
