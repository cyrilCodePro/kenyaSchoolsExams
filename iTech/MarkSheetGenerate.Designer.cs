namespace iTech
{
    partial class MarkSheetGenerate
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
            this.iTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechData = new iTech.iTechData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboStream = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iTechTableAdapter = new iTech.iTechDataTableAdapters.iTechTableAdapter();
            this.streamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.comboSubject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboStream);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboForm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 150);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.comboSubject.Location = new System.Drawing.Point(408, 103);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(106, 21);
            this.comboSubject.TabIndex = 66;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 46);
            this.label5.TabIndex = 52;
            this.label5.Text = "iTech Digital School Management System";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(94, 104);
            this.year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 51;
            this.year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.year.ValueChanged += new System.EventHandler(this.year_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(732, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 50;
            this.label7.Text = "Stream";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboStream
            // 
            this.comboStream.DataSource = this.streamBindingSource;
            this.comboStream.DisplayMember = "STREAM";
            this.comboStream.FormattingEnabled = true;
            this.comboStream.Location = new System.Drawing.Point(797, 99);
            this.comboStream.Name = "comboStream";
            this.comboStream.Size = new System.Drawing.Size(95, 21);
            this.comboStream.TabIndex = 49;
            this.comboStream.ValueMember = "STREAM";
            this.comboStream.SelectedIndexChanged += new System.EventHandler(this.comboStream_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(327, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "SUBJECT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 46;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(510, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboForm
            // 
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboForm.Location = new System.Drawing.Point(580, 102);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(95, 21);
            this.comboForm.TabIndex = 44;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Term";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 583);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.iTechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.iTechBlankMarkSheet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 579);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // iTechTableAdapter
            // 
            this.iTechTableAdapter.ClearBeforeFill = true;
            // 
            // streamBindingSource
            // 
            this.streamBindingSource.DataMember = "Stream";
            this.streamBindingSource.DataSource = this.iTechData;
            // 
            // streamTableAdapter
            // 
       
            // 
            // MarkSheetGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(914, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MarkSheetGenerate";
            this.Text = "MarkSheetGenerate";
            this.Load += new System.EventHandler(this.MarkSheetGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboStream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource iTechBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechTableAdapter iTechTableAdapter;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.BindingSource streamBindingSource;
      
    }
}