namespace iTech
{
    partial class EndTermSubjectChamps
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iTechRePortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.iTechRePortTableAdapter = new iTech.iTechDataTableAdapters.iTechRePortTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTechRePortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboSubject);
            this.panel1.Controls.Add(this.comboClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 403);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUBJECT CHAMPIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FORM";
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboClass.Location = new System.Drawing.Point(216, 34);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(121, 21);
            this.comboClass.TabIndex = 48;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.iTechRePortBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.ExamSubjectChampions.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // iTechRePortBindingSource
            // 
            this.iTechRePortBindingSource.DataMember = "iTechRePort";
            this.iTechRePortBindingSource.DataSource = this.iTechData;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTechRePortTableAdapter
            // 
            this.iTechRePortTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 50;
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
            this.comboSubject.Location = new System.Drawing.Point(453, 34);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(121, 21);
            this.comboSubject.TabIndex = 49;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // EndTermSubjectChamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EndTermSubjectChamps";
            this.Text = "EndTermSubjectChamps";
            this.Load += new System.EventHandler(this.EndTermSubjectChamps_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iTechRePortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboClass;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iTechRePortBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechRePortTableAdapter iTechRePortTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSubject;
    }
}