using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameCharacterWinForms.Models;

namespace GameCharacterWinForms
{
    public partial class Form1 : Form
    {
        private List<GameCharacter> characterCollection = new List<GameCharacter>();
        private GameCharacter selectedCharacter;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }

            selectedCharacter.Attack();
            battleLog.Items.Add($"{selectedCharacter.Name} performed an attack.");
            UpdateCharacterDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbCharacterType.Items.Add("Warrior");
            cmbCharacterType.Items.Add("Mage");
            cmbCharacterType.SelectedIndex = -1;
        }

        private void btnAddCharacter_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLevel.Text) ||
                string.IsNullOrWhiteSpace(txtHealth.Text))
            {
                MessageBox.Show("Please fill in all mandatory fields (Name, Level, Health).");
                return;
            }

            if (!int.TryParse(txtLevel.Text, out int level) ||
                !int.TryParse(txtHealth.Text, out int health))
            {
                MessageBox.Show("Please enter valid numeric values for Level and Health.");
                return;
            }

            GameCharacter newCharacter;

            if (cmbCharacterType.SelectedItem?.ToString() == "Warrior")
            {
                if (!int.TryParse(txtStrength.Text, out int strength))
                {
                    MessageBox.Show("Please enter a valid numeric value for Strength.");
                    return;
                }
                newCharacter = new Warrior(txtName.Text, level, health, strength, 5);
            }
            else if (cmbCharacterType.SelectedItem?.ToString() == "Mage")
            {
                if (!int.TryParse(txtMana.Text, out int mana) ||
                    !int.TryParse(txtIntelligence.Text, out int intelligence))
                {
                    MessageBox.Show("Please enter valid numeric values for Mana and Intelligence.");
                    return;
                }
                newCharacter = new Mage(txtName.Text, level, health, mana, intelligence, 10);
            }
            else
            {
                MessageBox.Show("Please select a valid character type.");
                return;
            }

           
            characterCollection.Add(newCharacter);
            listBoxCharacters.Items.Add(newCharacter.Name);
            MessageBox.Show($"{newCharacter.Name} added to your collection!");
            ClearCharacterInputFields();
        }

        private void btnSelectCharacter_Click_1(object sender, EventArgs e)
        {
     
            if (listBoxCharacters.SelectedIndex >= 0)
            {
                selectedCharacter = characterCollection[listBoxCharacters.SelectedIndex];
                txtCharacterDetails.Text = selectedCharacter.ToString();
                MessageBox.Show($"{selectedCharacter.Name} selected!");
            }
            else
            {
                MessageBox.Show("Please select a character from the list.");
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }

            selectedCharacter.Attack();
            battleLog.Items.Add($"{selectedCharacter.Name} performed an attack.");
            UpdateCharacterDetails();
        }

        private void btnDefend_Click_1(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }

            selectedCharacter.Defending();
            battleLog.Items.Add($"{selectedCharacter.Name} defended.");
            UpdateCharacterDetails();
        }

        private void btnLevelUp_Click_1(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }

            selectedCharacter.LevelUp();
            battleLog.Items.Add($"{selectedCharacter.Name} leveled up.");
            UpdateCharacterDetails();
        }

        private void cmbCharacterType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (cmbCharacterType.SelectedItem?.ToString() == "Warrior")
            {
                txtStrength.Enabled = true;
                txtMana.Enabled = false;
                txtIntelligence.Enabled = false;
            }
            else if (cmbCharacterType.SelectedItem?.ToString() == "Mage")
            {
                txtStrength.Enabled = false;
                txtMana.Enabled = true;
                txtIntelligence.Enabled = true;
            }
            else
            {
                txtStrength.Enabled = false;
                txtMana.Enabled = false;
                txtIntelligence.Enabled = false;
            }
        }

        private void ClearCharacterInputFields()
        {
            txtName.Clear();
            txtLevel.Clear();
            txtHealth.Clear();
            txtStrength.Clear();
            txtMana.Clear();
            txtIntelligence.Clear();
            cmbCharacterType.SelectedIndex = -1;
        }

        private void UpdateCharacterDetails()
        {
            if (selectedCharacter != null)
            {
                txtCharacterDetails.Text = selectedCharacter.ToString();
            }
        }
    



        

    

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void txtCharacterDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}