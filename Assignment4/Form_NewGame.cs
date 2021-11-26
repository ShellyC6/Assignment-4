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
        Player croupier;
        Game game = null;

        public Form_NewGame()
        {
            InitializeComponent();
            players = new ListManager<Player>();
            croupier = null;
        }

        public Game Game
        {
            get { return game; }
        }

        private void DisplayPlayers()
        {
            listBox_Players.Items.Clear();
            if (croupier != null) { listBox_Players.Items.Add(croupier.ToString()); }
            foreach (Player player in players.M_list)
            {
                listBox_Players.Items.Add(player.ToString());
            }
        }

        private bool ValidateInputGame()
        {
            if (croupier == null) 
            {
                MessageBox.Show("You need a croupier to play");
                return false;
            }
            if(players.Count()==0)
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
                game = new Game(players.Count(), number, players, croupier);
                Close();
            }
        }

        private bool ValidateInputPlayer()
        {
            if(textBox_NameNewPlayer.Text=="")
            {
                MessageBox.Show("The new player needs a name");
                return false;
            }

            // Search if the name exists
            if(croupier!= null && croupier.Name == textBox_NameNewPlayer.Text)
            {
                MessageBox.Show("This name is already used by another player");
                return false;
            }
            for (int i = 0; i < players.Count(); i++)
            {
                if (players.GetAt(i).Name == textBox_NameNewPlayer.Text)
                {
                    MessageBox.Show("This name is already used by another player");
                    return false;
                }
            }

            // Search if there is more than one croupier
            if (checkBox_Croupier.Checked && croupier != null) 
            {
                MessageBox.Show("There is already a croupier");
                return false;
            }

            return true;
        }

        private Player AddPlayer()
        {
            if (checkBox_Computer.Checked)
                return new ComputerPlayer(textBox_NameNewPlayer.Text, checkBox_Croupier.Checked);
            else
                return new Player(textBox_NameNewPlayer.Text, checkBox_Croupier.Checked);
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            // Add the new player if it doesn't exist already
            if (ValidateInputPlayer())
            {
                if (checkBox_Croupier.Checked)
                    croupier = AddPlayer();
                else
                    players.Add(AddPlayer());
            }

            // Display the players
            DisplayPlayers();
            textBox_NameNewPlayer.Clear();
            checkBox_Computer.Checked = false;
            checkBox_Croupier.Checked = false;
        }
    }
}
