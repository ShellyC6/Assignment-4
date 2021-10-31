using System;
using GameCardLib;

namespace Blackjack
{
    public class Game
    {
        int nbPlayers;
        int nbDecks;
        ListManager<Player> players;

        public int NbPlayers
        {
            get { return nbPlayers; }
        }

        public int NbDecks
        {
            get { return nbDecks; }
        }

        public Game(int _nbPlayers, int _nbDecks)
        {
            nbPlayers = _nbPlayers;
            nbDecks = _nbDecks;
        }
    }
}
