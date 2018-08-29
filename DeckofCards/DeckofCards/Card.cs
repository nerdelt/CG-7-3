namespace DeckofCards
{
    public class Card
    {
        //creates int rank and suit to make full card name
         private int rank { get; set; }
         private int suit { get; set; }

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



