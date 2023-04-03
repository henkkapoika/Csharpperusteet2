using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parillinen_vai_pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen");
            }
            else
            {
                Console.WriteLine("Luku on pariton");
            }






        }
    }
}
