namespace iTech
{
    partial class ExamsHistory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CatsHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.CatsHistoryTableAdapter = new iTech.iTechDataTableAdapters.CatsHistoryTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatsHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboTerm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboCat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 110);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 256);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM";
            // 
            // comboForm
            // 
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboForm.Location = new System.Drawing.Point(179, 13);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(121, 21);
            this.comboForm.TabIndex = 1;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboCat.Location = new System.Drawing.Point(440, 21);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(121, 21);
            this.comboCat.TabIndex = 3;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CYCLE";
            // 
            // comboTerm
            // 
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboTerm.Location = new System.Drawing.Point(179, 68);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(121, 21);
            this.comboTerm.TabIndex = 5;
            this.comboTerm.SelectedIndexChanged += new System.EventHandler(this.comboTerm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TERM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "YEAR";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(440, 68);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(121, 20);
            this.textYear.TabIndex = 7;
            this.textYear.TextChanged += new System.EventHandler(this.textYear_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CatsHistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 256);
            this.reportViewer1.TabIndex = 0;
            // 
            // CatsHistoryBindingSource
            // 
            this.CatsHistoryBindingSource.DataMember = "CatsHistory";
            this.CatsHistoryBindingSource.DataSource = this.iTechData;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CatsHistoryTableAdapter
            // 
            this.CatsHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // ExamsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExamsHistory";
            this.Text = "ExamsHistory";
            this.Load += new System.EventHandler(this.ExamsHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatsHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CatsHistoryBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.CatsHistoryTableAdapter CatsHistoryTableAdapter;
    }
}