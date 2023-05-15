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

            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();

                Console.Write("Syötä tuote ja lukumäärä(maito, 3): ");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(',');
                int amount = int.Parse(splitInput[1].Trim());

                // Lisätään tuote listaan käyttäjän syöttämän luvun verran 
                for (int i = 1; i <= amount; i++)
                {
                    newOrder.AddProduct(splitInput[0]);
                }

            } while (true); // TODO this condition

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
