
using System;
using System.Collections.Generic;

namespace mynewDeckofCards
{
    public class Deck
    {
        public List<Card> cards;
        string[] cardsuit = new string[]{"Clubs", "Spades", "Hearts", "Diamonds"};
        string[] cardNames = new String[]{"Ace","2","3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public List<Card> discardPile;

        public Deck(){
            cards = new List<Card>();
            discardPile = new List<Card>();
            //4 cardsuits
            for(int i =0; i<cardsuit.Length;i++)
            {
                //13 cardNames
                for(int j=0; j<cardNames.Length;j++){
                    //j+1 as values are from 1-13
                    cards.Add(new Card(cardNames[j],cardsuit[i],j+1));
                }
                
            }
            
        }
        
        public Card deal()
        {
            Card card_dealt = cards[cards.Count -1];
            cards.RemoveAt(cards.Count -1);
            return card_dealt;
        }

        public void swapCards(int startIndex,int EndIndex)
        {
            Console.WriteLine("StartIndex val"+ cards[startIndex].val+"EndIndex val"+ cards[EndIndex].val);
            Card tempCard = cards[startIndex];
           // Console.WriteLine("Before"+cards[startIndex].val);
            cards.RemoveAt(startIndex);
           // Console.WriteLine("End iNdex value"+cards[EndIndex-1].val);
            cards.Insert(startIndex,cards[EndIndex-1]);
           // Console.WriteLine("After"+cards[startIndex].val);
            cards.RemoveAt(EndIndex);
          //  Console.WriteLine("Before"+cards[EndIndex].val);
            cards.Insert(EndIndex,tempCard);
            Console.WriteLine("StartIndex val"+ cards[startIndex].val+"EndIndex val"+ cards[EndIndex].val);

        }

        public void shuffle()
        {
            Random rand = new Random();
            Console.WriteLine("Count "+cards.Count);
            for(int i =0; i<1; i++)
            {
                Console.WriteLine("i :"+i);
               int index1 = rand.Next(0,cards.Count);
               swapCards(i,index1);
           }       
        }
        public void ShowDeck(){
            Console.WriteLine("Total count of cards : "+cards.Count);
            for(int i =0; i<cards.Count; i++)
            {
                Console.Write(cards[i].suit+" "+cards[i].stringVal+",");
            }
            Console.WriteLine();
        }
        public void reset()
        {
            cards.Clear();
            //4 cardsuits
            for(int i =0; i<cardsuit.Length;i++)
            {
                //13 cardNames
                for(int j=0; j<cardNames.Length;j++){
                    //j+1 as values are from 1-13
                    cards.Add(new Card(cardNames[j],cardsuit[i],j+1));
                }
                
            }

        }

    }

}