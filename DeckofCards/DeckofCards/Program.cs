using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {

            //asks for user input
            Console.Write("Pick a card, any card...\n" +
                "\nTo pick, please type PICK: ");
            string c = Console.ReadLine();

            //create new deck object
            Deck newDeck = new Deck();
            newDeck.FillDeck();

            //draw random card and display value
            Console.WriteLine($"\nYour card is: {newDeck.CardDraw(c)}!");
            Console.ReadLine();         
        }
    }
}

        
    


            

        
    













    //Card Class
    // method that gives you full name of card



