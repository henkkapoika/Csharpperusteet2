using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokka___Bensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään arvot käyttäjältä

            List<Trip> trips = new List<Trip>();

            bool userEndsLoop = false;

            while (userEndsLoop == false)
            {
                Console.Write("Syötä matkan nimi: ");
                string name =Console.ReadLine();

                Console.Write("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Syötä keskikulutus(l/100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineenhinta(eur/l): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(name, distance, averageConsumption, fuelPrice));

                Console.WriteLine();
                Console.Write("Jatketaanko ohjelmaa(y/n): ");
                string userInput = Console.ReadLine();

                if (userInput == "n" || userInput == "N")
                {
                    userEndsLoop = true;
                }
            }

            foreach (Trip t in trips)
            {
                // Lasku toimituksen voisi toteuttaa täällä käyttämällä objektien arvoja
                // Mutta yleensä luokan dataan liittyvät toiminnallisuudet
                // Ovat osana itse luokkaa.
                // double test = t.AverageConsumption * t.FuelPrice * t.FuelPrice
                Console.WriteLine();
                Console.WriteLine($"Matkan {t.Name} hinta on: {t.CalculateCost()}");
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


    }



}
