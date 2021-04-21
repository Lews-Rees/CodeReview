﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Card
    {
        private int _value { get; set; }
        private string _suit { get; set; }
        private int _suit_int { get; set; }
        private string _string_value { get; set; }
        public Card(int value, int suit_int)
        {
            _value = value + 1;
            _suit_int = suit_int;
            _StringValue(value, suit_int);
        }
        private void _StringValue(int value, int suit_value)
        {
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" }; //List of card suits
            string[] string_values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" }; //List of card values
            _string_value = string_values[value];
            _suit = suits[suit_value];
        }
        public void _print_values()
        {
            Console.WriteLine(_string_value + " Of " + _suit); //Prints the card values
        }
    }







}

