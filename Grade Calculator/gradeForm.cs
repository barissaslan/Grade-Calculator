using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class gradeForm : Form
    {
        public gradeForm()
        {
            InitializeComponent();
        }

        private void gradeForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            lvLessons.Items.Clear();
            for (int i = 0; i < FileLesson.Index; i++)
            {
                string[] lines = FileLesson.getLine(i);
                ListViewItem item = new ListViewItem(lines);
                if (i % 2 == 0) item.BackColor = Color.FromArgb(100, 166, 186);
                lvLessons.Items.Add(item);
            }
        }

        private void toolAddLesson_Click(object sender, EventArgs e)
        {
            lessonForm lessonForm = new lessonForm();
            lessonForm.txtGrade.Enabled = true;
            lessonForm.txtGrade.TabStop = true;
            lessonForm.txtGrade.ReadOnly = false;

            if (lessonForm.ShowDialog() == DialogResult.OK)
            {
                string name = lessonForm.txtLessonName.Text.Trim();
                double grade = double.Parse(lessonForm.txtGrade.Text.Trim());
                string letter = lessonForm.txtLetter.Text;
                FileLesson.writeLesson(name, grade, letter);
            }
            updateList();
        }

        private void toolDeleteLesson_Click(object sender, EventArgs e)
        {
            int selectedCount = lvLessons.SelectedIndices.Count;
            if (selectedCount <= 0) return;

            if (MessageBox.Show("Are you sure you want to remove selected (" + selectedCount + ") lessons?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvLessons.SelectedItems)
                {
                    FileLesson.removeLesson(item.Index);
                    lvLessons.Items.Remove(item);
                }
            }
        }

        private void toolClearAll_Click(object sender, EventArgs e)
        {
            if (FileLesson.Index == 0) return;
            if (MessageBox.Show("Are you sure you want to remove all lessons?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvLessons.Items)
                {
                    FileLesson.removeLesson(item.Index);
                    lvLessons.Items.Remove(item);
                }
            }
        }

        private void gradeForm_Shown(object sender, EventArgs e)
        {
            if (FileLesson.Index == 0)
                MessageBox.Show("No recorded lessons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
