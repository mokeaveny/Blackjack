using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Card
    {
        // The value of the card. This will be 1 - 10 for numbered cards.
        // 11 - Jack, 12 - Queen, 13 - King, 14 - Ace
        private int value;
        private Suit suit;
        public enum Suit
        {
            Clubs, Spades, Hearts, Diamonds
        }

        public int getValue()
        {
            return this.value;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public Suit getSuit()
        {
            return this.suit;
        }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            string output = "";
            if (value > 10)
            {
                switch (value)
                {
                    case 11:
                        output += "Value: Jack";
                        break;
                    case 12:
                        output += "Value: Queen";
                        break;
                    case 13:
                        output += "Value: King";
                        break;
                    case 14:
                        output += "Value: Ace";
                        break;
                }
            }
            else
            {
                output += "Value: " + value.ToString();
            }

            output += " Suit: " + this.getSuit().ToString();

            return output;
        }
    }
}
