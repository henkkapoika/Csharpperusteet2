using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot___MeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna mitta (metreinä): ");
            double meters = double.Parse(Console.ReadLine());

            

            Console.WriteLine($"{meters}m muunnettuna sentteihin: {MeterConverter.ToCentimeter(meters)}");
            Console.WriteLine($"{meters}m muunnettuna kilometreihin: {MeterConverter.ToKilometer(meters)}");
            Console.WriteLine($"{meters}m muunnettuna desimetreihin: {MeterConverter.ToDecimeter(meters)}");
            Console.WriteLine($"{meters}m muunnettuna jalkoihin: {MeterConverter.ToFeet(meters)}");
            Console.WriteLine($"{meters}m muunnettuna tuumiin: {MeterConverter.ToInch(meters)}");
            Console.WriteLine($"{meters}m muunnettuna jaardeihin: {MeterConverter.ToYard(meters)}");



            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
