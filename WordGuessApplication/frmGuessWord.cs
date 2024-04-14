using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class guessWord : Form
    {
        int counter = 0;
        public guessWord()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            StringBuilder word = new StringBuilder(wordGuess.Text);
            StringBuilder guessWord = new StringBuilder(guessBox.Text);

            string tempGuessWord = guessWord.ToString();
            bool isTrue = tempGuessWord.Contains("computer");

            if (isTrue)
            {
                word.Clear();
                word.Append("computer");
                wordGuess.Text = word.ToString();
                counter++;
                MessageBox.Show("Correct Guess! \nYou got it in " + counter + " attempts!");
            }
            else
            {
                counter++;
                wrongGuess.Items.Add(guessWord);
                guessWord.Clear();
                MessageBox.Show("Wrong guess! \nTry again.");
            }
        }
    }
}
