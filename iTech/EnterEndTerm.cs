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
    public partial class EnterEndTerm : Form
    {
        SqlDataAdapter da;
        DataTable data;
        SqlCommandBuilder scb;
        SqlConnection cn = new SqlConnection("Data Source=CYRIL\\SQLEXPRESS;Initial Catalog=DIGITAL;Integrated Security=True;Connect Timeout=30");

        public EnterEndTerm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnterEndTerm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            if (comboForm.Text == "" || comboStream.Text == "" || comboYear.Text == "") 
            {
                MessageBox.Show("Please select Form and stream and Year");
            }
            else
            {
                try
                {
                    cn.Open();
                    da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Exams where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "'", cn);
                    data = new DataTable();
                    da.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {


                SqlCommand cmd = new SqlCommand("Insert into Exams (Name,ADM,KCPE,STREAM,FORM,Year,Gender)  SELECT  Name,ADM,KCPE,STREAM,FORM,Year,Gender from AddStudents  where ADM NOT IN(select ADM from Exams)", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bingo!MarkSheet Genrated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cn.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Insert into ExamsMarkSheetBlank (Name,ADM,KCPE,STREAM,FORM,Year,Gender)  SELECT  Name,ADM,KCPE,STREAM,FORM,Year,Gender from AddStudents  where ADM NOT IN(select ADM from ExamsMarkSheetBlank)", cn);
                cmd.ExecuteNonQuery();
                ExamBlankMarkSheet frm = new ExamBlankMarkSheet();
                frm.Show();
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cn.Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {

            if (comboForm.Text == "" || comboStream.Text == "" || comboYear.Text == "")
            {
                MessageBox.Show("Please select Form and stream and Year");
            }
            else
            {


                scb = new SqlCommandBuilder(da);
                da.Update(data);
                try
                {
                    cn.Open();
                    da = new SqlDataAdapter("EXAMSGRADING", cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    data = new DataTable();
                    da.Fill(data);
                    MessageBox.Show(" Bingo! Graded");
                    cn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Exams where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "' ORDER BY ADM", cn);
                data = new DataTable();
                da.Fill(data);
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
            try
            {
                cn.Open();
                da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Exams where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "' ORDER BY ADM", cn);
                data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
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

        private void comboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboOrder.Text=="Name")
            {
                try
                {
                    cn.Open();
                    da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Exams where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "' ORDER BY Name", cn);
                    data = new DataTable();
                    da.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
            }
            else
            {
                try
                {
                    cn.Open();
                    da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Exams where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "' ORDER BY ADM", cn);
                    data = new DataTable();
                    da.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
            }
        }
    }
}
