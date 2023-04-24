using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bensankulutus_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Bensankulutus

            #region

            bool userEndsLoop = false;

            // List<(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal) > (); // Tuple
            List<decimal> userDistances = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // Kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä.

            //(decimal, decimal, decimal) trips = new decimal[1];

            // Kohta 5, listään koko koodi silmukkaan
            while (userEndsLoop == false)
            {
                Console.Write("Syötä ajettu matka(km): ");
                decimal distanceInKilometers = decimal.Parse(Console.ReadLine());
                userDistances.Add(distanceInKilometers);


                Console.Write("Syötä ajoneuvon keskikulutus(l/100km): ");
                decimal averageConsumption = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumption);
                

                Console.Write("Syötä polttoaineen hinta(eur/l): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(fuelPrice);
                

                //trips[trips.Length - 1] = (distanceInKilometers, averageConsumption, fuelPrice);

                //decimal tripCost = carTripCostCalculator(distanceInKilometers, averageConsumption, fuelPrice);

                //Console.WriteLine(); // Tyhjä rivi
                //Console.WriteLine($"Ajetun matkan hinta on: {tripCost} euroa.");
                //Console.WriteLine(); // Tyhjä rivi

                Console.Write("Calculate another trip? (y/n): ");
                string input = Console.ReadLine();

                if (input == "n" || input == "N") // Käyttäjä lopettaa sovelluksen
                {
                    userEndsLoop = true; // Kun tämä muuttuja on true, silmukka päättyy
                }
                else
                {
                    // test = expandArray[test];
                    // test = expandArray[test];
                    // trips = expandArray(trips);

                }
            }

            // Käydään listat läpi ja tulostetaan matkojen hinnat.
            for (int i = 0; i < userDistances.Count; i++)
            {
                Console.WriteLine($"Matkan {i+1} hinta on: {carTripCostCalculator(userDistances[i], userAverageConsumption[i], userFuelPrice[i])}");
            }

            #endregion
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsumption, decimal fuelCost)
        {
            decimal result = 0;

            result = distanceInKilometers * averageConsumption * fuelCost / 100;

            return result;
        }

        //private static (decimal, decimal, decimal)[] expandArray ((decimal, decimal, decimal)[] originalArray) 
        //{
        //  // Luodaan uusi taulukko, joka on yhtä suurempi kuin alkuperäinen taulukko
        //  (decimal, decimal, decimal)[] result = new (decimal, decimal, decimal)[originalArray.Length + 1];
        //  // Kopioidaan arvot vanhasta taulukosta uuteen taulukkoon
        //  for (int i = 0; i < originalArray.Length; i++)
        //{
        //  newArray[i] = originalArray[i];
        //}
        //  return newArray;
        //}


    }
}
