namespace iTech
{
    partial class EnterEndTerm
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
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStream = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOrder = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboYear.Location = new System.Drawing.Point(175, 18);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(95, 21);
            this.comboYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Term";
            // 
            // comboTerm
            // 
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "TERM 1",
            "TERM 2",
            "TERM 3"});
            this.comboTerm.Location = new System.Drawing.Point(367, 18);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(47, 21);
            this.comboTerm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
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
            this.comboForm.Location = new System.Drawing.Point(502, 18);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(95, 21);
            this.comboForm.TabIndex = 4;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stream";
            // 
            // comboStream
            // 
            this.comboStream.FormattingEnabled = true;
            this.comboStream.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST"});
            this.comboStream.Location = new System.Drawing.Point(684, 18);
            this.comboStream.Name = "comboStream";
            this.comboStream.Size = new System.Drawing.Size(95, 21);
            this.comboStream.TabIndex = 6;
            this.comboStream.SelectedIndexChanged += new System.EventHandler(this.comboStream_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order By";
            // 
            // comboOrder
            // 
            this.comboOrder.FormattingEnabled = true;
            this.comboOrder.Items.AddRange(new object[] {
            "Name",
            "ADM"});
            this.comboOrder.Location = new System.Drawing.Point(433, 69);
            this.comboOrder.Name = "comboOrder";
            this.comboOrder.Size = new System.Drawing.Size(95, 21);
            this.comboOrder.TabIndex = 8;
            this.comboOrder.SelectedIndexChanged += new System.EventHandler(this.comboOrder_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1338, 535);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Print Marksheet for cheching";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(91, 666);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 32;
            this.btnGrade.Text = "Grade marks";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(587, 664);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(158, 23);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print Blank Marksheet";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(483, 666);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(390, 666);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // EnterEndTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboStream);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYear);
            this.Name = "EnterEndTerm";
            this.Text = "Enter End Term";
            this.Load += new System.EventHandler(this.EnterEndTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboStream;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRefresh;
    }
}