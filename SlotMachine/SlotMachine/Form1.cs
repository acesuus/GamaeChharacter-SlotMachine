using SlotMachine.Models;
using System;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private DateTime spinStartTime;
        private Slot slotMachine;

        public Form1()
        {
            InitializeComponent();
            InitializeThemeComboBox();
            InitializeGame();
            
        }
        private void InitializeThemeComboBox()
        {
            comboBoxThemes.Items.Add("Fruits");
            comboBoxThemes.Items.Add("Animals");
            comboBoxThemes.Items.Add("Jewels");
            comboBoxThemes.Items.Add("Numbers");
            comboBoxThemes.SelectedIndex = 0; // Default to the first theme
            comboBoxThemes.SelectedIndexChanged += ComboBoxThemes_SelectedIndexChanged;
        }
        private void ComboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeGame();
        }
        private void InitializeGame()
        {
            // Allow the user to select a theme
            Theme selectedTheme = GetSelectedTheme(); // Default theme, you can add a selection mechanism

            // Initialize PictureBoxes for reels
            PictureBox[] pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };

            // Create Reel objects for each PictureBox with the selected theme
            Reel[] reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], selectedTheme);
            }

            // Initialize SlotMachine object with initial balance of 1000
            slotMachine = new Slot(1000, reels);

            // Update the balance label on the form
            lblBalance.Text = "Balance: P" + slotMachine.Balance;
        }
        private Theme GetSelectedTheme()
        {
            switch (comboBoxThemes.SelectedItem.ToString())
            {
                case "Animals":
                    return new AnimalTheme();
                case "Jewels":
                    return new JewelTheme();
                case "Numbers":
                    return new NumberTheme();
                case "Fruits":
                default:
                    return new FruitTheme();
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            spinStartTime = DateTime.Now;
            timerSpin.Start();

            // Get the stake from the input box
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false; 	// Disable the button during spin
                lblResult.Text = "";  	// Clear any previous result
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }

            if (slotMachine.Balance <= 0)
            {
                MessageBox.Show("Game over! Your balance is zero. Restart the game to play again.");
                btnSpin.Enabled = false;
            }
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin();			// Spin the reels

            if ((DateTime.Now - spinStartTime).TotalSeconds >= 2)  // Stop after 2 seconds
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult();
                slotMachine.UpdateBalance(winnings);

                // Update result label
                lblResult.Text = winnings > 0
                    ? $"🎉 WIN! You earned P{winnings} 🎉"
                    : "No luck this time!";
                lblResult.ForeColor = winnings > 0 ? Color.Green : Color.Red;

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
                txtStake.Clear();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame(); // Reinitialize the game
            lblResult.Text = "";
            txtStake.Clear();
            btnSpin.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
