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
    public partial class ViewStudents : Form
    {
        SqlDataAdapter cmd;
        SqlCommandBuilder scb;
        DataTable data;
        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
           

        }
       

    private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGender.Text = "";
         try
            {

                cn.Open();
                 cmd = new SqlDataAdapter("SELECT Name,BIRTH,KCPE,ADM,RESIDENCE,PARENTS,PHONE,EMAIL,FORM,STREAM,GENDER from AddStudents where FORM='" + comboForm.Text + "' and stream='" + comboStream.Text + "'", cn);
                 data = new DataTable();
                cmd.Fill(data);
                dataGridView1.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();

        }

        private void comboStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGender.Text = "";
            try
            {

                cn.Open();
                 cmd = new SqlDataAdapter("SELECT Name,BIRTH,KCPE,ADM,RESIDENCE,PARENTS,PHONE,EMAIL,FORM,STREAM,GENDER from AddStudents where FORM='" + comboForm.Text + "' and stream='" + comboStream.Text + "'", cn);
                data = new DataTable();
                cmd.Fill(data);
                dataGridView1.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                DataGridViewRow  row = this.dataGridView1.Rows[e.RowIndex];
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                txtDOB.Text = row.Cells["BIRTH"].Value.ToString();
                txtKCPE.Text = row.Cells["KCPE"].Value.ToString();
                txtAdm.Text = row.Cells["ADM"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtParents.Text = row.Cells["PARENTS"].Value.ToString();
                txtPhone.Text = row.Cells["PHONE"].Value.ToString();
                txtResidence.Text = row.Cells["RESIDENCE"].Value.ToString();
                

            }
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                cmd = new SqlDataAdapter("SELECT Name,BIRTH,KCPE,ADM,RESIDENCE,PARENTS,PHONE,EMAIL,FORM,STREAM,GENDER from AddStudents where FORM='" + comboForm.Text + "' and stream='" + comboStream.Text + "' and GENDER='" + comboGender.Text + "'", cn);
                data = new DataTable();
                cmd.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
            scb = new SqlCommandBuilder(cmd);
                cmd.Update(data);
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAdm.Text == "" || txtStudentName.Text == "")
            {
                MessageBox.Show("Please click on the name to delete");
            }
            else
            {
                try
                {
                    cn.Open();
                    SqlCommand smd = new SqlCommand("delete from AddStudents where Name='" + txtStudentName.Text + "'and Adm='" + txtAdm.Text + "' ", cn);
                    smd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Deleted");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    
        }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StudentsInSystem frm = new StudentsInSystem();
            frm.Show();
        }
    }
}
