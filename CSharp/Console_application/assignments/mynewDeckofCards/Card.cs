
using System;
using System.Collections.Generic;

namespace mynewDeckofCards
{
    public class Card
    {
    // Create a class called "Card"
    // Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
    // Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
    // Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.
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

}