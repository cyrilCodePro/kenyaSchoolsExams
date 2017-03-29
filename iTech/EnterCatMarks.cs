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
    public partial class EnterCatMarks : Form
    {
        SqlDataAdapter da;
        DataTable data;
        SqlCommandBuilder scb;
        SqlConnection cn = new SqlConnection("Data Source=CYRIL\\SQLEXPRESS;Initial Catalog=DIGITAL;Integrated Security=True;Connect Timeout=30");

        public EnterCatMarks()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (comboForm.Text == "" || comboStream.Text == "")
            {
                MessageBox.Show("Please select Form and stream and Year");
            }
            else
            {
                try
                {
                    cn.Open();
                    da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Cats where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "'", cn);
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

        private void EnterCatMarks_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {


                SqlCommand cmd = new SqlCommand("Insert into Cats (Name,ADM,KCPE,STREAM,FORM,Year)  SELECT  Name,ADM,KCPE,STREAM,FORM,Year from AddStudents  where ADM NOT IN(select ADM from Cats)", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bingo!MarkSheet Genrated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Insert into CatsMarkSheetBlank (Name,ADM,KCPE,STREAM,FORM,Year)  SELECT  Name,ADM,KCPE,STREAM,FORM,Year from AddStudents  where ADM NOT IN(select ADM from CatsMarkSheetBlank)", cn);
                cmd.ExecuteNonQuery();
                MarkSheetGenerate frm = new MarkSheetGenerate();
                frm.Show();
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cn.Close();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(da);
            da.Update(data);
            try
            {
                cn.Open();
                da = new SqlDataAdapter("GRADING", cn);
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

  

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void comboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboForm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Cats where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "'", cn);
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

        private void comboStream_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("Select Name,ADM ,KCPE,ENG,KIS,MATHS,CHEM,BIO,PHY,GEOG,HIST,CRE,AGRIC,BST from Cats where FORM='" + comboForm.Text + "' and STREAM='" + comboStream.Text + "'", cn);
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

        private void comboOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboOrder.Text == "Name")
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

            else {
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
