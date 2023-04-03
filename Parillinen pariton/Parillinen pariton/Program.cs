using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parillinen_pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku johon saakka tulostetaan lukuja: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Tulostetaanko parilliset (x) vai parittomat (y): ");
            char character = Convert.ToChar(Console.Read());

            char[] x_Char = { 'x', 'X' };
            char[] y_Char = { 'y', 'Y' };


            
            
                if (character == x_Char[0] || character == x_Char[1])
                {
                Console.WriteLine("Parilliset :");
                for (int n = 1; n < (number + 1); n++)
                    {
                    if (n % 2 == 0)
                        {
                        Console.WriteLine(n);
                    }
                    }
                }



            if (character == y_Char[0] || character == y_Char[1])
            {
                Console.WriteLine("Parittomat :");
                for (int n = 1; n < (number + 1); n++)
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine(n);
                    }
                }
            }











        }


    }   }
