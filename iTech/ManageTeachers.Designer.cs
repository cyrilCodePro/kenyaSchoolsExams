namespace iTech
{
    partial class ManageTeachers
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.textPrincipalsName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStream = new System.Windows.Forms.ComboBox();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textInitials = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.textTeachersName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboClassTeachersName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principals Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrincipal);
            this.groupBox1.Controls.Add(this.textPrincipalsName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Principals Update";
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(154, 84);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 2;
            this.btnPrincipal.Text = "Update";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            // 
            // textPrincipalsName
            // 
            this.textPrincipalsName.Location = new System.Drawing.Point(111, 44);
            this.textPrincipalsName.Name = "textPrincipalsName";
            this.textPrincipalsName.Size = new System.Drawing.Size(243, 20);
            this.textPrincipalsName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCheck);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboStream);
            this.groupBox2.Controls.Add(this.comboSubject);
            this.groupBox2.Controls.Add(this.comboForm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textInitials);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTeacher);
            this.groupBox2.Controls.Add(this.textTeachersName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Teacher";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(111, 198);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 55;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Stream";
            // 
            // comboStream
            // 
            this.comboStream.FormattingEnabled = true;
            this.comboStream.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST"});
            this.comboStream.Location = new System.Drawing.Point(111, 90);
            this.comboStream.Name = "comboStream";
            this.comboStream.Size = new System.Drawing.Size(121, 21);
            this.comboStream.TabIndex = 53;
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
            this.comboSubject.Location = new System.Drawing.Point(111, 17);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(121, 21);
            this.comboSubject.TabIndex = 54;
            // 
            // comboForm
            // 
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboForm.Location = new System.Drawing.Point(111, 57);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(121, 21);
            this.comboForm.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Subject";
            // 
            // textInitials
            // 
            this.textInitials.Location = new System.Drawing.Point(111, 166);
            this.textInitials.Name = "textInitials";
            this.textInitials.Size = new System.Drawing.Size(243, 20);
            this.textInitials.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Initials";
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(329, 198);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Text = "Save";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // textTeachersName
            // 
            this.textTeachersName.Location = new System.Drawing.Point(111, 122);
            this.textTeachersName.Name = "textTeachersName";
            this.textTeachersName.Size = new System.Drawing.Size(243, 20);
            this.textTeachersName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.comboClass);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comboClassTeachersName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(515, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 234);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Stream";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST"});
            this.comboBox1.Location = new System.Drawing.Point(87, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboClass.Location = new System.Drawing.Point(87, 73);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(121, 21);
            this.comboClass.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Form";
            // 
            // comboClassTeachersName
            // 
            this.comboClassTeachersName.FormattingEnabled = true;
            this.comboClassTeachersName.Location = new System.Drawing.Point(87, 32);
            this.comboClassTeachersName.Name = "comboClassTeachersName";
            this.comboClassTeachersName.Size = new System.Drawing.Size(196, 21);
            this.comboClassTeachersName.TabIndex = 5;
            this.comboClassTeachersName.SelectedIndexChanged += new System.EventHandler(this.comboClassTeachersName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ManageTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 463);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageTeachers";
            this.Text = "ManageTeachers";
            this.Load += new System.EventHandler(this.ManageTeachers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.TextBox textPrincipalsName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.TextBox textTeachersName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboClassTeachersName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textInitials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStream;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button button1;
    }
}