using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards {get;set;} = new List<Card>();

        public Deck()
        {
            Reset();
        }
        public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card topMost = cards[cards.Count-1];
                cards.RemoveAt(cards.Count-1);
                return topMost;
            }
            return null;
        }
        public Deck Reset()
        {
            cards = new List<Card>();
            
            string[] suits =
            {
                "Spades",
                "Hearts",
                "Clubs",
                "Diamonds"
            };
            Dictionary<int,string> faceCardNames = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"},
            };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    string cardFace = i.ToString();
                    // if (cardFace == "1" )
                    // {
                    //     cardFace = "Ace";
                    // }
                    // if (cardFace == "11" )
                    // {
                    //     cardFace = "Jack";
                    // }
                    // if (cardFace == "12" )
                    // {
                    //     cardFace = "Queen";
                    // }
                    // if (cardFace == "13" )
                    // {
                    //     cardFace = "King";
                    // }
                    // Code not very dry, Neal's way:
                    if (faceCardNames.ContainsKey(i))
                    {
                        cardFace = faceCardNames[i];
                    }
                    Card card = new Card (cardFace, suit, i);
                    cards.Add(card);
                }
            }
            return this;
        }
        public Deck Shuffle()
        {
            Random spot = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int randomSpot = spot.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomSpot];
                cards[randomSpot] = temp;
            }
            return this;
        }
        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine($@"{card.CardFace} {card.Suit} {card.Value}");
            }
        }
    }
}