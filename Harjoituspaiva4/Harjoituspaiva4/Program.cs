using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspaiva4
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek currentDayOfWeekSWITCH = DateTime.Now.DayOfWeek;
            switch (currentDayOfWeekSWITCH) // Muuttuja, jota verrataan
            {
                case DayOfWeek.Saturday:
                    Console.WriteLine("Aukioloaika: 10:00 - 21:00");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Aukioloaika: 10:00 - 20:00");
                    break;
                default:
                    Console.WriteLine("Aukioloaika: 7:00 - 21:00");
                    break;


                    Console.Write("Anna luku: ");
                    int userNumber = int.Parse(Console.ReadLine());

                    switch (userNumber % 2) // Suoritetaan jakojäännöksen laskeminen
                    {
                        case 0: // Verrataan jakojäännöksen tulosta. Jakojäännös on 0, eli parillinen
                            Console.WriteLine($"Numero {userNumber} on parillinen.");
                            break;
                        case 1: // Jakojäännökseen jäi 1, eli pariton
                        // default: // Voi käyttää myös defaulttia, koska luku on pariton, se ei ollut parillinen.
                            Console.WriteLine($"Numero {userNumber} on parillinen.");
                            break;



                    }

            }
        }
    }
}
