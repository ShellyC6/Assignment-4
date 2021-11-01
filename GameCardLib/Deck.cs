using System;
//using System.Collections;

namespace GameCardLib
{
    public class Deck
    {
        ListManager<Card> cards;
        //Queue cards;

        public Deck() 
        {
            cards = new ListManager<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetAt(int position)
        {
            return cards.GetAt(position);
        }

        public void Shuffle()
        {
            cards.Shuffle();
        }

        public void AddAFullDeck()
        {
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    AddCard(new Card(suit, value));
                }
            }
        }

    }

}
