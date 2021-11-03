
namespace Assignment4
{
    partial class Form_NewCard
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
            this.label_NewCard = new System.Windows.Forms.Label();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NewCard
            // 
            this.label_NewCard.AutoSize = true;
            this.label_NewCard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NewCard.Location = new System.Drawing.Point(32, 29);
            this.label_NewCard.Name = "label_NewCard";
            this.label_NewCard.Size = new System.Drawing.Size(377, 35);
            this.label_NewCard.TabIndex = 0;
            this.label_NewCard.Text = "Do you want to pick a new card?";
            // 
            // button_Yes
            // 
            this.button_Yes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Yes.Location = new System.Drawing.Point(104, 78);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(94, 61);
            this.button_Yes.TabIndex = 1;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_No.Location = new System.Drawing.Point(239, 78);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(94, 61);
            this.button_No.TabIndex = 2;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // Form_NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 164);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label_NewCard);
            this.Name = "Form_NewCard";
            this.Text = "New card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NewCard;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
    }
}