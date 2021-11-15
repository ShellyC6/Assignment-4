
namespace Assignment4
{
    partial class Form_General
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.button_Shuffle = new System.Windows.Forms.Button();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.listBox_Croupier = new System.Windows.Forms.ListBox();
            this.groupBox_Table = new System.Windows.Forms.GroupBox();
            this.label_EndOfGame = new System.Windows.Forms.Label();
            this.groupBox_Play = new System.Windows.Forms.GroupBox();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.groupBox_OtherPlayer = new System.Windows.Forms.GroupBox();
            this.listView_OtherPlayer = new System.Windows.Forms.ListView();
            this.label_ScoreOtherPlayer = new System.Windows.Forms.Label();
            this.label_NameOtherPlayer = new System.Windows.Forms.Label();
            this.groupBox_CurrentPlayer = new System.Windows.Forms.GroupBox();
            this.listView_CurrentPlayer = new System.Windows.Forms.ListView();
            this.label_ScoreCurrentPlayer = new System.Windows.Forms.Label();
            this.label_NameCurrentPlayer = new System.Windows.Forms.Label();
            this.label_Croupier = new System.Windows.Forms.Label();
            this.label_Losers = new System.Windows.Forms.Label();
            this.listBox_Losers = new System.Windows.Forms.ListBox();
            this.label_Winners = new System.Windows.Forms.Label();
            this.listBox_Winners = new System.Windows.Forms.ListBox();
            this.groupBox_Menu.SuspendLayout();
            this.groupBox_Table.SuspendLayout();
            this.groupBox_Play.SuspendLayout();
            this.groupBox_OtherPlayer.SuspendLayout();
            this.groupBox_CurrentPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.button_Shuffle);
            this.groupBox_Menu.Controls.Add(this.button_NewGame);
            this.groupBox_Menu.Location = new System.Drawing.Point(1130, 12);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(195, 632);
            this.groupBox_Menu.TabIndex = 0;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "Menu";
            // 
            // button_Shuffle
            // 
            this.button_Shuffle.Location = new System.Drawing.Point(18, 91);
            this.button_Shuffle.Name = "button_Shuffle";
            this.button_Shuffle.Size = new System.Drawing.Size(151, 40);
            this.button_Shuffle.TabIndex = 1;
            this.button_Shuffle.Text = "Shuffle the cards";
            this.button_Shuffle.UseVisualStyleBackColor = true;
            this.button_Shuffle.Click += new System.EventHandler(this.button_Shuffle_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.Location = new System.Drawing.Point(18, 35);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(151, 39);
            this.button_NewGame.TabIndex = 0;
            this.button_NewGame.Text = "New game";
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // listBox_Croupier
            // 
            this.listBox_Croupier.FormattingEnabled = true;
            this.listBox_Croupier.ItemHeight = 20;
            this.listBox_Croupier.Location = new System.Drawing.Point(887, 70);
            this.listBox_Croupier.Name = "listBox_Croupier";
            this.listBox_Croupier.Size = new System.Drawing.Size(237, 44);
            this.listBox_Croupier.TabIndex = 1;
            this.listBox_Croupier.SelectedIndexChanged += new System.EventHandler(this.listBox_Croupier_SelectedIndexChanged);
            // 
            // groupBox_Table
            // 
            this.groupBox_Table.Controls.Add(this.label_EndOfGame);
            this.groupBox_Table.Controls.Add(this.groupBox_Play);
            this.groupBox_Table.Controls.Add(this.groupBox_OtherPlayer);
            this.groupBox_Table.Controls.Add(this.groupBox_CurrentPlayer);
            this.groupBox_Table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Table.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Table.Name = "groupBox_Table";
            this.groupBox_Table.Size = new System.Drawing.Size(869, 632);
            this.groupBox_Table.TabIndex = 2;
            this.groupBox_Table.TabStop = false;
            this.groupBox_Table.Text = "Table";
            // 
            // label_EndOfGame
            // 
            this.label_EndOfGame.AutoSize = true;
            this.label_EndOfGame.Font = new System.Drawing.Font("Verdana Pro Cond Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EndOfGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_EndOfGame.Location = new System.Drawing.Point(538, 540);
            this.label_EndOfGame.Name = "label_EndOfGame";
            this.label_EndOfGame.Size = new System.Drawing.Size(96, 31);
            this.label_EndOfGame.TabIndex = 3;
            this.label_EndOfGame.Text = "Winner";
            this.label_EndOfGame.Visible = false;
            // 
            // groupBox_Play
            // 
            this.groupBox_Play.Controls.Add(this.button_No);
            this.groupBox_Play.Controls.Add(this.button_Yes);
            this.groupBox_Play.Location = new System.Drawing.Point(18, 493);
            this.groupBox_Play.Name = "groupBox_Play";
            this.groupBox_Play.Size = new System.Drawing.Size(408, 120);
            this.groupBox_Play.TabIndex = 2;
            this.groupBox_Play.TabStop = false;
            this.groupBox_Play.Text = "Do you want to take an other card?";
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(229, 31);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(77, 69);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(85, 31);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(77, 69);
            this.button_Yes.TabIndex = 0;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // groupBox_OtherPlayer
            // 
            this.groupBox_OtherPlayer.Controls.Add(this.listView_OtherPlayer);
            this.groupBox_OtherPlayer.Controls.Add(this.label_ScoreOtherPlayer);
            this.groupBox_OtherPlayer.Controls.Add(this.label_NameOtherPlayer);
            this.groupBox_OtherPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_OtherPlayer.Location = new System.Drawing.Point(446, 35);
            this.groupBox_OtherPlayer.Name = "groupBox_OtherPlayer";
            this.groupBox_OtherPlayer.Size = new System.Drawing.Size(405, 436);
            this.groupBox_OtherPlayer.TabIndex = 1;
            this.groupBox_OtherPlayer.TabStop = false;
            this.groupBox_OtherPlayer.Text = "Other player";
            // 
            // listView_OtherPlayer
            // 
            this.listView_OtherPlayer.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_OtherPlayer.HideSelection = false;
            this.listView_OtherPlayer.Location = new System.Drawing.Point(16, 91);
            this.listView_OtherPlayer.Name = "listView_OtherPlayer";
            this.listView_OtherPlayer.Size = new System.Drawing.Size(373, 325);
            this.listView_OtherPlayer.TabIndex = 3;
            this.listView_OtherPlayer.UseCompatibleStateImageBehavior = false;
            // 
            // label_ScoreOtherPlayer
            // 
            this.label_ScoreOtherPlayer.AutoSize = true;
            this.label_ScoreOtherPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ScoreOtherPlayer.Location = new System.Drawing.Point(299, 40);
            this.label_ScoreOtherPlayer.Name = "label_ScoreOtherPlayer";
            this.label_ScoreOtherPlayer.Size = new System.Drawing.Size(52, 23);
            this.label_ScoreOtherPlayer.TabIndex = 3;
            this.label_ScoreOtherPlayer.Text = "Score";
            // 
            // label_NameOtherPlayer
            // 
            this.label_NameOtherPlayer.AutoSize = true;
            this.label_NameOtherPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NameOtherPlayer.Location = new System.Drawing.Point(16, 40);
            this.label_NameOtherPlayer.Name = "label_NameOtherPlayer";
            this.label_NameOtherPlayer.Size = new System.Drawing.Size(203, 23);
            this.label_NameOtherPlayer.TabIndex = 2;
            this.label_NameOtherPlayer.Text = "Name of the other player";
            // 
            // groupBox_CurrentPlayer
            // 
            this.groupBox_CurrentPlayer.Controls.Add(this.listView_CurrentPlayer);
            this.groupBox_CurrentPlayer.Controls.Add(this.label_ScoreCurrentPlayer);
            this.groupBox_CurrentPlayer.Controls.Add(this.label_NameCurrentPlayer);
            this.groupBox_CurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_CurrentPlayer.Location = new System.Drawing.Point(18, 35);
            this.groupBox_CurrentPlayer.Name = "groupBox_CurrentPlayer";
            this.groupBox_CurrentPlayer.Size = new System.Drawing.Size(408, 436);
            this.groupBox_CurrentPlayer.TabIndex = 0;
            this.groupBox_CurrentPlayer.TabStop = false;
            this.groupBox_CurrentPlayer.Text = "Current player";
            // 
            // listView_CurrentPlayer
            // 
            this.listView_CurrentPlayer.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_CurrentPlayer.HideSelection = false;
            this.listView_CurrentPlayer.Location = new System.Drawing.Point(16, 91);
            this.listView_CurrentPlayer.Name = "listView_CurrentPlayer";
            this.listView_CurrentPlayer.Size = new System.Drawing.Size(373, 325);
            this.listView_CurrentPlayer.TabIndex = 2;
            this.listView_CurrentPlayer.UseCompatibleStateImageBehavior = false;
            // 
            // label_ScoreCurrentPlayer
            // 
            this.label_ScoreCurrentPlayer.AutoSize = true;
            this.label_ScoreCurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ScoreCurrentPlayer.Location = new System.Drawing.Point(299, 40);
            this.label_ScoreCurrentPlayer.Name = "label_ScoreCurrentPlayer";
            this.label_ScoreCurrentPlayer.Size = new System.Drawing.Size(52, 23);
            this.label_ScoreCurrentPlayer.TabIndex = 1;
            this.label_ScoreCurrentPlayer.Text = "Score";
            // 
            // label_NameCurrentPlayer
            // 
            this.label_NameCurrentPlayer.AutoSize = true;
            this.label_NameCurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NameCurrentPlayer.Location = new System.Drawing.Point(16, 40);
            this.label_NameCurrentPlayer.Name = "label_NameCurrentPlayer";
            this.label_NameCurrentPlayer.Size = new System.Drawing.Size(217, 23);
            this.label_NameCurrentPlayer.TabIndex = 0;
            this.label_NameCurrentPlayer.Text = "Name of the current player";
            // 
            // label_Croupier
            // 
            this.label_Croupier.AutoSize = true;
            this.label_Croupier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Croupier.Location = new System.Drawing.Point(887, 35);
            this.label_Croupier.Name = "label_Croupier";
            this.label_Croupier.Size = new System.Drawing.Size(88, 28);
            this.label_Croupier.TabIndex = 3;
            this.label_Croupier.Text = "Croupier";
            // 
            // label_Losers
            // 
            this.label_Losers.AutoSize = true;
            this.label_Losers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Losers.Location = new System.Drawing.Point(887, 405);
            this.label_Losers.Name = "label_Losers";
            this.label_Losers.Size = new System.Drawing.Size(66, 28);
            this.label_Losers.TabIndex = 5;
            this.label_Losers.Text = "Losers";
            // 
            // listBox_Losers
            // 
            this.listBox_Losers.FormattingEnabled = true;
            this.listBox_Losers.ItemHeight = 20;
            this.listBox_Losers.Location = new System.Drawing.Point(887, 440);
            this.listBox_Losers.Name = "listBox_Losers";
            this.listBox_Losers.Size = new System.Drawing.Size(237, 204);
            this.listBox_Losers.TabIndex = 4;
            this.listBox_Losers.SelectedIndexChanged += new System.EventHandler(this.listBox_Losers_SelectedIndexChanged);
            // 
            // label_Winners
            // 
            this.label_Winners.AutoSize = true;
            this.label_Winners.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Winners.Location = new System.Drawing.Point(887, 147);
            this.label_Winners.Name = "label_Winners";
            this.label_Winners.Size = new System.Drawing.Size(83, 28);
            this.label_Winners.TabIndex = 7;
            this.label_Winners.Text = "Winners";
            // 
            // listBox_Winners
            // 
            this.listBox_Winners.FormattingEnabled = true;
            this.listBox_Winners.ItemHeight = 20;
            this.listBox_Winners.Location = new System.Drawing.Point(887, 182);
            this.listBox_Winners.Name = "listBox_Winners";
            this.listBox_Winners.Size = new System.Drawing.Size(237, 204);
            this.listBox_Winners.TabIndex = 6;
            this.listBox_Winners.SelectedIndexChanged += new System.EventHandler(this.listBox_Winners_SelectedIndexChanged);
            // 
            // Form_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 656);
            this.Controls.Add(this.label_Winners);
            this.Controls.Add(this.listBox_Winners);
            this.Controls.Add(this.label_Losers);
            this.Controls.Add(this.listBox_Losers);
            this.Controls.Add(this.label_Croupier);
            this.Controls.Add(this.groupBox_Table);
            this.Controls.Add(this.listBox_Croupier);
            this.Controls.Add(this.groupBox_Menu);
            this.Name = "Form_General";
            this.Text = "Form1";
            this.groupBox_Menu.ResumeLayout(false);
            this.groupBox_Table.ResumeLayout(false);
            this.groupBox_Table.PerformLayout();
            this.groupBox_Play.ResumeLayout(false);
            this.groupBox_OtherPlayer.ResumeLayout(false);
            this.groupBox_OtherPlayer.PerformLayout();
            this.groupBox_CurrentPlayer.ResumeLayout(false);
            this.groupBox_CurrentPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.ListBox listBox_Croupier;
        private System.Windows.Forms.GroupBox groupBox_Table;
        private System.Windows.Forms.Label label_Croupier;
        private System.Windows.Forms.Label label_Losers;
        private System.Windows.Forms.ListBox listBox_Losers;
        private System.Windows.Forms.Label label_Winners;
        private System.Windows.Forms.ListBox listBox_Winners;
        private System.Windows.Forms.GroupBox groupBox_OtherPlayer;
        private System.Windows.Forms.Label label_ScoreOtherPlayer;
        private System.Windows.Forms.Label label_NameOtherPlayer;
        private System.Windows.Forms.GroupBox groupBox_CurrentPlayer;
        private System.Windows.Forms.Label label_ScoreCurrentPlayer;
        private System.Windows.Forms.Label label_NameCurrentPlayer;
        private System.Windows.Forms.Button button_Shuffle;
        private System.Windows.Forms.ListView listView_OtherPlayer;
        private System.Windows.Forms.ListView listView_CurrentPlayer;
        private System.Windows.Forms.GroupBox groupBox_Play;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Label label_EndOfGame;
    }
}

