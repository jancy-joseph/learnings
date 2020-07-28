
using System;
using System.Collections.Generic;

namespace mynewDeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck  d1 = new Deck();
           // d1.ShowDeck();
            Console.WriteLine("Shuffling now...");
            d1.shuffle();
           // Console.WriteLine("Showing dec again");
           // d1.ShowDeck();
           // Console.WriteLine("resttting ...again");
            //d1.reset();
           // Console.WriteLine("Showing dec again");
            //d1.ShowDeck();

            List<Card> user1Hand = new List<Card>();
            List<Card> user2Hand = new List<Card>();
            for (int i =0; i<3; i++)
            {
                 user1Hand.Add(d1.deal());
                 user2Hand.Add(d1.deal());
            }
           // d1.ShowDeck();
            Player p1 = new Player("John",user1Hand);
            Player p2 = new Player("Oliver",user2Hand);
            p1.ShowHand();
            p2.ShowHand();
            var drawncard = p1.draw(ref d1);
            Console.WriteLine(drawncard.val);
           // d1.ShowDeck();
           p1.ShowHand();
        }
    }
}


