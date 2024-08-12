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
            // Arrange

            string characterName = txtCharacterName.Text;
            // Needs validation to avoid exception
            string characterAge = txtCharacterAge.Text;
            string? characterPower = txtCharacterPower.Text;
            string? characterRival = txtCharacterRival.Text;
            // Needs validation to avoid exception
            string characterDebutDate = txtDebutDate.Text;
            string characterComicDebut = txtDebutIssue.Text;

            // Show message box errors for invalid data in Validator method
            bool isValid = true;

            // Act

            // Validate date
            DateTime validDebutDate;
            try
            {
                validDebutDate = Convert.ToDateTime(txtDebutDate.Text);               
            }
            catch(FormatException exc)
            {
                MessageBox.Show("Debut date must be a valid date");
                isValid = false;
            }

            // Validate age
            int validCharacterAge;
            try
            {
                validCharacterAge = Convert.ToInt32(characterAge);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Character age must be a valid age");
                isValid = false;
            }

            if(isValid)
            {
                Character currentCharacter = new(characterName, validCharacterAge, characterPower,
                                                 characterRival, validDebutDate,
                                                 characterComicDebut);

                // Add to database
            }
        }
    }
}
