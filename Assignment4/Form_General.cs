using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blackjack;
using GameCardLib;

namespace Assignment4
{
    //public delegate void Action();

    public partial class Form_General : Form
    {
        Game game = null;
        /*Action action = null;  */
        bool buttonYes = false, buttonNo = false;

        public Form_General()
        {
            InitializeComponent();
            Initialise();
        }

        public void Initialise()
        {
            groupBox_Play.Visible = false;
            ClearTablePlayer(groupBox_CurrentPlayer, label_NameCurrentPlayer, label_ScoreCurrentPlayer);
            ClearTablePlayer(groupBox_OtherPlayer, label_NameOtherPlayer, label_ScoreOtherPlayer);
            label_EndOfGame.Visible = false;
        }

        private void DisplayPlayers()
        {
            listBox_Croupier.Items.Clear();
            listBox_Croupier.Items.Add(game.GetCroupier().ToStringScore());

            listBox_Winners.Items.Clear();
            foreach (Player winner in game.GetWinners().M_list)
                listBox_Winners.Items.Add(winner.ToStringScore());

            listBox_Losers.Items.Clear();
            foreach (Player loser in game.GetLosers().M_list)
                listBox_Losers.Items.Add(loser.ToStringScore());
        }

        private string getSelectedPlayer()
        {
            if (listBox_Croupier.SelectedIndex != -1)
                return game.GetCroupier().Name;
            if (listBox_Winners.SelectedIndex != -1) 
                return game.GetWinners().GetAt(listBox_Winners.SelectedIndex).Name;
            if (listBox_Losers.SelectedIndex != -1) 
                return game.GetLosers().GetAt(listBox_Losers.SelectedIndex).Name;

            return null;
        }

        private void DisplayTable()
        {
            if (game.CurrentPlayer != null)
                DisplayTablePlayer(game.GetPlayer(game.CurrentPlayer), groupBox_CurrentPlayer, label_NameCurrentPlayer, label_ScoreCurrentPlayer, listView_CurrentPlayer);
            if (getSelectedPlayer() != null)
                DisplayTablePlayer(game.GetPlayer(getSelectedPlayer()), groupBox_OtherPlayer, label_NameOtherPlayer, label_ScoreOtherPlayer, listView_OtherPlayer);
        }

        private void DisplayTablePlayer(Player player, GroupBox group, Label name, Label score, ListView cards)
        {
            if (player != null)
            {
                name.Text = player.ToString();
                score.Text = player.Score.ToString();

                cards.Items.Clear();
                foreach (Card card in player.Hand.Cards.M_list)
                    cards.Items.Add(card.ToString());

                group.Visible = true;
            }
        }

        private void ClearTablePlayer(GroupBox group, Label name, Label score)
        {
            name.Text = "Name of the player";
            score.Text = "Score";
            group.Visible = false;
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            Form_NewGame form = new Form_NewGame();
            form.ShowDialog();
            game = form.Game;

            if (game != null)
            {
                Initialise();
                game.BeginGame();
                DisplayPlayers();
                DisplayTable();
                groupBox_Play.Visible = true;
                game.EndOfGame += EndOfGame;
            }
            //Play();
        }

        private void Play()
        {
            game.BeginGame();
            DisplayPlayers();
            // Each player plays
            for(int i =0;i<game.NbPlayers;i++)
            {
                if(!game.GetPlayer(i).Croupier)
                {
                    game.CurrentPlayer = game.GetPlayer(i).Name;
                    DisplayTable();
                    groupBox_Play.Visible = true;
                    do
                    {
                        buttonNo = false; buttonYes = false;
                        while (!buttonYes && !buttonNo) { }
                    } while (!buttonNo);
                    groupBox_Play.Visible = false;
                }
            }
            // The croupier plays
            //game.Play(game.GetCroupier());
            game.CurrentPlayer = game.GetCroupier().Name;
            DisplayTable();
            groupBox_Play.Visible = true;
            buttonNo = false; buttonYes = false;
            groupBox_Play.Visible = false;
        }

        private void button_Shuffle_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Shuffle();
        }

        private void listBox_Croupier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Croupier.SelectedIndex != -1) 
            {
                listBox_Winners.ClearSelected();
                listBox_Losers.ClearSelected();

                DisplayTable();
            }
        }

        private void listBox_Winners_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Winners.SelectedIndex != -1) 
            {
                listBox_Croupier.ClearSelected();
                listBox_Losers.ClearSelected();

                DisplayTable();
            }
        }

        private void listBox_Losers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Losers.SelectedIndex != -1)
            {
                listBox_Croupier.ClearSelected();
                listBox_Winners.ClearSelected();

                DisplayTable();
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            game.Play();
            DisplayTable();
            DisplayPlayers();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            game.NextPlayer();
            DisplayTable();
            DisplayPlayers();
        }

        public string checkWinner()
        {
            if (listBox_Winners.Items.Count == 0 && game.GetCroupier().Score <= 21) 
                return "The croupier wins";
            return "The croupier loses";
        }

        public void EndOfGame(object sender, EventArgs e)
        {
            game.CheckAllWinners();
            DisplayPlayers();
            groupBox_Play.Visible = false;
            label_EndOfGame.Text = checkWinner();
            label_EndOfGame.Visible = true;
        }
    }
}
