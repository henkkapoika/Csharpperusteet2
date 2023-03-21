using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liukuluku - floating point
            // Merkkejä / Merkkijono
            // 't'  /  "word"
            // Bool
            // true/false 1/0
            // Literals
            // data on tallessa muuttujissa - variable
            // <data_type> <variable_name>
            //
            // int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15;
            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"

            string message = "Hello";

            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            // "Vastasit x", jossa x on käyttäjän syöte(input).
            Console.WriteLine("Vastasit {0}", input);
            Console.WriteLine($"Interpolating {input}");
            Console.WriteLine("Vastasit" + input);

            #region 3 C# Perus: Ikä-tehtävä
                Console.Write("Moro, annappa ikäsi:");
                int ika = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Olet " + ika + " vuotias");

            // Ilmoita käyttäjän ikä kuukausina
            int sum = 5 + 4;
            sum = 7 - ika;
            sum = sum * ika;
            sum /= ika;
            int kuukausina = ika * 12;
            Console.WriteLine($"Olet {ika} vuotias, joten {kuukausina} kuukausissa");
            // sum = 9
            #endregion


            #region 4 C# Perus: Palkan lasku
            // Pyydä käyttäjältä 4 eri arvoa ja suorita lasku
            //Console.Clear();
            Console.WriteLine("\n\nTuntipalkkasi :");
            int tuntiPalkka = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMontako tuntia työskentelet :");
            double tunti = int.Parse(Console.ReadLine());
            double palkka = tuntiPalkka * tunti;
            double palkka50 = palkka + (palkka * 0.5);
            double palkka100 = palkka + (palkka * 1.0);

            Console.WriteLine($"Alkuperäinen Palkka - {palkka}\n50% Korotettuna - {palkka50}\n100% Korotettuna - {palkka100}");
            Console.WriteLine("\n");



            #endregion



        }


    }
    
}