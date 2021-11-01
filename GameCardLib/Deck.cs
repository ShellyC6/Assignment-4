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

        public int Count()
        {
            return cards.Count();
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

        public void DeleteAt(int i)
        {
            cards.DeleteAt(i);
        }

        public Card PickACard()
        {
            Card card;
            if (cards.Count() > 0)
            {
                card = cards.GetAt(cards.Count() - 1);
                cards.DeleteAt(cards.Count() - 1);
            }
            else
                card = null;

            return card;
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

        public bool Find(Card card)
        {
            foreach(Card item in cards.M_list)
            {
                if (item.CardSuit == card.CardSuit && item.CardValue == card.CardValue)
                    return true;
            }

            return false;
        }
    }
}
