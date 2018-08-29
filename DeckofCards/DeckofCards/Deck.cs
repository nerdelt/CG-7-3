using System;

namespace DeckofCards
{
    public class Deck
    {
        //creates new Random outside method to draw from
        public static Random draw = new Random();

        //creates new deck to fill with 52 cards
        public string[] newDeck = new string[52];

        //creates counter for loop
        public static int d;

        //create new card object to fill array with
        Card newCard = new Card();

        //method to fill deck with array from strings in card class
        public void FillDeck()
        {
            d = 0;
            //nested loop to fill array with full cards names. 4 suits, 13 ranks
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    newCard.CardName(j, i);
                    newDeck[d++] += newCard;
                }
            }
        }


        //method to draw random card
        public string CardDraw(string cardPick)
        {
            //other ways = newDeck[draw.Next(0,51)] or newDeck[draw.Next(0, newDeck.Length)]
            cardPick = newDeck[draw.Next(d)];
            return cardPick;
        }
    }
}

        
    


            

        
    













    //Card Class
    // method that gives you full name of card



