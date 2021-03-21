using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Player
    {
        private List<Card> hand = new List<Card>(); 

        private int totalValue = 0;
        
        public List<Card> getHand()
        {
            return this.hand;
        }

        public void setHand(List<Card> hand)
        {
            this.hand = hand;
        }

        public int getTotalValue()
        {
            // If there is an ace contained within the cards then we can calculate whether it is taken as an 11 or a 1
            bool ace = false;

            foreach(Card card in hand)
            {
                if (card.getValue() == 14)
                {
                    ace = true;
                }
                else
                {
                    totalValue += card.getValue();
                }
            }

            if (ace == true)
            {
                if (this.totalValue + 11 > 21)
                {
                    Console.WriteLine("The ace was taken as value 1 so you didn't go bust!");
                    totalValue += 1;

                }
                else
                {
                    Console.WriteLine("The ace was taken as value 11 as it helps the hand the most!");
                    totalValue += 11;
                }
            }

            return this.totalValue;
        }

        // Plater decides to "stand". This method means they take no new cards.
        public void stand()
        {
            Console.WriteLine("The player decided to stand. No new cards");
        }

        // Player decides to "hit". This method adds a card to their current hand. The argument being a card.
        public void hit(Card card)
        {
            // Appends the new card to the list.
            this.hand.Add(card);
        }
    }
}
