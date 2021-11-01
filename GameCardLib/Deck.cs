using System;

namespace GameCardLib
{
    public class Deck
    {
        ListManager<Card> cards;

        public Deck() { }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetAt(int position)
        {
            return cards.GetAt(position);
        }

    }

}
