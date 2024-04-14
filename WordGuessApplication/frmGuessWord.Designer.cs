namespace WordGuessApplication
{
    partial class guessWord
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
            this.guessBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordGuess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wrongGuess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // guessBox
            // 
            this.guessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(151, 128);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(303, 29);
            this.guessBox.TabIndex = 0;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Plum;
            this.guessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.ForeColor = System.Drawing.Color.White;
            this.guessButton.Location = new System.Drawing.Point(229, 163);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(150, 28);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // wordGuess
            // 
            this.wordGuess.BackColor = System.Drawing.Color.Plum;
            this.wordGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordGuess.ForeColor = System.Drawing.Color.White;
            this.wordGuess.Location = new System.Drawing.Point(154, 65);
            this.wordGuess.Name = "wordGuess";
            this.wordGuess.Size = new System.Drawing.Size(300, 60);
            this.wordGuess.TabIndex = 3;
            this.wordGuess.Text = "c??????r";
            this.wordGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(551, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wrong guess";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongGuess
            // 
            this.wrongGuess.FormattingEnabled = true;
            this.wrongGuess.Items.AddRange(new object[] {
            ""});
            this.wrongGuess.Location = new System.Drawing.Point(551, 65);
            this.wrongGuess.Name = "wrongGuess";
            this.wrongGuess.Size = new System.Drawing.Size(170, 134);
            this.wrongGuess.TabIndex = 6;
            // 
            // guessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wrongGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wordGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessBox);
            this.Name = "guessWord";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox wrongGuess;
    }
}

