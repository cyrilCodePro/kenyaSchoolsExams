namespace iTech
{
    partial class MeanForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iTechData = new iTech.iTechData();
            this.CLASSMEANSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CLASSMEANSTableAdapter = new iTech.iTechDataTableAdapters.CLASSMEANSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLASSMEANSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CLASSMEANSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.CLASSPOSITION.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CLASSMEANSBindingSource
            // 
            this.CLASSMEANSBindingSource.DataMember = "CLASSMEANS";
            this.CLASSMEANSBindingSource.DataSource = this.iTechData;
            // 
            // CLASSMEANSTableAdapter
            // 
            this.CLASSMEANSTableAdapter.ClearBeforeFill = true;
            // 
            // MeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 346);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MeanForm";
            this.Text = "MeanForm";
            this.Load += new System.EventHandler(this.MeanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLASSMEANSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CLASSMEANSBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.CLASSMEANSTableAdapter CLASSMEANSTableAdapter;
    }
}