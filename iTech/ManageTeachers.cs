using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace iTech
{
    public partial class ManageTeachers : Form
    {
        SqlDataAdapter cmd;
        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");

        public ManageTeachers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageTeachers_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlDataAdapter("TeachersData", cn);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("@Initials", textInitials.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@Name", textTeachersName.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@Form", comboForm.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@Stream", comboStream.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@Subject", comboSubject.Text);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                MessageBox.Show("updated");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ClassTeacher set Name='"+comboClassTeachersName.Text+"' where FORM='"+comboClass.Text+"' AND STREAM='"+comboBox1.Text+"'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("UPDATED");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            { 

            SqlCommand cmd = new SqlCommand("Select Name,Initial from Teachers where SUBJECT='" + comboSubject.Text + "' and FORM='" + comboForm.Text + "' AND STREAM='"+comboStream.Text +"'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textTeachersName.Text = Convert.ToString(dr["Name"]);
               textInitials.Text = Convert.ToString(dr["Initial"]);
               
            }
            else
            {
                MessageBox.Show("No Data Found Update Records");
            }
            cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void comboClassTeachersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Select DISTINCT Name FROM Teachers WHERE NAME IS NOT NULL ORDER BY NAME ASC ", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboClassTeachersName.Items.Add(dr["Name"]);
                }
                dr.Close();
                dr.Dispose();


                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }
    }
}
        

