using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private string setLetters(int index)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name.Equals("txtLetter" + index))
                {
                    item.Text = Properties.Settings.Default.LetterGrades[index - 1];
                }
            }
            return null;
        }

        private string setFirstRanges(int index)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name.Equals("nmrFirst" + index))
                {
                    item.Text = Properties.Settings.Default.FirstRanges[index - 1];
                }
            }
            return null;
        }

        private string setLastRanges(int index)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name.Equals("nmrLast" + index))
                {
                    item.Text = Properties.Settings.Default.LastRanges[index - 1];
                }
            }
            return null;
        }

        private void settingsForm_Load(object sender, System.EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                setFirstRanges(i);
                setLastRanges(i);
                setLetters(i);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
