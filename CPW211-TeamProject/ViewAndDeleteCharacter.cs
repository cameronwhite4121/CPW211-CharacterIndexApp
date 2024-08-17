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
            // Remove character at index something rather 
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
            foreach (Character character in allCharacters)
            {
                lsbxCharacterList.Items.Add(character.Name);
            }
        }

        private void lsbxCharacterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character selectedCharacter = lsbxCharacterList.SelectedItem as Character;
        }
    }
}
