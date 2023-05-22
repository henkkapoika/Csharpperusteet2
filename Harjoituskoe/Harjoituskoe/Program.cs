using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituskoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Pizza pizza = new Pizza(15m);
            List<Topping> allToppings = new List<Topping>()
            {
            new Topping("Pepperoni"),
            new Topping("Herkkusieni"),
            new Topping("Oliivi"),
            new Topping("Jauheliha"),
            new Topping("Tonnikala")
            };

            Console.WriteLine("Pitsan tilaus:\n");

            while (true)
            {
                Console.WriteLine("Valitut täyteet:");
                foreach (Topping topping in pizza.Toppings)
                {
                    Console.WriteLine(topping.Name);
                }

                Console.WriteLine("\nVaihtoehdot:");
                for (int i = 0; i < allToppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {allToppings[i].Name}");
                }

                Console.Write("\nSyötä täyte (1-5) tai 'e' lopettaaksesi: ");
                string input = Console.ReadLine();

                if (input == "e")
                {
                    break;
                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
                {
                    Topping selectedTopping = allToppings[choice - 1];
                    pizza.Toppings.Add(selectedTopping);
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta. Syötä luku 1-5 tai 'e'.");
                }

                Console.Clear();
            }

            Console.WriteLine("\nValitut täyteet:");
            foreach (Topping topping in pizza.Toppings)
            {
                Console.WriteLine(topping.Name);
            }

            decimal totalPrice = pizza.CalculatePrice();
            Console.WriteLine($"\nPitsan hinta: {totalPrice}eur");

            Console.Write("\nHyväksy tilaus syöttämällä 'k'. Syötä 'e' peruttaaksesi: ");
            string orderConfirmation = Console.ReadLine();

            if (orderConfirmation == "k")
            {
                Console.Write("Syötä osoite: ");
                string address = Console.ReadLine();

                Console.WriteLine("\nTilaus vastaanotettu. Kiitos!");
            }
            else if (orderConfirmation == "e")
            {
                Console.WriteLine("\nTilaus peruttu.");
            }
            else
            {
                Console.WriteLine("\nVirheellinen syöte. Tilaus peruttu.");
            }



            Console.WriteLine();
            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi.");
            Console.ReadKey();
        }
    }
}
