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

        public Player(string _name, bool _croupier)
        {
            name = _name;
            croupier = _croupier;
        }

        public string Name
        {
            get { return name; }
        }

        public bool Croupier
        {
            get { return croupier; }
        }

        public override string ToString()
        {
            string String = Name;
            if (Croupier)
                String += "\t" + "croupier";
            return String;
        }
    }
}
