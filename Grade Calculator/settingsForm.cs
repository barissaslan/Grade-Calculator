using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private string getLetters(int index)
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

        private string getFirstRanges(int index)
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

        private string getLastRanges(int index)
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
                getFirstRanges(i);
                getLastRanges(i);
                getLetters(i);
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

        private void NumericUpDown_Enter(object sender, System.EventArgs e)
        {
            NumericUpDown nmr = (NumericUpDown)sender;
            nmr.Select(0, nmr.Value.ToString().Length);
        }
    }
}
