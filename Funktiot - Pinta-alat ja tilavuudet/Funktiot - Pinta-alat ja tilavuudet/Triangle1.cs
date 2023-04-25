using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot___Pinta_alat_ja_tilavuudet
{
    class Triangle1
    {
        // Properties
        public double Heigth { get; set; }
        public double Base { get; set; }

        // Constructor
        public Triangle1(double heigth, double baseParameter)
        {
            Heigth = heigth;
            Base = baseParameter;
        }

        // Methods
        // Ei tarvitse static, koska tätä käytetään luokan objektista.
        // Esim: Triangle1 test = new Triangle1(2, 5); - Luodaan objekti luokasta, nimeltä "test"
        // Console.WriteLine(test.Area()); - käytetään objektin metodia.
        public double Area()
        {
            double result = 0;

            result = Base * Heigth / 2;

            return result;
        }

        public double Perimeter()
        {
            
            double result = 0;
            
            result = Heigth + Base + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Heigth, 2)); 

            return result;
        }



    }
}
