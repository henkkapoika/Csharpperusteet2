using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lämpötilan_seuranta_2015
{
    class Program
    {
        static void Main(string[] args)
        {

            // Taulukon ja listan luonti

            string[] measurementTimes = { "6:00", "12:00", "18:00", "24:00" };

            double[] temperaturesArray = new double[measurementTimes.Length];
            List<double> temperaturesList = new List<double>();

            // Silmukka
            for (int i = 0; i < measurementTimes.Length; i++)
            {
                Console.Write($"Kello {measurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input; // Taulukko
                temperaturesList.Add(input); // Lista
            }
            // Suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja
            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on: {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaturesArray.Average()}");

            Console.WriteLine($"Listan suurin lämpötila on: {temperaturesList.Max()}");
            Console.WriteLine($"Listan pienin lämpötila on: {temperaturesList.Min()}");
            Console.WriteLine($"Listan keskilämpötila on: {temperaturesList.Average()}");

            
            // Arvojen etsiminen omalla koodilla
            // Algoritmi, termi koodille joka suorittaa jonkin asian
            // Tässä algoritmi, joka laskee keskiarvon
            int count = 0;
            double sum = 0;

            foreach (double temp in temperaturesArray)
            {
                sum += temp;
                count++;
            }

            Console.WriteLine($"Taulukon keskiarvo on {sum/count}");

            // Algoritmi, joka hakee listasta suurimman arvon

            double value = 0; // Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    value = temperaturesList[i];
                }
                
                // Onko uusi arvo suurempi kuin vanha arvo
                if (temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; // Otetaan talteen isompi arvo
                }
            }

            Console.WriteLine($"Listan suurin arvo on: {value}");

            // Algoritmi, joka hakee taulukosta pienimmän arvon

            double valuE = 0; // Tästä arvosta lähdetään liikkeelle ja tallennetaan pienin arvo

            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    valuE = temperaturesArray[i];
                }

                // Onko uusi arvo pienempi kuin vanha arvo
                if (temperaturesArray[i] < valuE)
                {
                    valuE = temperaturesArray[i]; // Otetaan talteen pienempi arvo
                }
            }

            Console.WriteLine($"Taulukon pienin arvo on: {valuE}");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
