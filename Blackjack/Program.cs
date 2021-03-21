using System;
using System.Linq;
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

            Player p1 = new Player();

            // Get a random card from the deck
            Random r = new Random();
            int rand = r.Next(0, deckOfCards.Count);
            Card firstCard = deckOfCards.ElementAt(rand);
            deckOfCards.RemoveAt(rand);
            Console.WriteLine(deckOfCards.Count);
            p1.getHand().Add(firstCard);

            //Get another random card from the deck
            rand = r.Next(0, deckOfCards.Count);
            Card secondCard = deckOfCards.ElementAt(rand);
            deckOfCards.RemoveAt(rand);
            Console.WriteLine(deckOfCards.Count);
            p1.getHand().Add(secondCard);

            foreach(Card card in p1.getHand())
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine(p1.getTotalValue());


        }
    }
}
