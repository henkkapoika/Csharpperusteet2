using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokaalit_taulukkoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sana: ");
            string word = Console.ReadLine().ToLower();

            char[] vowels = new char[word.Length];
            int vowelCount = 0;

            List<char> vowelsList = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowels[vowelCount] = letter;
                    vowelCount++;
                    vowelsList.Add(letter);
                }
            }

            Console.Write("Vokaaleja sanassa: ");
            for (int i = 0; i < vowelCount; i++)
            {
                Console.Write($"{vowels[i]} ");
            }
            Console.WriteLine();

            Console.Write("Vokaaleja sanassa: ");
            foreach (char vowel in vowels)
            {
                Console.Write(vowel + " ");
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
