using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    // delegate

    public partial class Form_NewCard : Form
    {
        bool newCard;

        public Form_NewCard()
        {
            InitializeComponent();
        }

        public bool GetNewCard()
        {
            return newCard;
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            newCard = true;
            Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            newCard = false;
            Close();
        }
    }
}
