using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 Suits and 14 values for each suit. 4 * 14 = 56. Therefore an array that contains 56 card objects.
            List<Card> deckOfCards = new List<Card>();

            // Iterates over every enum suit value.
            foreach(Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                // Iterate from 1 to 14.
                for(int i = 1; i < 15; i++)
                {
                    deckOfCards.Add(new Card(i, suit));
                }
            }

            foreach(Card card in deckOfCards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
