using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        Hand hand;
        string name;
        bool croupier;
        int score;
        bool winner;

        public Player(string _name, bool _croupier)
        {
            name = _name;
            croupier = _croupier;
            score = 0;
            winner = false;
        }

        public string Name
        {
            get { return name; }
        }

        public bool Croupier
        {
            get { return croupier; }
        }

        public int Score
        {
            get { return score; }
            set { if (value > 0) score = value; }
        }

        public bool Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public override string ToString()
        {
            string String = Name;
            if (Croupier)
                String += "\t" + "(croupier)";
            else
                String += "\t" + "(player)";

            return String;
        }

        public string ToStringScore()
        {
            return Name + "\t" + Score;
        }
    }
}
