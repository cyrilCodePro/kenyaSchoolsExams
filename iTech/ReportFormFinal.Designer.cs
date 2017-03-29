﻿namespace iTech
{
    partial class ReportFormFinal
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
            this.iTechRePortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTechRePortTableAdapter = new iTech.iTechDataTableAdapters.iTechRePortTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechRePortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.iTechRePortBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iTech.ReportFormFinal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(894, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // iTechData
            // 
            this.iTechData.DataSetName = "iTechData";
            this.iTechData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTechRePortBindingSource
            // 
            this.iTechRePortBindingSource.DataMember = "iTechRePort";
            this.iTechRePortBindingSource.DataSource = this.iTechData;
            // 
            // iTechRePortTableAdapter
            // 
            this.iTechRePortTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 458);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFormFinal";
            this.Text = "ReportFormFinal";
            this.Load += new System.EventHandler(this.ReportFormFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTechData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTechRePortBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iTechRePortBindingSource;
        private iTechData iTechData;
        private iTechDataTableAdapters.iTechRePortTableAdapter iTechRePortTableAdapter;
    }
}