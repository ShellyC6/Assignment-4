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

        public string Name
        {
            get { return name; }
        }

        public Player(string _name)
        {
            name = _name;
        }
    }
}
