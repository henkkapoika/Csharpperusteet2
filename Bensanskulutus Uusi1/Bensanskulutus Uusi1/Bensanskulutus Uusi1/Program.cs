using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bensanskulutus_Uusi1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Luodaan taulukko ja lista
            double[] gasPriceArray = new double[3];
            List<double> gasPriceList = new List<double>();

            while (true) // Lisätään silmukka, joka pyörii kunnes käyttäjä haluaa lopettaa
            {
                Console.Write("Kuinka pitkä matka kilometreinä: ");
                double kiloMeters = double.Parse(Console.ReadLine());

                Console.Write("Paljonko ajoneuvon keskikulutus: ");
                double baseConsumption = double.Parse(Console.ReadLine());

                Console.Write("Polttoaineen litrahinta: ");
                double gasPrice = double.Parse(Console.ReadLine());

                gasPriceArray = ExtendArray(gasPriceArray, consumptionToEur(kiloMeters, baseConsumption, gasPrice));
                gasPriceList.Add(consumptionToEur(kiloMeters, baseConsumption, gasPrice));

                Console.WriteLine($"Matkan kulut euroina: {consumptionToEur(kiloMeters, baseConsumption, gasPrice)}");

                Console.Write("Syötä 'e' lopettaaksesi tai paina enter jatkaaksesi: ");
                string userInput = Console.ReadLine();
                if (userInput == "e") // Tarkistetaan haluaako käyttäjä lopettaa
                {
                    Console.WriteLine($"Kaikki syötetyt kulut euroina: {string.Join(", ", gasPriceList)}");
                    Console.WriteLine($"Kaikki syötetyt kulut euroina: {string.Join(", ", gasPriceArray)}");
                    break; // Poistutaan silmukasta
                }
            }

            // Sammutetaan ohjelma
            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi");
            Console.ReadKey();
        }
        //Luodaan uusi metodi jossa lasketaan käyttäjältä saatujen syötteiden perusteella hinta bensiininkulutukselle
        public static double consumptionToEur(double kiloMeters, double baseConsumption, double gasPrice)
        {
            return (kiloMeters / 100 * baseConsumption) * gasPrice;
        }

        // Luodaan uusi metodi, joka ottaa parametreinä taulukon ja palauttaa uuden taulukon
        public static double[] ExtendArray(double[] arr, double value)
        {
            double[] newArr = new double[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = value;
            return newArr;
        }
    }
    
}
