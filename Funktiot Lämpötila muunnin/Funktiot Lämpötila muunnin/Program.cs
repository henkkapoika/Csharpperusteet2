using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Lämpötila_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {

            bool userIsCorrect = false;
            // Silmukka, jossa odotetaan käyttäjältä oikeaa syötettä
            while (userIsCorrect == false)
            {
                // Kysytään halutaanko halutaanko muuntaa muotoon (C)-Celsius vai (F)-Fahrenheit
                Console.Write("(Lopeta sovellus 'Q' kirjaimella). Muunnetaanko muotoon (C) vai (F): ");
                string userInput = Console.ReadLine();

                double temperature;

                if (userInput == "C" || userInput == "c") // Tarkistetaan, onko käyttäjän syöte oikein
                {
                    Console.Write("Syötä lämpötilan arvo: "); // Jos ensimmäinen syöte on oikein, kysytään seuraava
                    string temp = Console.ReadLine();
                    
                    if (double.TryParse(temp, out temperature)) // Tarkistetaan vielä onko viimeinenkin syöte oikeassa muodossa
                                                                // Jos se ei ole, palataan silmukan alkuun
                    {
                        userIsCorrect = true; // Lopetetaan silmukka, kun viimeinenkin syöte on oikein
                        Console.WriteLine($"{FtoC(temperature)} - Celsius astetta"); // Lopuksi tulostetaan käyttäjälle haluttu lopputulos
                    }
                    
                }
                if (userInput == "F" || userInput == "f")
                {
                    Console.Write("Syötä lämpötilan arvo: ");
                    string temp = Console.ReadLine();
                    
                    if (double.TryParse(temp, out temperature))
                    {
                        userIsCorrect = true;
                        Console.WriteLine($"{CtoF(temperature)} - Fahrenheit astetta");
                    }

                }
                if (userInput == "Q" || userInput == "q")
                {
                    userIsCorrect = true;
                }
            }

            
            // Suljetaan sovellus
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    
        private static double CtoF (double temperature)
        {
            // Celsius to Fahrenheit -muunnin
            return temperature * 9d / 5d + 32d;



        }
        private static double FtoC (double temperature)
        {
            // Fahrenheit to Celsius -muunnin
            return (5d / 9d) * (temperature - 32d);

        }





    }
}
