using System;

namespace Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck();
            create_deck(mydeck);
            bool quit = false;
            while(!quit) //Sets up a while loop that allows the user to repeatdly draw cards until either the deck is empty or they want to quit
            {
                Console.WriteLine("Would you like to \nShuffle-S \nDeal one card-D \nQuit-Q");
                string input = Convert.ToString(Console.ReadLine());
                if(input == "S")
                {
                    mydeck.Shuffle(); //If the user wants to shuffle, shuffle the cards
                }
                else if (input == "D")
                {
                    Card current_card = mydeck.Deal();
                    if (current_card == null) 
                    {

                        Console.WriteLine("Deck is empty");
                    }
                    else
                    {
                        current_card._print_values();
                    }
                }
                else if (input == "Q")
                {
                    quit = true;
                }
            }
            static void create_deck(Deck deck)//Creates the deck of 4 suits and 13 values per suit
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Card temp_card = new Card(j, i);
                        deck.card_list.Add(temp_card);

                    }
                }
            }


        }
    }
}
