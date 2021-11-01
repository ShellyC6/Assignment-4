
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
            this.label_NbPlayers = new System.Windows.Forms.Label();
            this.label_NbDecks = new System.Windows.Forms.Label();
            this.textBox_NbPlayers = new System.Windows.Forms.TextBox();
            this.textBox_NbDecks = new System.Windows.Forms.TextBox();
            this.button_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NbPlayers
            // 
            this.label_NbPlayers.AutoSize = true;
            this.label_NbPlayers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NbPlayers.Location = new System.Drawing.Point(39, 48);
            this.label_NbPlayers.Name = "label_NbPlayers";
            this.label_NbPlayers.Size = new System.Drawing.Size(177, 25);
            this.label_NbPlayers.TabIndex = 0;
            this.label_NbPlayers.Text = "Number of players: ";
            // 
            // label_NbDecks
            // 
            this.label_NbDecks.AutoSize = true;
            this.label_NbDecks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NbDecks.Location = new System.Drawing.Point(39, 104);
            this.label_NbDecks.Name = "label_NbDecks";
            this.label_NbDecks.Size = new System.Drawing.Size(164, 25);
            this.label_NbDecks.TabIndex = 1;
            this.label_NbDecks.Text = "Number of decks: ";
            // 
            // textBox_NbPlayers
            // 
            this.textBox_NbPlayers.Location = new System.Drawing.Point(255, 49);
            this.textBox_NbPlayers.Name = "textBox_NbPlayers";
            this.textBox_NbPlayers.Size = new System.Drawing.Size(108, 27);
            this.textBox_NbPlayers.TabIndex = 2;
            // 
            // textBox_NbDecks
            // 
            this.textBox_NbDecks.Location = new System.Drawing.Point(255, 105);
            this.textBox_NbDecks.Name = "textBox_NbDecks";
            this.textBox_NbDecks.Size = new System.Drawing.Size(108, 27);
            this.textBox_NbDecks.TabIndex = 3;
            // 
            // button_StartGame
            // 
            this.button_StartGame.Location = new System.Drawing.Point(39, 163);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(324, 29);
            this.button_StartGame.TabIndex = 4;
            this.button_StartGame.Text = "Start the new game";
            this.button_StartGame.UseVisualStyleBackColor = true;
            this.button_StartGame.Click += new System.EventHandler(this.button_StartGame_Click);
            // 
            // Form_NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 230);
            this.Controls.Add(this.button_StartGame);
            this.Controls.Add(this.textBox_NbDecks);
            this.Controls.Add(this.textBox_NbPlayers);
            this.Controls.Add(this.label_NbDecks);
            this.Controls.Add(this.label_NbPlayers);
            this.Name = "Form_NewGame";
            this.Text = "New game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NbPlayers;
        private System.Windows.Forms.Label label_NbDecks;
        private System.Windows.Forms.TextBox textBox_NbPlayers;
        private System.Windows.Forms.TextBox textBox_NbDecks;
        private System.Windows.Forms.Button button_StartGame;
    }
}