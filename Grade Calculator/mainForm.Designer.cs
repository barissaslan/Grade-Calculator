namespace Grade_Calculator
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.nmrWeight2 = new System.Windows.Forms.NumericUpDown();
            this.nmrcWeight1 = new System.Windows.Forms.NumericUpDown();
            this.nmrc2 = new System.Windows.Forms.NumericUpDown();
            this.nmrc1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRemoveRow = new System.Windows.Forms.Panel();
            this.panelAddRow = new System.Windows.Forms.Panel();
            this.panelResetValue = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSettings = new System.Windows.Forms.ToolStripButton();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClearRows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCalculate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmrWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmrWeight2
            // 
            this.nmrWeight2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrWeight2.Location = new System.Drawing.Point(116, 85);
            this.nmrWeight2.Name = "nmrWeight2";
            this.nmrWeight2.Size = new System.Drawing.Size(71, 29);
            this.nmrWeight2.TabIndex = 3;
            this.nmrWeight2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // nmrcWeight1
            // 
            this.nmrcWeight1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrcWeight1.Location = new System.Drawing.Point(116, 50);
            this.nmrcWeight1.Name = "nmrcWeight1";
            this.nmrcWeight1.Size = new System.Drawing.Size(71, 29);
            this.nmrcWeight1.TabIndex = 1;
            this.nmrcWeight1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // nmrc2
            // 
            this.nmrc2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrc2.Location = new System.Drawing.Point(16, 85);
            this.nmrc2.Name = "nmrc2";
            this.nmrc2.Size = new System.Drawing.Size(71, 29);
            this.nmrc2.TabIndex = 2;
            this.nmrc2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // nmrc1
            // 
            this.nmrc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrc1.Location = new System.Drawing.Point(16, 50);
            this.nmrc1.Name = "nmrc1";
            this.nmrc1.Size = new System.Drawing.Size(71, 29);
            this.nmrc1.TabIndex = 0;
            this.nmrc1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Average Letter Grade  :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(12, 417);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 21);
            this.label.TabIndex = 29;
            this.label.Text = "Average Grade              : ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(14, 379);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 35);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Weight (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Grade (%)";
            // 
            // panelRemoveRow
            // 
            this.panelRemoveRow.Location = new System.Drawing.Point(52, 120);
            this.panelRemoveRow.Name = "panelRemoveRow";
            this.panelRemoveRow.Size = new System.Drawing.Size(30, 30);
            this.panelRemoveRow.TabIndex = 5;
            // 
            // panelAddRow
            // 
            this.panelAddRow.Location = new System.Drawing.Point(16, 120);
            this.panelAddRow.Name = "panelAddRow";
            this.panelAddRow.Size = new System.Drawing.Size(30, 30);
            this.panelAddRow.TabIndex = 4;
            // 
            // panelResetValue
            // 
            this.panelResetValue.Location = new System.Drawing.Point(88, 120);
            this.panelResetValue.Name = "panelResetValue";
            this.panelResetValue.Size = new System.Drawing.Size(30, 30);
            this.panelResetValue.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSettings
            // 
            this.toolSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSettings.Image = global::Grade_Calculator.Properties.Resources.settings;
            this.toolSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Size = new System.Drawing.Size(23, 22);
            this.toolSettings.Text = "Settings";
            this.toolSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGrade.Location = new System.Drawing.Point(199, 417);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 21);
            this.lblGrade.TabIndex = 29;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetterGrade.Location = new System.Drawing.Point(199, 438);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(0, 21);
            this.lblLetterGrade.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAddRow,
            this.contextDeleteRow,
            this.contextClearRows,
            this.toolStripSeparator1,
            this.contextCalculate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 98);
            // 
            // contextAddRow
            // 
            this.contextAddRow.Name = "contextAddRow";
            this.contextAddRow.Size = new System.Drawing.Size(133, 22);
            this.contextAddRow.Text = "Add Row";
            this.contextAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // contextDeleteRow
            // 
            this.contextDeleteRow.Name = "contextDeleteRow";
            this.contextDeleteRow.Size = new System.Drawing.Size(133, 22);
            this.contextDeleteRow.Text = "Delete Row";
            this.contextDeleteRow.Click += new System.EventHandler(this.BtnRemoveRow_Click);
            // 
            // contextClearRows
            // 
            this.contextClearRows.Name = "contextClearRows";
            this.contextClearRows.Size = new System.Drawing.Size(133, 22);
            this.contextClearRows.Text = "Clear Rows";
            this.contextClearRows.Click += new System.EventHandler(this.BtnResetRows_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // contextCalculate
            // 
            this.contextCalculate.Name = "contextCalculate";
            this.contextCalculate.Size = new System.Drawing.Size(133, 22);
            this.contextCalculate.Text = "Calculate";
            this.contextCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 468);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.nmrWeight2);
            this.Controls.Add(this.nmrcWeight1);
            this.Controls.Add(this.nmrc2);
            this.Controls.Add(this.nmrc1);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelResetValue);
            this.Controls.Add(this.panelRemoveRow);
            this.Controls.Add(this.panelAddRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrWeight2;
        private System.Windows.Forms.NumericUpDown nmrcWeight1;
        private System.Windows.Forms.NumericUpDown nmrc2;
        private System.Windows.Forms.NumericUpDown nmrc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResetValue;
        private System.Windows.Forms.Panel panelRemoveRow;
        private System.Windows.Forms.Panel panelAddRow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSettings;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAddRow;
        private System.Windows.Forms.ToolStripMenuItem contextDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem contextClearRows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextCalculate;
    }
}

