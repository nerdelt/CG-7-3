using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {

            //asks for user input
            Console.Write("Pick a card, any card...\n\nTo pick, please type PICK: ");
            string c = Console.ReadLine();

            //create new deck object
            Deck newDeck = new Deck();
            newDeck.FillDeck();

            //draw random card and display value
            Console.WriteLine($"\nYour card is: {newDeck.CardDraw(c)}!");
            Console.ReadLine();         
        }
    }

    class Deck
    {
        //creates new Random outside method to draw from
        public static Random draw;

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
            draw = new Random();
            cardPick = newDeck[draw.Next(d)];
            return cardPick;
        }
    }
 
    class Card
    {
        //creates int rank and suit to make full card name
        public int rank { get; set; }
        public int suit { get; set; }

        //creates full card name with int
        public void CardName(int cardRank, int cardSuit)
        {
            rank = cardRank;
            suit = cardSuit;
        }

        //changes cardName int to string and returns full name 
        public override string ToString()
        {
            string[] ranks = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

            return string.Format($"{ranks[rank]} of {suits[suit]}");
        }
    }
}

        
    


            

        
    













    //Card Class
    // method that gives you full name of card



