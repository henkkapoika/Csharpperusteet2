using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukujen_summa_ja_keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako lukua summataan: ");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            
            
            for (int i = 1; i <= number; i++)
            {                
                
                Console.Write($"Anna luku {i}: ");
                sum = sum + int.Parse(Console.ReadLine());
                
            }

            

            Console.WriteLine($"Lukujen summa on: {sum} ja keskiarvo on: {sum/number}");


            Console.ReadKey();
        }
    }
}
