using System;
using GameCardLib;

namespace Blackjack
{
    public class Game
    {
        public event EventHandler EndOfGame;

        int nbPlayers;
        int nbDecks;
        ListManager<Player> players;
        string currentPlayer;
        Player croupier;
        //bool endOfGame;

        Deck deck;

        public Game(int _nbPlayers, int _nbDecks, ListManager<Player> _players, Player _croupier)
        {
            nbPlayers = _nbPlayers;
            nbDecks = _nbDecks;
            players = _players;
            croupier = _croupier;
            //endOfGame = false;
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

        /*public bool EndOfGame
        {
            get { return endOfGame; }
        }*/

        public Player GetCroupier()
        {
            return croupier;
        }

        public ListManager<Player> GetWinners()
        {
            ListManager<Player> winners = new ListManager<Player>();

            foreach(Player player in players.M_list)
            {
                if (player.Winner)
                    winners.Add(player);
            }

            return winners;
        }

        public ListManager<Player> GetLosers()
        {
            ListManager<Player> losers = new ListManager<Player>();

            foreach (Player player in players.M_list)
            {
                if (!player.Winner)
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
            if (croupier.Name == name)
                return croupier;

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
            int i;
            foreach (Player player in players.M_list)
            {
                    for (i = 0; i < 2; i++)
                    {
                        PickACard(player);
                    }
            }
            PickACard(GetCroupier());

            Player firstPlayer;
            i = 0;
            do
            {
                firstPlayer = GetPlayer(i);
                i++;
            } while (firstPlayer.Croupier);
            currentPlayer = firstPlayer.Name;
        }

        public void NextPlayer()
        {
            int i;
            for (i = 0; i < players.Count(); i++) 
            {
                if (players.GetAt(i).Name == currentPlayer)
                    break;  
            }
            i++;

            if (i < players.Count())
                currentPlayer = players.GetAt(i + 1).Name;
            else if (i == players.Count())
                currentPlayer = GetCroupier().Name;
            else if (i > players.Count())
                EndOfGame?.Invoke(this, EventArgs.Empty);
        }

        public void Play()
        {
            PickACard(GetPlayer(currentPlayer));
            isWinner(GetPlayer(currentPlayer));
        }

        public void Stand()
        {

        }

        private void PickACard(Player player)
        {
            int j = 1;
            while (player.Find(deck.GetAt(deck.Count() - j)) && j<deck.Count()) { j++; }
            player.AddACard(deck.GetAt(deck.Count() - j));
            deck.DeleteAt(deck.Count() - j);
        }

        public void isWinner(Player player)
        {
            if(!player.Croupier)
            {
                if (player.Score > 21 || player.Score < croupier.Score)
                    player.Winner = false;
                else
                    player.Winner = true;
            }
        }
    }
}
