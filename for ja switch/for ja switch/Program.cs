using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ja_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 12d;

            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        initialValue = initialValue + i;
                        break;
                    case 2:
                       initialValue =  initialValue* i;
                        break;
                    case 3:
                        initialValue = initialValue / i;
                        break;
                    case 4:
                        initialValue = initialValue - i;
                        break;
                }

            }

            Console.WriteLine(initialValue);


            Console.ReadKey();
        }
    }
}
