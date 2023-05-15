using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikkien_aiheiden_kertaus
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Nimi: {Name}");
            Console.WriteLine($"Ikä: {Age}");
        }
    }
}
