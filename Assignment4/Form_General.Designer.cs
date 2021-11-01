
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
            this.groupBox_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.button_NewGame);
            this.groupBox_Menu.Location = new System.Drawing.Point(1159, 12);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(189, 719);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 743);
            this.Controls.Add(this.groupBox_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.Button button_NewGame;
    }
}

