using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10CardLib
{
    public class Card
    {
        public Rank rank;
        public Suit suit;

        public Card(Suit newSuit, Rank newRank)
        {
            this.rank = newRank;
            this.suit = newSuit;
        }

        public Card()
        {
        }

        public string ToString()
        {
            return "The " + rank + " of " + suit + " s";
        }
    }
}