using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Palkan lasku 27.3.
            
            // Muuttujat
            string input; // Tallenetaan käyttäjän arvot

            // Tuntipalkka
            double hourlySalary;

            // Tunnit, joista maksetaan 100% palkka
            double normalHours;

            // Tunnit, joista maksetaan 150% palkka
            double plus50PercentHours;

            // Tunnit, joista maksetaan 200% palkka
            double plus100PercentHours;

            // Laskettu kuukausipalkka
            double totalSalary;

            Console.Write("Anna tuntipalkka: ");
            input = Console.ReadLine();
            hourlySalary = double.Parse(input);

            Console.Write("Anna normaalit tunnit: ");
            // Käyttäjän arvon lukeminen ilman -input- muuttujan käyttöä
            normalHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 50% korotetut tunnit: ");
            plus50PercentHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 100% korotetut tunnit: ");
            input = Console.ReadLine();
            plus100PercentHours = double.Parse(input);

            // Laskuoperaatio
            // Laskukaavassa arvot 1.5 ja 2 käytetään termiä "Magic Number"
            // ratkaisu olisi tallentaa arvot sopivan nimisiin muuttujiin.
            // Erityisesti jos arvoa käytetään useaan kertaan.
            totalSalary = hourlySalary * normalHours + // laskuoperaation voi jakaa usealle riville
                        hourlySalary * 1.5 * plus50PercentHours +
                        hourlySalary * 2 * plus100PercentHours;

            Console.WriteLine($"Kuukausi palkka on {totalSalary}");

            Console.ReadKey();









        }
    }
}
