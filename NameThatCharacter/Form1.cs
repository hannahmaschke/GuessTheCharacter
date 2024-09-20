namespace NameThatCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2010sPresent_Click(object sender, EventArgs e)
        {
            // WHY?!
            //pictureBox2010sPresent.BackColor = Color.Transparent;
            MessageBox.Show("GET OUT OF MY LAWN, KID!");
        }

        private void pictureBox90s2000s_Click(object sender, EventArgs e)
        {
            Match90s2000sCharacters match90s2000sCharacters = new Match90s2000sCharacters();
            this.Hide();
            match90s2000sCharacters.ShowDialog();
            this.Show();
        }

        private void pictureBox70sToPresent_Click(object sender, EventArgs e)
        {
            MultipleChoice multipleChoice = new MultipleChoice();
            this.Hide();
            multipleChoice.ShowDialog();
            this.Show();
        }

        private void characters90sTo2000sLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
