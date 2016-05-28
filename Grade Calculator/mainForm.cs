using Exam_Mark_Calculater;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        settingsForm settingsForm = new settingsForm();
        RoundButton btnAddRow = new RoundButton(Properties.Resources.add, 30, 30);
        RoundButton btnRemoveRow = new RoundButton(Properties.Resources.remove, 30, 30);
        RoundButton btnResetValue = new RoundButton(Properties.Resources.reset, 30, 30);
        double averageGrade;
        // for calculating to extra exams or quizes
        List<NumericUpDown> listNmrc = new List<NumericUpDown>();
        List<NumericUpDown> listNmrcWeight = new List<NumericUpDown>();

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnAddRow.Click += BtnAddRow_Click;
            panelAddRow.Controls.Add(btnAddRow);

            btnRemoveRow.Click += BtnRemoveRow_Click;
            panelRemoveRow.Controls.Add(btnRemoveRow);

            btnResetValue.Click += BtnResetRows_Click;
            panelResetValue.Controls.Add(btnResetValue);
        }

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            int count = listNmrc.Count;
            if (count++ > 5) return;

            int x = panelAddRow.Left;
            int y = panelAddRow.Top;

            // Round Buttons shifting
            panelAddRow.Location = new Point(x, y + 35);
            panelRemoveRow.Location = new Point(x + 40, y + 35);
            panelResetValue.Location = new Point(x + 80, y + 35);

            #region Dynamic Controls & Properties

            NumericUpDown nmrc = new NumericUpDown();
            nmrc.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            nmrc.Size = new Size(71, 29);
            nmrc.Location = new Point(nmrc1.Left, y);
            listNmrc.Add(nmrc);
            this.Controls.Add(nmrc);

            NumericUpDown nmrcWeight = new NumericUpDown();
            nmrcWeight.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            nmrcWeight.Size = new Size(71, 29);
            nmrcWeight.Location = new Point(nmrc1.Left + 100, y);
            listNmrcWeight.Add(nmrcWeight);
            this.Controls.Add(nmrcWeight);

            #endregion
        }

        private void BtnRemoveRow_Click(object sender, EventArgs e)
        {
            int index = listNmrc.Count - 1;
            if (index < 0) return;

            // Removing from form
            this.Controls.Remove(listNmrc[index]);
            this.Controls.Remove(listNmrcWeight[index]);

            // Removing from list
            listNmrc.RemoveAt(index);
            listNmrcWeight.RemoveAt(index);

            // Round Buttons shifting
            int x = panelAddRow.Left;
            int y = panelAddRow.Top;
            panelAddRow.Location = new Point(x, y - 35);
            panelRemoveRow.Location = new Point(x + 40, y - 35);
            panelResetValue.Location = new Point(x + 80, y - 35);
        }

        private void BtnResetRows_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (NumericUpDown.Equals(item.GetType(), nmrc1.GetType()))
                    item.Text = "0";
            }
            lblGrade.Text = "";
            lblLetterGrade.Text = "";

            nmrc1.Focus();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                updateSettings();
            }
        }

        private void updateSettings()
        {
            Properties.Settings.Default.FirstRanges.Clear();
            Properties.Settings.Default.LastRanges.Clear();
            Properties.Settings.Default.LetterGrades.Clear();

            for (int i = 1; i < 10; i++)
            {
                string value = getValue("nmrFirst" + i);
                if (value != null)
                    Properties.Settings.Default.FirstRanges.Add(value);

                value = getValue("nmrLast" + i);
                if (value != null)
                    Properties.Settings.Default.LastRanges.Add(value);

                value = getValue("txtLetter" + i);
                if (value != null)
                    Properties.Settings.Default.LetterGrades.Add(value);
            }

            Properties.Settings.Default.Save();
        }

        private string getValue(string name)
        {
            foreach (Control item in settingsForm.Controls)
            {
                if (item.Name.Equals(name))
                {
                    return item.Text;
                }
            }
            return null;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            averageGrade = (double)(nmrc1.Value * nmrcWeight1.Value) / 100.0 + (double)(nmrc2.Value * nmrWeight2.Value) / 100.0;

            for (int i = 0; i < listNmrc.Count; i++)
            {
                averageGrade += (double)(listNmrc[i].Value * listNmrcWeight[i].Value) / 100.0;
            }

            lblGrade.Text = averageGrade.ToString();
            lblLetterGrade.Text = getLetterGrade((decimal)averageGrade);
        }

        private string getLetterGrade(decimal averageGrade)
        {
            int[] max = new int[9];
            string[] letter = new string[9];

            for (int i = 8; i >= 0; i--)
            {
                max[i] = int.Parse(Properties.Settings.Default.LastRanges[i]);
                letter[i] = Properties.Settings.Default.LetterGrades[i];

                if (averageGrade < max[i])
                    return letter[i];
            }

            return letter[0];
        }
    }
}
