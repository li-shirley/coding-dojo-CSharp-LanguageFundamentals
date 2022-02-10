namespace DeckOfCards
{
    public class Card
    {
        public string CardFace {get;set;}

        public string Suit {get;set;}

        public int Value {get;set;}

        public Card(string cardFace, string suit, int value)
        {
            CardFace = cardFace;
            Suit = suit;
            Value = value;
        }

    }
}