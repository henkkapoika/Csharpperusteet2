using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        public static string Compare(int a, int b)
        {
            string numberA = a.ToString();
            string numberB = b.ToString();

            if (numberA == numberB || numberA[0] == numberB[1] && numberA[1] == numberB[0])
            {
                return "100%";
            }
            else if (numberA[0] == numberB[0] || numberA[1] == numberB[1] || numberA[0] == numberB[1] || numberA[1] == numberB[0])
            {
                return "50%";
            }
            else
            {
                return "0%";
            }
        }


    }
}
