using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTech
{
    public partial class SchoolManagement : Form
    {
        SqlDataAdapter cmd;
        SqlConnection cn = new SqlConnection("Data Source = CYRIL\\SQLEXPRESS; Initial Catalog = DIGITAL; Integrated Security = True; Connect Timeout = 30");
        
        public SchoolManagement()
        {
            InitializeComponent();
        }

        private void SchoolManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update The Records.The Action is irreversible.Sit down and make up your mind or contact The Exam officer before next step", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
            {

                try
                {
                    cn.Open();
                    cmd = new SqlDataAdapter("GenerateMarksheet", cn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Year",textYear.Text );
                    cmd.SelectCommand.Parameters.AddWithValue("@Cat", texCatName.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@Term", textTerm.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@RollBack", "1");
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
            else
            {
                MessageBox.Show("Bingo Thanks for maintainng sanity");
            }
        }

        private void texCatName_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textTerm_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textYear_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (checkRevert.Checked == false)
            {
                MessageBox.Show("Please Click the revert checkbox");
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlDataAdapter("GenerateMarksheet", cn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Year", textYear.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@Cat", texCatName.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@Term", textTerm.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@RollBack", "2");
                    
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    MessageBox.Show("Reverted");


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


