using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna puhelinnumero: ");
            string phoneNumber = Console.ReadLine();
            //string n = phoneNumber.Substring(1, phoneNumber.Length);
            //int e;

            // Tarkistetaan, että käyttäjän syöte on kaikinpuolin oikein
            // Extran kanssa oli ongelmia, koitin tehdä uuden string-muuttujan josta poistettiin "+" substringin avulla
            // ja siihen jätettiin pelkästään numerot. Sen jälkeen iffasin TryParsea käyttäen, mutta iski erroria jatkuvasti
            // joten poistin sen.
            if (phoneNumber.Length < 13 || phoneNumber.Length > 13)
            {
                Console.WriteLine("Number is too short or too long (13-characters needed)!");
            }
            else if (phoneNumber.StartsWith("+358") == false)
            {
                Console.WriteLine("Number doesn't start with '+358'!");
            }
            //else if (int.TryParse(n, out e) == false)
            //{
               // Console.WriteLine("Number is not in correct format, only numbers are accepted!");
            //}
            else
            {
                Console.WriteLine("Number is correct!");
            }

            Console.Write("Anna etunimi: ");
            string firstName = Console.ReadLine();

            Console.Write("Anna sukunimi: ");
            string lastName = Console.ReadLine();

            Console.WriteLine(StudentAccount(firstName, lastName));


            // ChatGPT:n tarkistuttama ja korjaama koodi
            List<JavelinThrow> throws = new List<JavelinThrow>();
            
            while (true)
            {
                Console.Write("Anna heittäjän nimi: ");
                string throwName = Console.ReadLine();


                Console.Write("Anna heittäjän heiton pituus (m): ");
                int meters = int.Parse(Console.ReadLine());

                Console.Write("Anna heittäjän heiton pituus (cm): ");
                int centiMeters = int.Parse(Console.ReadLine());

                JavelinThrow newThrow = new JavelinThrow(throws.Count + 1, meters, centiMeters, throwName);

                throws.Add(newThrow);

                Console.WriteLine("Jatketaanko heittojen listaamista(painamalla 'n' voit lopettaa):");
                string userIput = Console.ReadLine();
                if (userIput == "n")
                {
                    break;
                }

            }
           
            Console.WriteLine("Kaikki heitot:");
            foreach (JavelinThrow javelinThrow in throws)
            {
                Console.WriteLine($"Heittäjä: {javelinThrow.AthleteName}");
                Console.WriteLine($"Heiton pituus: {javelinThrow.Meters} metriä {javelinThrow.Centimeters} senttimetriä");
                Console.WriteLine();
            }


            // ChatGPT:ltä saatu apua:
            List<Product> productsList = new List<Product>();

            Console.WriteLine("Lisää tuotteita:");

            while (true)
            {
                Console.Write("Anna tuotteen nimi ('n' pysäyttää silmukan): ");
                string productName = Console.ReadLine();

                if (productName == "n")
                {
                    break;
                }

                Console.Write("Anna tuotteen id: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Anna tuotteen hinta: ");
                decimal productPrice = decimal.Parse(Console.ReadLine());

                Product newProduct = new Product(productName, productId, productPrice); 

                productsList.Add(newProduct); 

                Console.WriteLine("Tuote lisätty.");
                Console.WriteLine();
            }

            Console.WriteLine("Kaikki tuotteet ja niiden tiedot:");
            foreach (Product product in productsList)
            {
                Console.WriteLine($"Nimi: {product.Name}");
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Hinta: {product.Price}eur"); 

                decimal discountedPrice = product.CalculateDiscountedPrice(20); 
                Console.WriteLine($"Alennettu hinta: {discountedPrice}eur");

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi");
            Console.ReadKey();
        }
        public static string StudentAccount(string firstName, string lastName)
        {

            if (firstName.Length < 3 && lastName.Length < 5)
            {
                return firstName + lastName;
            }
            else
            {
                string studentPass = lastName.Substring(0, 5);
                string studentPass2 = firstName.Substring(0, 3);

                return studentPass + studentPass2;
            }
            
        }
    
    
    
    }
}
