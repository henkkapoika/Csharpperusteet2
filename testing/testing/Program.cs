using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigit(1, 1);
            LastDigit(24134, -4);





        }
        public static int[] LastDigit(long n, int d)
        {
            string asText = n.ToString();
            int[] result = new int[d];
            int arrayIndex = result.Length - 1;

            for (int i = asText.Length - 1; i >= asText.Length - d; i++)
            {

                result[arrayIndex] = int.Parse(asText[i].ToString());
                arrayIndex--;
            }

            return result;
        }
    }
}
