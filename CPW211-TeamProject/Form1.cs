namespace CPW211_TeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            AddCharacter newCharacterForm = new AddCharacter();
            newCharacterForm.ShowDialog();
        }

        private void btnViewDeleteCharacter_Click(object sender, EventArgs e)
        {
            ViewAndDeleteCharacter newViewCharacterForm = new ViewAndDeleteCharacter();
            newViewCharacterForm.ShowDialog();
        }
    }
}
