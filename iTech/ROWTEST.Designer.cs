namespace iTech
{
    partial class ROWTEST
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboStream = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.iTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.iTechTableAdapter = new iTech.iTechDataTableAdapters.iTechTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.iTechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.test.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(744, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboStream);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 341);
            this.panel2.TabIndex = 2;
            // 
            // comboStream
            // 
            this.comboStream.FormattingEnabled = true;
            this.comboStream.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST"});
            this.comboStream.Location = new System.Drawing.Point(569, 25);
            this.comboStream.Name = "comboStream";
            this.comboStream.Size = new System.Drawing.Size(95, 21);
            this.comboStream.TabIndex = 72;
            this.comboStream.SelectedIndexChanged += new System.EventHandler(this.comboStream_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Stream";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 69;
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
            this.comboForm.Location = new System.Drawing.Point(335, 30);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(121, 21);
            this.comboForm.TabIndex = 68;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "SUBJECT";
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
            this.comboSubject.Location = new System.Drawing.Point(95, 35);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(121, 21);
            this.comboSubject.TabIndex = 66;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
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
            // iTechTableAdapter
            // 
            this.iTechTableAdapter.ClearBeforeFill = true;
            // 
            // ROWTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ROWTEST";
            this.Text = "ROWTEST";
            this.Load += new System.EventHandler(this.ROWTEST_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iTechBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechTableAdapter iTechTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboStream;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSubject;
    }
}