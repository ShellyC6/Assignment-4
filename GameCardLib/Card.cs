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
        int id;

        public Card(Suit _suit, Value _value)
        {
            cardSuit = _suit;
            cardValue = _value;
            id = (int)cardValue + 13 * (int)cardSuit - 1;
        }

        public int Id
        {
            get { return id; }
        }

        public Suit CardSuit
        {
            get { return cardSuit; }
        }

        public Value CardValue
        {
            get { return cardValue; }
        }

        public override string ToString()
        {
            return cardValue.ToString() + " of " + cardSuit.ToString();
        }

        public string GetNameImage()
        {
            string name = "";

            switch(cardValue)
            {
                case Value.ace:
                    name = "A";
                    break;
                case Value.two:
                    name = "2";
                    break;
                case Value.three:
                    name = "3";
                    break;
                case Value.four:
                    name = "4";
                    break;
                case Value.five:
                    name = "5";
                    break;
                case Value.six:
                    name = "6";
                    break;
                case Value.seven:
                    name = "7";
                    break;
                case Value.eight:
                    name = "8";
                    break;
                case Value.nine:
                    name = "9";
                    break;
                case Value.ten:
                    name = "10";
                    break;
                case Value.jack:
                    name = "J";
                    break;
                case Value.queen:
                    name = "Q";
                    break;
                case Value.king:
                    name = "K";
                    break;
            }

            name += cardSuit.ToString()[0];

            return name;
        }
    }
}
