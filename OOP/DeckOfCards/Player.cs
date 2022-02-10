using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name {get;set;}
        public List<Card> Hand {get;set;} = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card DrawCard(Deck deck)
        {
            Card card = deck.Deal();
            if (card != null)
            {
                Hand.Add(card);
            }
            return card;
        }

        public Card DiscardCard(int val)
        {
            if (val < 0 || val >= Hand.Count)
            {
                return null;
            }
            Card card = Hand[val];
            Hand.RemoveAt(val);
            return card;
        }
    }
}