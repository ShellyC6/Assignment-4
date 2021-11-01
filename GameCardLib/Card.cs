using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Card
    {
        Suit cardSuit;
        Value cardValue;

        public Card(Suit _suit, Value _value)
        {
            cardSuit = _suit;
            cardValue = _value;
        }

        public Suit CardSuit
        {
            get { return cardSuit; }
        }

        public Value CardValue
        {
            get { return cardValue; }
        }
    }
}
