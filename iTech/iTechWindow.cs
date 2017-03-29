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
    public partial class iTechWindow : Form
    {
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataTable data;
        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        public iTechWindow()
        {
           
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MarkSheetGenerate frm = new MarkSheetGenerate();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(data);
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Id, ADM,Name,subjectMark as '" + comboSubject.Text + "' from iTech where SUBJECT='" + comboSubject.Text + "' and FORM='" + comboForm.Text + "' and stream='" + comboStream.Text + "' order by ADM ASC ", cn);

                data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                da = new SqlDataAdapter("SELECT Id, ADM,Name,subjectMark as '" + comboSubject.Text + "' from iTech where SUBJECT='" + comboSubject.Text + "' and FORM='" + comboForm.Text + "'   and stream='" + comboStream.Text + "' order by ADM ASC ", cn);

                data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Id, ADM,Name,subjectMark as '" + comboSubject.Text + "' from iTech where SUBJECT='" + comboSubject.Text + "' and FORM='" + comboForm.Text + "'   and stream='" + comboStream.Text + "' order by ADM ASC ", cn);

                data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Id, ADM,Name,subjectMark as '" + comboSubject.Text + "' from iTech where SUBJECT='" + comboSubject.Text + "' and FORM='" + comboForm.Text + "'   and stream='" + comboStream.Text + "' order by '"+comboOrder.Text+"' ASC ", cn);

                data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void iTechWindow_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
