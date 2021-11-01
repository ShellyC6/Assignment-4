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
using UtilitiesLib;

namespace Assignment4
{
    public partial class Form_NewGame : Form
    {
        ListManager<Player> players;
        Game game = null;

        public Form_NewGame()
        {
            InitializeComponent();
            players = new ListManager<Player>();
        }

        public Game Game
        {
            get { return game; }
        }

        private void DisplayPlayers()
        {
            listBox_Players.Items.Clear();
            foreach (Player player in players.M_list)
            {
                listBox_Players.Items.Add(player.ToString());
            }
        }

        private bool ValidateInputGame()
        {
            bool croupier=false, player = false;
            for (int i = 0; i < players.Count(); i++) 
            {
                if (players.GetAt(i).Croupier)
                    croupier = true;
                else
                    player = true;
            }

            if(!croupier)
            {
                MessageBox.Show("You need a croupier to play");
                return false;
            }
            if(!player)
            {
                MessageBox.Show("You need at least one player");
                return false;
            }

            int number;
            if (Int32.TryParse(textBox_NbDecks.Text, out number) == false)
            {
                MessageBox.Show("You need at least one deck");
                return false;
            }
            if (number <= 0)
            {
                MessageBox.Show("You need at least one deck");
                return false;
            }

            return true;
        }

        private void button_StartGame_Click(object sender, EventArgs e)
        {
            if(ValidateInputGame())
            {
                int number;
                Int32.TryParse(textBox_NbDecks.Text, out number);
                game = new Game(players.Count(), number, players);
                Close();
            }
        }

        private bool ValidateInputPlayer()
        {
            for (int i = 0; i < players.Count(); i++)
            {
                // Search if the name exists
                if (players.GetAt(i).Name == textBox_NameNewPlayer.Text)
                {
                    MessageBox.Show("This name is already used by another player");
                    return false;
                }
                // Search if there is more than one croupier
                if(checkBox_Croupier.Checked && players.GetAt(i).Croupier)
                {
                    MessageBox.Show("There is already a croupier");
                    return false;
                }
            }

            return true;
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            // Add the new player if it doesn't exist already
            if (ValidateInputPlayer())
                players.Add(new Player(textBox_NameNewPlayer.Text, checkBox_Croupier.Checked));

            // Display the players
            DisplayPlayers();
            textBox_NameNewPlayer.Clear();
            checkBox_Computer.Checked = false;
            checkBox_Croupier.Checked = false;
        }
    }
}
