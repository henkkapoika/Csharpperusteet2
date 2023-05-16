using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostoslista
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ShoppingList> order = new List<ShoppingList>();

            Console.Write("Mihin kauppaan tehdään ostoslista: ");
            string shop = Console.ReadLine();

            ShoppingList newOrder = new ShoppingList(shop);

            bool userExitsProductsLoop = false;
            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();

                // Näytetään valitut tuotteet
                // 1. Nimi Hinta
                // Ei päästä suoraan ShoppinList objektin private listaan käsiksi
                // 1. ShoppingList.GetProducts(); <- Palauttaa listan tuotteista ja se käydään läpi täällä
                // 2. ShoppingList.PrintProducts(); <- Tulostaa tuotteen konsoliin suoraan.
                newOrder.PrintProduct();

                Console.WriteLine();
                Console.Write("Syötä tuote ja lukumäärä(maito, 3): ");
                string input = Console.ReadLine();
                if (input != "") // Tallennetaan tuote, jos käyttäjä on syöttänyt jotakin
                {
                    string[] splitInput = input.Split(',');
                    int amount = int.Parse(splitInput[1].Trim());

                    // Lisätään tuote listaan käyttäjän syöttämän luvun verran 
                    for (int i = 1; i <= amount; i++)
                    {
                        newOrder.AddProduct(splitInput[0]);
                    }
                }
                else // Kun input on tyhjä, lopetetaan silmukka
                {
                    userExitsProductsLoop = true;
                }

            } while (userExitsProductsLoop != true);

            // Näytetään summa käyttäjälle

            Console.WriteLine();
            Console.WriteLine($"Ostoksien summa: {newOrder.Sum}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
