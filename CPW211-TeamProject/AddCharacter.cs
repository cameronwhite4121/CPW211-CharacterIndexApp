﻿using CPW211_TeamProject.Data;
using CPW211_TeamProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW211_TeamProject
{
    public partial class AddCharacter : Form
    {
        public AddCharacter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked, textbox inputs are stored
        /// into variables and data is validated. If all data is valid,
        /// a new character object is created and stored into the database.
        /// </summary>
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            // Arrange with default values

            string characterName = "";
            int characterAge = 0;
            string? characterPower = "No power/s";
            string? characterRival = "No rival/s";
            DateTime characterDebutDate = new DateTime();
            string characterComicDebut = "";

            bool validData = true;

            // Validate textbox.text

            // Validate name
            if (!string.IsNullOrWhiteSpace(txtCharacterName.Text))
            {
                characterName = txtCharacterName.Text.Trim();
            }
            else
            {
                MessageBox.Show("Character name must not be empty");
                validData = false;
            }

            // Validate age
            try
            {
                characterAge = Convert.ToInt32(txtCharacterAge.Text.Trim());
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Character age must be a valid integer");
                validData = false;
            }

            // Check for unrequired power
            if (!string.IsNullOrWhiteSpace(txtCharacterPower.Text))
            {
                characterPower = txtCharacterPower.Text.Trim();
            }

            // Check for unrequired rival
            if (!string.IsNullOrWhiteSpace(txtCharacterRival.Text))
            {
                characterRival = txtCharacterRival.Text.Trim();
            }

            // Check for unrequired power
            if (!string.IsNullOrWhiteSpace(txtCharacterPower.Text))
            {
                characterPower = txtCharacterPower.Text.Trim();
            }

            // Validate debut date
            try
            {
                DateTime.TryParse(txtDebutDate.Text.Trim(), out characterDebutDate);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Debut date must be a valid date");
                validData = false;
            }

            // Validate comic debut
            if (!string.IsNullOrWhiteSpace(txtDebutIssue.Text))
            {
                characterComicDebut = txtDebutIssue.Text.Trim();
            }
            else
            {
                MessageBox.Show("Character name must not be empty");
                validData = false;
            }

            Character currentCharacter = new(characterName, characterAge, characterPower,
                                                 characterRival, characterDebutDate, characterComicDebut);

            if (validData)
            {
                try
                {
                    // Validate the data using the model's data annotations
                    if (ValidationHelper.Validate(currentCharacter))
                    {
                        CharacterContext dbContext = new();
                        dbContext.Characters.Add(currentCharacter);
                        dbContext.SaveChanges();
                        MessageBox.Show($"{characterName} was added");
                    }
                }
                catch (ArgumentException) { }
            }
        }
    }
}
