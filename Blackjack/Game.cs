using System;
using GameCardLib;

namespace Blackjack
{
    public class Game
    {
        int nbPlayers;
        int nbDecks;
        ListManager<Player> players;
        string currentPlayer;

        Deck deck;

        public Game(int _nbPlayers, int _nbDecks, ListManager<Player> _players)
        {
            nbPlayers = _nbPlayers;
            nbDecks = _nbDecks;
            players = _players;
            deck = new Deck();
            InitialiseDeck();
        }

        public int NbPlayers
        {
            get { return nbPlayers; }
        }

        public int NbDecks
        {
            get { return nbDecks; }
        }

        public string CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public Player GetCroupier()
        {
            foreach(Player player in players.M_list)
            {
                if (player.Croupier)
                    return player;
            }
            return null;
        }

        public ListManager<Player> GetWinners()
        {
            ListManager<Player> winners = new ListManager<Player>();

            foreach(Player player in players.M_list)
            {
                if (!player.Croupier && player.Winner)
                    winners.Add(player);
            }

            return winners;
        }

        public ListManager<Player> GetLosers()
        {
            ListManager<Player> losers = new ListManager<Player>();

            foreach (Player player in players.M_list)
            {
                if (!player.Croupier && !player.Winner)
                    losers.Add(player);
            }

            return losers;
        }

        public Player GetPlayer(string name)
        {
            foreach (Player player in players.M_list)
            {
                if (player.Name == name)
                    return player;
            }
            return null;
        }

        public Player GetPlayer(int i)
        {
            if (i >= 0 && i < nbPlayers)
                return players.M_list[i];

            return null;
        }

        public void Shuffle()
        {
            deck.Shuffle();
        }

        private void InitialiseDeck()
        {
            for (int i = 0; i < nbDecks; i++) 
            {
                deck.AddAFullDeck();
            }
            Shuffle();
        }

        public void BeginGame()
        {
            foreach (Player player in players.M_list)
            {
                if(!player.Croupier)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int j = 1;
                        while (player.Find(deck.GetAt(deck.Count() - j))) { j--; }
                        player.AddACard(deck.GetAt(deck.Count() - j));
                        deck.DeleteAt(deck.Count() - j);
                    }
                }
                else
                {
                    int j = 1;
                    while (player.Find(deck.GetAt(deck.Count() - j))) { j--; }
                    player.AddACard(deck.GetAt(deck.Count() - j));
                    deck.DeleteAt(deck.Count() - j);
                }
            }
        }

        public void Play(Player player)
        {
            CurrentPlayer = player.Name;


        }
    }
}
