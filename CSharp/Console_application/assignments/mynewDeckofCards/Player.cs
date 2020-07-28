
using System;
using System.Collections.Generic;
using System.Linq;

namespace mynewDeckofCards
{
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
            if(playerHand.Exists(x=>x.val==card_drawn.val)
            ||playerHand.Exists(x=>x.val==(card_drawn.val+1))
            ||playerHand.Exists(x=>x.val==(card_drawn.val-1)))
            {

                playerHand.Add(card_drawn);
            }
            else{
                fulldeck.discardPile.Add(card_drawn);
            }
            return card_drawn;
        }
        public Card discard(int IndexOfCard2beDiscarded)
        {
            if(IndexOfCard2beDiscarded >=0 && IndexOfCard2beDiscarded<= playerHand.Count)
            {
                Card discardedCard = playerHand[IndexOfCard2beDiscarded];
                playerHand.RemoveAt(IndexOfCard2beDiscarded);
                return discardedCard;
            }
            else
            {
                return null;
            }
        }
        public void ShowHand()
        {
            Console.WriteLine($"Player {playerName} cards : "+playerHand.Count);
            for(int i =0; i<playerHand.Count; i++)
            {
                Console.Write(playerHand[i].suit+" "+playerHand[i].stringVal+",");
            }
            Console.WriteLine();
        }
        public bool CheckGameOver()
        {
            //Sort Hand by value
            playerHand.OrderBy(x => x.val);
            int i = 0;
            if(
                //if values are eg.3,3,3
                ((playerHand[i].val == playerHand[i+1].val) 
                && (playerHand[i].val ==playerHand[i+2].val))
            || (//if values are eg:3,4,5
                ((playerHand[i].val+1) == playerHand[i+1].val) 
                && ((playerHand[i].val+2) ==playerHand[i+2].val))
                )
            {
                return true;
            }
             return false;

        }

    }
}