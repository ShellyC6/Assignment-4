
namespace Assignment4
{
    partial class Form_NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NbDecks = new System.Windows.Forms.Label();
            this.textBox_NbDecks = new System.Windows.Forms.TextBox();
            this.button_StartGame = new System.Windows.Forms.Button();
            this.listBox_Players = new System.Windows.Forms.ListBox();
            this.groupBox_NewPlayer = new System.Windows.Forms.GroupBox();
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.textBox_NameNewPlayer = new System.Windows.Forms.TextBox();
            this.label_NameNewPlayer = new System.Windows.Forms.Label();
            this.checkBox_Croupier = new System.Windows.Forms.CheckBox();
            this.checkBox_Computer = new System.Windows.Forms.CheckBox();
            this.groupBox_NewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NbDecks
            // 
            this.label_NbDecks.AutoSize = true;
            this.label_NbDecks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NbDecks.Location = new System.Drawing.Point(39, 38);
            this.label_NbDecks.Name = "label_NbDecks";
            this.label_NbDecks.Size = new System.Drawing.Size(164, 25);
            this.label_NbDecks.TabIndex = 1;
            this.label_NbDecks.Text = "Number of decks: ";
            // 
            // textBox_NbDecks
            // 
            this.textBox_NbDecks.Location = new System.Drawing.Point(255, 39);
            this.textBox_NbDecks.Name = "textBox_NbDecks";
            this.textBox_NbDecks.Size = new System.Drawing.Size(108, 27);
            this.textBox_NbDecks.TabIndex = 3;
            // 
            // button_StartGame
            // 
            this.button_StartGame.Location = new System.Drawing.Point(427, 224);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(324, 29);
            this.button_StartGame.TabIndex = 4;
            this.button_StartGame.Text = "Start the new game";
            this.button_StartGame.UseVisualStyleBackColor = true;
            this.button_StartGame.Click += new System.EventHandler(this.button_StartGame_Click);
            // 
            // listBox_Players
            // 
            this.listBox_Players.FormattingEnabled = true;
            this.listBox_Players.ItemHeight = 20;
            this.listBox_Players.Location = new System.Drawing.Point(427, 38);
            this.listBox_Players.Name = "listBox_Players";
            this.listBox_Players.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Players.Size = new System.Drawing.Size(324, 164);
            this.listBox_Players.TabIndex = 5;
            // 
            // groupBox_NewPlayer
            // 
            this.groupBox_NewPlayer.Controls.Add(this.checkBox_Computer);
            this.groupBox_NewPlayer.Controls.Add(this.checkBox_Croupier);
            this.groupBox_NewPlayer.Controls.Add(this.button_AddPlayer);
            this.groupBox_NewPlayer.Controls.Add(this.textBox_NameNewPlayer);
            this.groupBox_NewPlayer.Controls.Add(this.label_NameNewPlayer);
            this.groupBox_NewPlayer.Location = new System.Drawing.Point(39, 85);
            this.groupBox_NewPlayer.Name = "groupBox_NewPlayer";
            this.groupBox_NewPlayer.Size = new System.Drawing.Size(329, 168);
            this.groupBox_NewPlayer.TabIndex = 6;
            this.groupBox_NewPlayer.TabStop = false;
            this.groupBox_NewPlayer.Text = "New player";
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(20, 117);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(280, 29);
            this.button_AddPlayer.TabIndex = 4;
            this.button_AddPlayer.Text = "Add this new player";
            this.button_AddPlayer.UseVisualStyleBackColor = true;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // textBox_NameNewPlayer
            // 
            this.textBox_NameNewPlayer.Location = new System.Drawing.Point(113, 33);
            this.textBox_NameNewPlayer.Name = "textBox_NameNewPlayer";
            this.textBox_NameNewPlayer.Size = new System.Drawing.Size(187, 27);
            this.textBox_NameNewPlayer.TabIndex = 3;
            // 
            // label_NameNewPlayer
            // 
            this.label_NameNewPlayer.AutoSize = true;
            this.label_NameNewPlayer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NameNewPlayer.Location = new System.Drawing.Point(20, 32);
            this.label_NameNewPlayer.Name = "label_NameNewPlayer";
            this.label_NameNewPlayer.Size = new System.Drawing.Size(71, 25);
            this.label_NameNewPlayer.TabIndex = 2;
            this.label_NameNewPlayer.Text = "Name: ";
            // 
            // checkBox_Croupier
            // 
            this.checkBox_Croupier.AutoSize = true;
            this.checkBox_Croupier.Location = new System.Drawing.Point(20, 77);
            this.checkBox_Croupier.Name = "checkBox_Croupier";
            this.checkBox_Croupier.Size = new System.Drawing.Size(88, 24);
            this.checkBox_Croupier.TabIndex = 5;
            this.checkBox_Croupier.Text = "Croupier";
            this.checkBox_Croupier.UseVisualStyleBackColor = true;
            // 
            // checkBox_Computer
            // 
            this.checkBox_Computer.AutoSize = true;
            this.checkBox_Computer.Location = new System.Drawing.Point(162, 77);
            this.checkBox_Computer.Name = "checkBox_Computer";
            this.checkBox_Computer.Size = new System.Drawing.Size(97, 24);
            this.checkBox_Computer.TabIndex = 6;
            this.checkBox_Computer.Text = "Computer";
            this.checkBox_Computer.UseVisualStyleBackColor = true;
            // 
            // Form_NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 275);
            this.Controls.Add(this.groupBox_NewPlayer);
            this.Controls.Add(this.listBox_Players);
            this.Controls.Add(this.button_StartGame);
            this.Controls.Add(this.textBox_NbDecks);
            this.Controls.Add(this.label_NbDecks);
            this.Name = "Form_NewGame";
            this.Text = "New game";
            this.groupBox_NewPlayer.ResumeLayout(false);
            this.groupBox_NewPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_NbDecks;
        private System.Windows.Forms.TextBox textBox_NbDecks;
        private System.Windows.Forms.Button button_StartGame;
        private System.Windows.Forms.ListBox listBox_Players;
        private System.Windows.Forms.GroupBox groupBox_NewPlayer;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.TextBox textBox_NameNewPlayer;
        private System.Windows.Forms.Label label_NameNewPlayer;
        private System.Windows.Forms.CheckBox checkBox_Computer;
        private System.Windows.Forms.CheckBox checkBox_Croupier;
    }
}