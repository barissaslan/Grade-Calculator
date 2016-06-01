using System;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class lessonForm : Form
    {
        public lessonForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double grade;
            if (txtLessonName.Text.Trim() == "" || txtGrade.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (double.TryParse(txtGrade.Text.Trim(), out grade) == false)
            {
                MessageBox.Show("Please fill the boxes correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            if (txtGrade.Text == "") return;
            txtLetter.Text = mainForm.getLetterGrade(double.Parse(txtGrade.Text.Trim()));
        }
    }
}
