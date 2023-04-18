using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorit_jouleiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä kalorit, jotka muunnetaan jouleiksi: ");
            decimal calories = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä joulet, jotka muunnetaan kaloreiksi: ");
            decimal joule = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"Kalorit Jouleiksi: {caloriesTo(calories)}");
            Console.WriteLine($"Joulet Kaloreiksi: {joulesTo(joule)}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static decimal caloriesTo(decimal calories)
        {
            return calories * 4.184m;
        }
        private static decimal joulesTo(decimal joule)
        {
            return joule * 0.2390m;
        }




    }
}
