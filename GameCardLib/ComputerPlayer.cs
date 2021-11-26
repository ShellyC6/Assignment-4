using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string _name, bool _croupier)
            : base(_name, _croupier)
        { }

        public override string ToString()
        {
            return base.ToString() + "  -> computer";
        }

        public override string ToStringScore()
        {
            return base.ToStringScore() + "    -> computer";
        }

    }
}
