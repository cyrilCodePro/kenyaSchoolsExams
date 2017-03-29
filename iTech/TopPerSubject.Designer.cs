namespace iTech
{
    partial class TopPerSubject
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.iTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iTechTableAdapter = new iTech.iTechDataTableAdapters.iTechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTechBindingSource
            // 
            this.iTechBindingSource.DataMember = "iTech";
            this.iTechBindingSource.DataSource = this.iTechData;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboSubject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FORM";
            // 
            // comboForm
            // 
            this.comboForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboForm.Location = new System.Drawing.Point(423, 41);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(121, 21);
            this.comboForm.TabIndex = 6;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUBJECT";
            // 
            // comboSubject
            // 
            this.comboSubject.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Items.AddRange(new object[] {
            "MAT",
            "ENG",
            "KIS",
            "CHEM",
            "BIO",
            "PHY",
            "HIST",
            "GEO",
            "CRE",
            "AGR",
            "BST"});
            this.comboSubject.Location = new System.Drawing.Point(183, 46);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(121, 21);
            this.comboSubject.TabIndex = 4;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 10 PER SUBJECT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 429);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.iTechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.SubjectAnalysis.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(830, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // iTechTableAdapter
            // 
            this.iTechTableAdapter.ClearBeforeFill = true;
            // 
            // TopPerSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TopPerSubject";
            this.Text = "TopPerSubject";
            this.Load += new System.EventHandler(this.TopPerSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSubject;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iTechBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechTableAdapter iTechTableAdapter;
    }
}