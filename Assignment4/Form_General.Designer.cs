
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
            this.button_NewGame = new System.Windows.Forms.Button();
            this.listBox_Croupier = new System.Windows.Forms.ListBox();
            this.groupBox_Table = new System.Windows.Forms.GroupBox();
            this.label_Croupier = new System.Windows.Forms.Label();
            this.label_Losers = new System.Windows.Forms.Label();
            this.listBox_Losers = new System.Windows.Forms.ListBox();
            this.label_Winners = new System.Windows.Forms.Label();
            this.listBox_Winners = new System.Windows.Forms.ListBox();
            this.groupBox_CurrentPlayer = new System.Windows.Forms.GroupBox();
            this.groupBox_OtherPlayer = new System.Windows.Forms.GroupBox();
            this.label_NameCurrentPlayer = new System.Windows.Forms.Label();
            this.label_ScoreCurrentPlayer = new System.Windows.Forms.Label();
            this.label_ScoreOtherPlayer = new System.Windows.Forms.Label();
            this.label_NameOtherPlayer = new System.Windows.Forms.Label();
            this.groupBox_Menu.SuspendLayout();
            this.groupBox_Table.SuspendLayout();
            this.groupBox_CurrentPlayer.SuspendLayout();
            this.groupBox_OtherPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.button_NewGame);
            this.groupBox_Menu.Location = new System.Drawing.Point(1130, 12);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(195, 632);
            this.groupBox_Menu.TabIndex = 0;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "Menu";
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
            // 
            // groupBox_Table
            // 
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
            // 
            // groupBox_CurrentPlayer
            // 
            this.groupBox_CurrentPlayer.Controls.Add(this.label_ScoreCurrentPlayer);
            this.groupBox_CurrentPlayer.Controls.Add(this.label_NameCurrentPlayer);
            this.groupBox_CurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_CurrentPlayer.Location = new System.Drawing.Point(18, 35);
            this.groupBox_CurrentPlayer.Name = "groupBox_CurrentPlayer";
            this.groupBox_CurrentPlayer.Size = new System.Drawing.Size(408, 578);
            this.groupBox_CurrentPlayer.TabIndex = 0;
            this.groupBox_CurrentPlayer.TabStop = false;
            this.groupBox_CurrentPlayer.Text = "Current player";
            // 
            // groupBox_OtherPlayer
            // 
            this.groupBox_OtherPlayer.Controls.Add(this.label_ScoreOtherPlayer);
            this.groupBox_OtherPlayer.Controls.Add(this.label_NameOtherPlayer);
            this.groupBox_OtherPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_OtherPlayer.Location = new System.Drawing.Point(446, 35);
            this.groupBox_OtherPlayer.Name = "groupBox_OtherPlayer";
            this.groupBox_OtherPlayer.Size = new System.Drawing.Size(405, 578);
            this.groupBox_OtherPlayer.TabIndex = 1;
            this.groupBox_OtherPlayer.TabStop = false;
            this.groupBox_OtherPlayer.Text = "Other player";
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
            this.groupBox_CurrentPlayer.ResumeLayout(false);
            this.groupBox_CurrentPlayer.PerformLayout();
            this.groupBox_OtherPlayer.ResumeLayout(false);
            this.groupBox_OtherPlayer.PerformLayout();
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
    }
}

