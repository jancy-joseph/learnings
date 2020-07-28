using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    // Create a class called "Card"
    // Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
    // Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
    // Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.

    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string nameofCard,string cardType,int valueofCard)
        {
            stringVal = nameofCard;
            suit = cardType;
            val= valueofCard;
        }

    }

    // Give the Deck class a property called "cards" which is a list of Card objects.
    // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
    // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
    // Give the Deck a reset method that resets the cards property to contain the original 52 cards.
    // Give the Deck a shuffle method that randomly reorders the deck's cards.
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
            Card card_dealt = this.cards[cards.Count -1];
            this.cards.RemoveAt(cards.Count -1);
            return card_dealt;
        }

        public void swapCards(int startIndex,int EndIndex)
        {
            Card tempCard = this.cards[startIndex];
            this.cards.Insert(startIndex,this.cards[EndIndex]);
            this.cards.Insert(EndIndex,tempCard);
        }

        public void shuffle()
        {
            
            Random rand = new Random();
           for(int i =0; i<this.cards.Count; i++)
           {
               int index1 = rand.Next(0,this.cards.Count);
               swapCards(i,index1);
           }
            

        }

        public void reset()
        {
            //4 cardsuits
            for(int i =1; i<cardsuit.Length;i++)
            {
                //13 cardNames
                for(int j=0; j<cardNames.Length;j++){
                    //j+1 as values are from 1-13
                    cards.Add(new Card(cardNames[j],cardsuit[i],j+1));
                }
                
            }

        }

    }
    // Finally, create a class called "Player"

    // Give the Player class a name property.
    // Give the Player a hand property that is a List of type Card.
    // Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
    // Note this method will require reference to a deck object
    // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this 
    //Card or null if the index does not exist.
    public class Player{

        public string playerName;
        List<Card> playerHand;
        
        public Player(string plname,List<Card> plhand){
            playerName = plname;
            playerHand = plhand;
        }

        public Card draw(ref Deck fulldeck)
        {
            Card card_drawn = fulldeck.deal();
            if(this.playerHand.Exists(x=>x.val ==card_drawn.val)
            ||this.playerHand.Exists(x=>x.val ==(card_drawn.val+1))
            ||this.playerHand.Exists(x=>x.val ==(card_drawn.val-1)))
            {

                this.playerHand.Add(card_drawn);
            }
            else{
                fulldeck.discardPile.Add(card_drawn);
            }
            return card_drawn;
        }
        public Card discard(int IndexOfCard2beDiscarded)
        {
            if(IndexOfCard2beDiscarded >=0 && IndexOfCard2beDiscarded<= this.playerHand.Count)
            {
                Card discardedCard = this.playerHand[IndexOfCard2beDiscarded];
                this.playerHand.RemoveAt(IndexOfCard2beDiscarded);
                return discardedCard;
            }
            else
            {
                return null;
            }
        }

        public bool CheckGameOver()
        {
            //Sort Hand by value
            this.playerHand.OrderBy(x => x.val);
            int i = 0;
            if(
                //if values are eg.3,3,3
                ((this.playerHand[i].val == this.playerHand[i+1].val) 
                && (this.playerHand[i].val ==this.playerHand[i+2].val))
            || (//if values are eg:3,4,5
                ((this.playerHand[i].val+1) == this.playerHand[i+1].val) 
                && ((this.playerHand[i].val+2) ==this.playerHand[i+2].val))
                )
            {
                return true;
            }
             return false;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck mynewDeck = new Deck();
            mynewDeck.shuffle();
            //3-4 players 7 each
            //5-6 players it is 6 each
            //My plan is to play with two players first so the hand needs to be 10 each
            List<Card> user1Hand = new List<Card>();
            List<Card> user2Hand = new List<Card>();
            //trying with 3 so that we know when game will be over
            for (int i =0; i<3; i++)
            {
                 user1Hand.Add(mynewDeck.deal());
                 user2Hand.Add(mynewDeck.deal());
            }

            Player p1 = new Player("John",user1Hand);
            Player p2 = new Player("Oscar",user2Hand);


        }
    }
}
