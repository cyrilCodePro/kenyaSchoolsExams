namespace iTech
{
    partial class SubjectAnalysis
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
            this.btnSubjClass = new System.Windows.Forms.Button();
            this.btnSubjByStream = new System.Windows.Forms.Button();
            this.btnSubjChamps = new System.Windows.Forms.Button();
            this.btnTopGender = new System.Windows.Forms.Button();
            this.btnTopClass = new System.Windows.Forms.Button();
            this.btnTopStream = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnMerit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubjClass
            // 
            this.btnSubjClass.Location = new System.Drawing.Point(103, 49);
            this.btnSubjClass.Name = "btnSubjClass";
            this.btnSubjClass.Size = new System.Drawing.Size(213, 23);
            this.btnSubjClass.TabIndex = 0;
            this.btnSubjClass.Text = "Subject Analysis By Class";
            this.btnSubjClass.UseVisualStyleBackColor = true;
            this.btnSubjClass.Click += new System.EventHandler(this.btnSubjClass_Click);
            // 
            // btnSubjByStream
            // 
            this.btnSubjByStream.Location = new System.Drawing.Point(103, 100);
            this.btnSubjByStream.Name = "btnSubjByStream";
            this.btnSubjByStream.Size = new System.Drawing.Size(213, 23);
            this.btnSubjByStream.TabIndex = 1;
            this.btnSubjByStream.Text = "Subject Analysis By Stream";
            this.btnSubjByStream.UseVisualStyleBackColor = true;
            // 
            // btnSubjChamps
            // 
            this.btnSubjChamps.Location = new System.Drawing.Point(103, 146);
            this.btnSubjChamps.Name = "btnSubjChamps";
            this.btnSubjChamps.Size = new System.Drawing.Size(213, 23);
            this.btnSubjChamps.TabIndex = 2;
            this.btnSubjChamps.Text = "SUBJECT CHAMPIONS";
            this.btnSubjChamps.UseVisualStyleBackColor = true;
            this.btnSubjChamps.Click += new System.EventHandler(this.btnSubjChamps_Click);
            // 
            // btnTopGender
            // 
            this.btnTopGender.Location = new System.Drawing.Point(103, 191);
            this.btnTopGender.Name = "btnTopGender";
            this.btnTopGender.Size = new System.Drawing.Size(213, 23);
            this.btnTopGender.TabIndex = 3;
            this.btnTopGender.Text = "TOP  STUDENTS BY GENDER";
            this.btnTopGender.UseVisualStyleBackColor = true;
            this.btnTopGender.Click += new System.EventHandler(this.btnTopGender_Click);
            // 
            // btnTopClass
            // 
            this.btnTopClass.Location = new System.Drawing.Point(103, 241);
            this.btnTopClass.Name = "btnTopClass";
            this.btnTopClass.Size = new System.Drawing.Size(213, 23);
            this.btnTopClass.TabIndex = 4;
            this.btnTopClass.Text = "TOP STUDENTS BY CLASS";
            this.btnTopClass.UseVisualStyleBackColor = true;
            this.btnTopClass.Click += new System.EventHandler(this.btnTopClass_Click);
            // 
            // btnTopStream
            // 
            this.btnTopStream.Location = new System.Drawing.Point(398, 49);
            this.btnTopStream.Name = "btnTopStream";
            this.btnTopStream.Size = new System.Drawing.Size(213, 23);
            this.btnTopStream.TabIndex = 5;
            this.btnTopStream.Text = "TOP STUDENTS BY STREAM";
            this.btnTopStream.UseVisualStyleBackColor = true;
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(398, 100);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(213, 23);
            this.btnBottom.TabIndex = 6;
            this.btnBottom.Text = "BOTTOM STUDENTS";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnMerit
            // 
            this.btnMerit.Location = new System.Drawing.Point(398, 146);
            this.btnMerit.Name = "btnMerit";
            this.btnMerit.Size = new System.Drawing.Size(213, 23);
            this.btnMerit.TabIndex = 7;
            this.btnMerit.Text = "MERIT LIST";
            this.btnMerit.UseVisualStyleBackColor = true;
            this.btnMerit.Click += new System.EventHandler(this.btnMerit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "MARKSHEET FOR CHECKING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Class Means";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 43);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAT ANALYSIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iTech.Properties.Resources.Close_Window;
            this.pictureBox1.Location = new System.Drawing.Point(727, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SubjectAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMerit);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTopStream);
            this.Controls.Add(this.btnTopClass);
            this.Controls.Add(this.btnTopGender);
            this.Controls.Add(this.btnSubjChamps);
            this.Controls.Add(this.btnSubjByStream);
            this.Controls.Add(this.btnSubjClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectAnalysis";
            this.Text = "Subject    Analysis";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubjClass;
        private System.Windows.Forms.Button btnSubjByStream;
        private System.Windows.Forms.Button btnSubjChamps;
        private System.Windows.Forms.Button btnTopGender;
        private System.Windows.Forms.Button btnTopClass;
        private System.Windows.Forms.Button btnTopStream;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnMerit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}