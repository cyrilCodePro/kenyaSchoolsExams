namespace iTech
{
    partial class ExamBlankMarkSheet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExamsMarkSheetBlankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboStream = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExamsMarkSheetBlankTableAdapter = new iTech.iTechDataTableAdapters.ExamsMarkSheetBlankTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsMarkSheetBlankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExamsMarkSheetBlankBindingSource
            // 
            this.ExamsMarkSheetBlankBindingSource.DataMember = "ExamsMarkSheetBlank";
            this.ExamsMarkSheetBlankBindingSource.DataSource = this.iTechData;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboStream);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboTerm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboStream
            // 
            this.comboStream.FormattingEnabled = true;
            this.comboStream.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST"});
            this.comboStream.Location = new System.Drawing.Point(713, 62);
            this.comboStream.Name = "comboStream";
            this.comboStream.Size = new System.Drawing.Size(95, 21);
            this.comboStream.TabIndex = 62;
            this.comboStream.SelectedIndexChanged += new System.EventHandler(this.comboStream_SelectedIndexChanged);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(94, 60);
            this.year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 21);
            this.year.TabIndex = 61;
            this.year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Stream";
            this.label5.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Form";
            // 
            // comboForm
            // 
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboForm.Location = new System.Drawing.Point(502, 62);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(95, 21);
            this.comboForm.TabIndex = 55;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Term";
            // 
            // comboTerm
            // 
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "Term 1",
            "Term 2",
            "Term 3"});
            this.comboTerm.Location = new System.Drawing.Point(336, 59);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(63, 21);
            this.comboTerm.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Year";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 329);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            reportDataSource2.Name = "ExamMarkSheetBlank";
            reportDataSource2.Value = this.ExamsMarkSheetBlankBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.ExamMarkSheetBlank.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExamsMarkSheetBlankTableAdapter
            // 
            this.ExamsMarkSheetBlankTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 36);
            this.label8.TabIndex = 63;
            this.label8.Text = "iTech Digital School Management System";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExamBlankMarkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExamBlankMarkSheet";
            this.Text = "ExamBlankMarkSheet";
            this.Load += new System.EventHandler(this.ExamBlankMarkSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsMarkSheetBlankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboStream;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExamsMarkSheetBlankBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.ExamsMarkSheetBlankTableAdapter ExamsMarkSheetBlankTableAdapter;
        private System.Windows.Forms.Label label8;
    }
}