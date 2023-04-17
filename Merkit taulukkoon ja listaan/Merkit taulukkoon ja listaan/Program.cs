using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkit_taulukkoon_ja_listaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita sana: ");
            string word = Console.ReadLine();

            char[] myArray;
            List<int> list = new List<int>();

            List<char> charList = new List<char>();
            char[] charArray = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                charList.Add(word[i]);
                charArray[i] = word[i];
            }


            
            int j = 0;
            Console.WriteLine("List of characters:");
            foreach (char c in word)
            {
                if (j % 2 == 0)
                {
                    charList.Add(char.ToUpper(c));
                    Console.WriteLine(c);
                }
                else
                {
                    charList.Add(c);
                    Console.WriteLine(c);
                }
                j++;

            }
            


            Console.WriteLine("Array of characters:");
            for (int i = 0; i < charArray.Length; i++)
            {
                char c = word[i];
                if (i % 2 != 0)
                {
                    c = char.ToUpper(c);
                }
                
                charArray[i] = c;
                Console.WriteLine(charArray[i]);
            }
            Console.WriteLine("Array of characters: " + new string(charArray));
            Console.WriteLine("List of characters: " + string.Join("", charList));

            Console.ReadKey();
        }
    }
}
