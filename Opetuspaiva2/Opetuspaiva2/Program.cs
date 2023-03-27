using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspaiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Harjoitus 22.3.

            int age = 27; // Integer - kokonaisluku
            age = 28; // Muokataan muuttujan arvo
            // " shift+2
            // { = ctrl + alt + 7
            // } = ctrl + alt + 0
            // $ = ctrl + alt + 4
            Console.WriteLine($"{age} on käyttäjän ikä");

            

            double value1 = 0.1;
            double value2 = 0.2;
            double value3 = value1 + value2;
            Console.WriteLine(value3);

            double height = 1.78; // Double - liukuluku(desimaalit)
            height = 1.8;
            Console.WriteLine($"{height} on käyttäjän pituus");

            string name = "Henrik";
            name = "Pekka";
            Console.WriteLine($"{name} käyttäjän nimi.");

            bool loggedIn = true; // boolean - totuusarvomuuttuja
            loggedIn = false;
            Console.WriteLine($"Käyttäjä on kirjautunut: {loggedIn}");

            // ' -> Ä oikealla puolella
            char replaceWith = 't'; // char, Yksi merkki
            replaceWith = 'T';
            Console.WriteLine($"Korvataan kirjaimella {replaceWith}");

            // Harjoitus 23.3.

            string userInput; // Tallenetaan käyttäjän syöttämä arvo
            Console.WriteLine();
            Console.WriteLine("Harjoitus 23.3. ");
           
            Console.Write("Anna pituus metreinä: ");
            userInput = Console.ReadLine(); // Käyttäjän syöttämä luku tallessa
            double length = double.Parse(userInput); // Muokataan string arvo double dataksi

            Console.Write("Anna leveys metreinä: ");
            userInput = Console.ReadLine();
            double width = double.Parse(userInput);

            double area = length * width;
            Console.WriteLine($"Alueen pinta-ala: {area}");





            // Koodin lopussa
            Console.ReadKey();
        }
    }
}
