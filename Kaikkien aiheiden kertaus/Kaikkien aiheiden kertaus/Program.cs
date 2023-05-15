using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikkien_aiheiden_kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give name: ");
            string name = Console.ReadLine();

            Console.Write("Give age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Give height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Give favorite letter: ");
            char letter = char.Parse(Console.ReadLine());

            List<int> averageList = new List<int>();

            switch (letter)
            {
                case 'a':
                    Console.WriteLine("Interesting");
                    break;
                case 'e':
                    Console.WriteLine("Enough");
                    break;
                case 'l':
                    Console.WriteLine("Best one");
                    break;
                case 'u':
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("Better.");
                    break;
                    
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name == "Pekka" || name == "pekka")
                {
                    Console.WriteLine("lol");
                }
                else
                {
                    Console.WriteLine("Better.");
                }
            }

            while (age > 100)
            {
                Console.WriteLine("Not healthy!");
            }

            string[] names = { "Jorma", "Pera" };

            foreach (string a in names)
            {
                Console.WriteLine(a);
            }

            Person person = new Person("Rami", 80);
            person.PrintDetails();

            Console.WriteLine($"{age} {height} {name} {letter} {whatAbout(name)}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        
        
        }
        private static bool whatAbout (string name)
        {
            return name == "pekka";
        }

    }
}
