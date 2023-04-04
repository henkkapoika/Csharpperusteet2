using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertyma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako kierrosta: ");
            int round = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < round; i++)
            {
                // Summataan, tarvitaan muuttuja
                
                sum = sum + i;
            }
            Console.WriteLine($"{round} kierrosta Kertymäksi saatiin: {sum}");




            Console.ReadKey();
        }
    }
}
