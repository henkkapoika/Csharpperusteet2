using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulosta_1_5_ja_5_1__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Luku, josta lähdetään tulostamaan: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Luku, johon tulostus päättyy: ");
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i >= endNumber; --i)
            {
                Console.WriteLine(i);
            }
            for (int i = startNumber; i <= endNumber; ++i)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
