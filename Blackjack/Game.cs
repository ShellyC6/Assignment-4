using System;
using GameCardLib;

namespace Blackjack
{
    public class Game
    {
        int nbPlayers;
        int nbDecks;
        ListManager<Player> players;

        public Game(int _nbPlayers, int _nbDecks, ListManager<Player> _players)
        {
            nbPlayers = _nbPlayers;
            nbDecks = _nbDecks;
            players = _players;
        }

        public int NbPlayers
        {
            get { return nbPlayers; }
        }

        public int NbDecks
        {
            get { return nbDecks; }
        }
    }
}
