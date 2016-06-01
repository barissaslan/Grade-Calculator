namespace Grade_Calculator
{
    partial class gradeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gradeForm));
            this.lvLessons = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAddLesson = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteLesson = new System.Windows.Forms.ToolStripButton();
            this.toolClearAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLessons
            // 
            this.lvLessons.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvLessons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLessons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvLessons.FullRowSelect = true;
            this.lvLessons.Location = new System.Drawing.Point(0, 0);
            this.lvLessons.Name = "lvLessons";
            this.lvLessons.ShowGroups = false;
            this.lvLessons.Size = new System.Drawing.Size(628, 489);
            this.lvLessons.TabIndex = 0;
            this.lvLessons.UseCompatibleStateImageBehavior = false;
            this.lvLessons.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lesson";
            this.columnHeader1.Width = 332;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grade";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Letter Grade";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Added Date";
            this.columnHeader4.Width = 109;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddLesson,
            this.toolDeleteLesson,
            this.toolClearAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 464);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAddLesson
            // 
            this.toolAddLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddLesson.Image = global::Grade_Calculator.Properties.Resources.add1;
            this.toolAddLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddLesson.Name = "toolAddLesson";
            this.toolAddLesson.Size = new System.Drawing.Size(23, 22);
            this.toolAddLesson.Text = "Add Lesson";
            this.toolAddLesson.Click += new System.EventHandler(this.toolAddLesson_Click);
            // 
            // toolDeleteLesson
            // 
            this.toolDeleteLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteLesson.Image = global::Grade_Calculator.Properties.Resources.delete;
            this.toolDeleteLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteLesson.Name = "toolDeleteLesson";
            this.toolDeleteLesson.Size = new System.Drawing.Size(23, 22);
            this.toolDeleteLesson.Text = "Delete Lesson";
            this.toolDeleteLesson.Click += new System.EventHandler(this.toolDeleteLesson_Click);
            // 
            // toolClearAll
            // 
            this.toolClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClearAll.Image = global::Grade_Calculator.Properties.Resources.clear;
            this.toolClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClearAll.Name = "toolClearAll";
            this.toolClearAll.Size = new System.Drawing.Size(23, 22);
            this.toolClearAll.Text = "Clear All";
            this.toolClearAll.Click += new System.EventHandler(this.toolClearAll_Click);
            // 
            // gradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(628, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvLessons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.gradeForm_Load);
            this.Shown += new System.EventHandler(this.gradeForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListView lvLessons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAddLesson;
        private System.Windows.Forms.ToolStripButton toolDeleteLesson;
        private System.Windows.Forms.ToolStripButton toolClearAll;
    }
}