using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipeli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti pakasta.
            // Pakan sekoitus metodi

            // Tässä on pelin kaikki kortit
            Deck deck = new Deck();
            // Lisää sovellukseen toinen pelaaja
            // Tässä on pelaajien kädet
            Deck player1Deck = new Deck();
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();

            // Nosta molemmille pelaajille kortit
            player1Deck.Cards.Add(deck.Draw());
            player2Deck.Cards.Add(deck.Draw());

            // Ilmoita kumpi voitti
            // Isompi arvo voittaa
            // Ässä == 1
            // Tasapelissä seuraavasti:
            // Hearts > Diamonds > Clubs > Spades

            if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Player one won!");
            }
            else if (player2Deck.Cards[0].Value > player1Deck.Cards[0].Value)
            {
                Console.WriteLine("Player two won!");
            }
            else // Jos sama arvo, verrataan maat
            {
                if (player1Deck.Cards[0].Suite > player2Deck.Cards[0].Suite)
                {
                    Console.WriteLine("Player one won(draw on cards)!");
                }
                else if (player2Deck.Cards[0].Suite > player1Deck.Cards[0].Suite)
                {
                    Console.WriteLine("Player two won(draw on cards)!");
                }
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
