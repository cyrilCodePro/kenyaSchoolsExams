using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;


namespace iTech
{
    public partial class StudentsData : Form
    {
        string Gender;
        SqlCommand cmd;
        SqlConnection con;
        
        public StudentsData()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentsData_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(year.Text==""|| txtAdm.Text=="" || txtDOB.Text==""||txtKCPE.Text==""||txtParents.Text==""||txtPhone.Text==""||txtResidence.Text==""||txtStudentName.Text==""||txtDOB.Text=="")
            {
                MessageBox.Show("Enter the Required Fields Only Image Is Optional", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else {
                try {
                   
                    con = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO AddStudents(Name,BIRTH,KCPE,ADM,RESIDENCE,PARENTS,PHONE,EMAIL,FORM,STREAM,GENDER,Year) VALUES (@Name,@BIRTH,@KCPE,@ADM,@RESIDENCE,@PARENTS,@PHONE,@EMAIL,@FORM,@STREAM,@GENDER,@Year)", con);
                    cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@BIRTH", txtDOB.Text);
                    cmd.Parameters.AddWithValue("@KCPE", txtKCPE.Text);
                    cmd.Parameters.AddWithValue("@ADM", txtAdm.Text);
                    cmd.Parameters.AddWithValue("@RESIDENCE", txtResidence.Text);
                    cmd.Parameters.AddWithValue("@PARENTS", txtParents.Text);
                    cmd.Parameters.AddWithValue("@PHONE", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                    cmd.Parameters.AddWithValue("@STREAM", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@GENDER", Gender);
                    cmd.Parameters.AddWithValue("@Year", year.Value.ToString());
              

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Records successfully added");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*jpg";
            DialogResult res = openFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnViewnew_Click(object sender, EventArgs e)
        {
            
            ViewStudents frm = new ViewStudents();
            frm.Show();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "M";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "F";
        }

        private void txtKCPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void txtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSubject_Click(object sender, EventArgs e)
        {
            PopUpWindow frm = new PopUpWindow();
            frm.Show();
        }
    }
}
