﻿using System;
using GameCardLib;

namespace Blackjack
{
    public class Game
    {
        public event EventHandler EndOfGame;
        public event EventHandler PlayComputer;
        public event EventHandler PlayClassic;

        int nbPlayers;
        int nbDecks;
        ListManager<Player> players;
        string currentPlayer;
        Player croupier;
        Deck deck;

        public Game(int _nbPlayers, int _nbDecks, ListManager<Player> _players, Player _croupier)
        {
            nbPlayers = _nbPlayers;
            nbDecks = _nbDecks;
            players = _players;
            croupier = _croupier;
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

            CheckAllWinners();

            currentPlayer = GetPlayer(0).Name;

            TypeOfPlayer();
        }

        public void NextPlayer()
        {
            // find the current player
            int i;
            for (i = 0; i < players.Count(); i++) 
            {
                if (players.GetAt(i).Name == currentPlayer)
                    break;  
            }
            i++;

            // find the next player if there is one
            if (i < players.Count())
                currentPlayer = players.GetAt(i).Name;
            else if (i == players.Count())
                currentPlayer = GetCroupier().Name;
            else if (i > players.Count())
                EndOfGame?.Invoke(this, EventArgs.Empty);

            TypeOfPlayer();
        }

        void TypeOfPlayer()
        {
            // check if the current player is a computer
            if (GetPlayer(currentPlayer) is ComputerPlayer)
                PlayComputer?.Invoke(this, EventArgs.Empty);
            else
                PlayClassic?.Invoke(this, EventArgs.Empty);
        }

        public void Play()
        {
            PickACard(GetPlayer(currentPlayer));
            isWinner(GetPlayer(currentPlayer));
        }

        private void PickACard(Player player)
        {
            int j = 1;
            while (player.Find(deck.GetAt(deck.Count() - j)) && j<deck.Count()) { j++; }
            if(j>=deck.Count())
            {
                deck.AddAFullDeck();
                Shuffle();
                j = 1;
                while (player.Find(deck.GetAt(deck.Count() - j)) && j < deck.Count()) { j++; }
            }

            player.AddACard(deck.GetAt(deck.Count() - j));
            deck.DeleteAt(deck.Count() - j);

            if (deck.Count() == 0)
            {
                deck.AddAFullDeck();
                Shuffle();
            }
        }

        public void isWinner(Player player)
        {
            if(!player.Croupier)
            {
                if ((croupier.Score <= 21 && player.Score <= croupier.Score) || player.Score > 21)
                    player.Winner = false;
                else
                    player.Winner = true;
            }
        }

        public void CheckAllWinners()
        {
            for (int i = 0; i < players.Count(); i++) 
            {
                isWinner(players.GetAt(i));
            }
        }
    }
}
