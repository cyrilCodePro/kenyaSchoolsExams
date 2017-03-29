namespace iTech
{
    partial class iTechTest
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
            this.iTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.iTechTableAdapter = new iTech.iTechDataTableAdapters.iTechTableAdapter();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboSubject);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboCats);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboTerm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 99);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 36);
            this.label8.TabIndex = 64;
            this.label8.Text = "iTech Digital School Management System";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(25, 60);
            this.year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 62;
            this.year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cat";
            // 
            // comboCats
            // 
            this.comboCats.FormattingEnabled = true;
            this.comboCats.Location = new System.Drawing.Point(338, 58);
            this.comboCats.Name = "comboCats";
            this.comboCats.Size = new System.Drawing.Size(97, 21);
            this.comboCats.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
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
            this.comboForm.Location = new System.Drawing.Point(511, 58);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(95, 21);
            this.comboForm.TabIndex = 55;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
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
            this.comboTerm.Location = new System.Drawing.Point(216, 58);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(63, 21);
            this.comboTerm.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "Year";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.iTechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.test.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 475);
            this.reportViewer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(511, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // iTechTableAdapter
            // 
            this.iTechTableAdapter.ClearBeforeFill = true;
            // 
            // comboSubject
            // 
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
            this.comboSubject.Location = new System.Drawing.Point(741, 59);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(121, 21);
            this.comboSubject.TabIndex = 65;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Garamond Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(647, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "SUBJECT";
            // 
            // iTechTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "iTechTest";
            this.Text = "iTechTest";
            this.Load += new System.EventHandler(this.iTechTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource iTechBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechTableAdapter iTechTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSubject;
    }
}