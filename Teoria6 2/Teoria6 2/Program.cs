using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria6_2
{
    class Program   // Luokka
    {
        static void Main(string[] args) // Funktio / Metodi
        {
            // 2. Luokka / Class

            // Olio-ohjelmoinnin pohjimmainen idea on jakaa sovellus pieniin kokonaisuuksiin (luokkiin/olioihin)

            // Luokan luomisen sijainti, samalle tasolle muiden luokkien kanssa
            // Tässä tiedostossa "Program"-luokan kanssa samalle tasolle.

            // Luodaan luokasta objekteja
            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";
            Console.WriteLine($"Henkilön A nimi on: {personA.Name} ja ikä on: {personA.Age}");

            Person personB = new Person(25, "Matti", 1.8, new List<Pet>());
            
            Person personC = new Person(35, "Jesse", 179.6, new List<Pet>());




            Console.ReadKey();
        }





    } // Class Program päättyy

    // class - avainsana
    // Test - oman luokan nimi, isolla kirjaimella
    class Person // Luokkien idea on malliinta jotakin todellista asiaa. Tiettyyn pisteeseen saakka.
    {
        // 2a. Property
        // Data
        // kirjoita prop ja sen jälkeen sarkain kaksi kertaa
        // Propertyn syntaksi: [Näkyvyys] [datatyyppi] [nimi] [get ja set]
        // [get ja set] get määrittää kuinka arvo luetaan ja set määrittää kuinka arvo tallennetaan
        public int Age { get; set; }
        public double Length { get; set; }

        public Location CurrentLocation { get; set; }

        public string Name { get; set; }

        public List<Pet> Pets { get; set; }

        // 2b. Constructor
        // Erityis metodi, jolla tallennetaan objektiin oletusarvoja.
        // [Näkyvyys]
        // [nimi], joka täytyy olla täysin sama kuin luokan nimi

        public Person() // Constructoria voi olla monta eri versiota.
        {

        }
        public Person(int age, string name, double length, List<Pet> pets)
        {
            
            Age = age;
            Name = name;
            Length = length;
            Pets = pets;
        }


        // 2c. Metodi
        // Toiminnallisuus

        // Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä.
        public int Walk(Location newLocation)
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;

            CurrentLocation = newLocation; // Päivitetään uusi sijainti

            return result;
        }

    }


    public class Location
    {
        public int CoordinateX { get; set; }
    }

    public class Pet
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }



} // Namespace
