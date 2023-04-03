using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16C_Kuukaudet
{
    class Program
    {
        static void Main(string[] args)
        {

            // If-else
            //Console.Write("Anna kuukausi: ");
            //string monthIF = Console.ReadLine();


            //// Muokataan teksti pieniksi kirjaimiksi
            //monthIF = monthIF.ToLower(); // ToLower() muokaa kirjaimet pieniksi

            //if (monthIF == "tammikuu" || monthIF == "helmikuu" || monthIF == "maaliskuu" || monthIF == "marraskuu" || monthIF == "joulukuu")

            //{
            //    Console.WriteLine("Kyseinen kuukausi kuuluu talveen");
            //}
            //else if (monthIF == "huhtikuu" || monthIF == "toukokuu")
            //{
            //    Console.WriteLine("Kyseinen kuukausi kuuluu kevääseen");
            //}
            //else if (monthIF == "kesäkuu" || monthIF == "heinäkuu" || monthIF == "heinäkuu")
            //{
            //    Console.WriteLine("Kyseinen kuukausi kuuluu kesään");
            //}
            //else if (monthIF == "syyskuu" || monthIF == "lokakuu")
            //{
            //    Console.WriteLine("Kyseinen kuukausi kuuluu syksyyn");
            //}
            //else
            //{
            //    Console.WriteLine("Syöttämääsi kuukautta ei löytynyt");
            //}

            // switch bersio

            //Console.Write("Anna kuukausi numeroina: ");
            //int monthSwitch = int.Parse(Console.ReadLine());

            //switch (monthSwitch)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("Talvi kuukausi");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Kevät kuukausi");
            //        break;
            //    // C# 7 versiossa voidaan ilmaista myös tietty numero alue.
            //    // case int xyz when (xyz >= 6 || xyz <= 8):
            //    //   break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Kesä kuukausi");
            //        break;
            //    case 8:
            //    case 9:
            //    case 10:
            //        Console.WriteLine("Syys kuukausi");
            //        break;
            //    default:
            //        Console.WriteLine("Virheellinen numero");
            //        break;

            //}

            // ternary versio

            Console.Write("Syötä kuukausi numeroina: ");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            // ternary vertailu
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
                monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
                monthTernary >= 6 && monthTernary <= 8 ? "Kesä" :
                monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                "Virheellinen arvo";

            Console.WriteLine(message);




            Console.ReadKey();







        }
    }
}
