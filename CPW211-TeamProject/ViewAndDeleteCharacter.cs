using CPW211_TeamProject.Data;
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
    public partial class ViewAndDeleteCharacter : Form
    {
        public ViewAndDeleteCharacter()
        {
            InitializeComponent();
        }

        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            // Open add character form but change the labels
            // to edit character to reduce redundant code
        }

        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                Character selectedCharacter = lsbxCharacterList.SelectedItem as Character;

                CharacterContext dbContext = new CharacterContext();
                dbContext.Characters.Remove(selectedCharacter);
                dbContext.SaveChanges();
                PopulateList();
                MessageBox.Show("Character was removed");
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("A character must be selected");
            }
        }

        private void ViewAndDeleteCharacter_Load(object sender, EventArgs e)
        {
            // Adds all characters in the database to the character list box
            PopulateList();
        }

        /// <summary>
        /// Populates the character list box with all the character names
        /// in the database
        /// </summary>
        public void PopulateList()
        {
            // Should make this asyncronous

            CharacterContext dbContext = new CharacterContext();
            List<Character> allCharacters = dbContext.Characters.ToList();

            // Set the DataSource of the ListBox
            lsbxCharacterList.DataSource = allCharacters;
            lsbxCharacterList.DisplayMember = "Name";
            lsbxCharacterList.ValueMember = "Id";
        }

        private void lsbxCharacterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character selectedCharacter = lsbxCharacterList.SelectedItem as Character;
            txtCharacterName.Text = selectedCharacter.Name.ToString();
            txtCharacterAge.Text = selectedCharacter.Age.ToString();
            txtCharacterPower.Text = selectedCharacter.SuperPower.ToString();
            txtCharacterRival.Text = selectedCharacter.Rival.ToString();
            txtDebutDate.Text = selectedCharacter.DebutDate.ToString();
            txtDebutIssue.Text = selectedCharacter.ComicBookDebut.ToString();
            
        }
    }
}
