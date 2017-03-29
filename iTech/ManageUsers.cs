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
    public partial class ManageUsers : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text =="" || txtUserName.Text== "" || txtConfirm.Text =="")
            {
                MessageBox.Show("Please fill the fields Null field not required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Text="";
                txtPassword.Text = "";
                txtUserName.Text = "";

            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                if(MessageBox.Show("Password Not Marching!", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) ==DialogResult.Retry)
                {
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                    
                }
                else
                {
                    txtConfirm.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                }
            }
            else
            {
                con = new SqlConnection("Data Source = CYRIL\\SQLEXPRESS; Initial Catalog = DIGITAL; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("INSERT INTO LOGIN(username,Password) VALUES (@username,@Password)", con);
                cmd.Parameters.AddWithValue("@username",txtUserName.Text );
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records successfully added");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
           Users.Items.Clear();
            con = new SqlConnection("Data Source = CYRIL\\SQLEXPRESS; Initial Catalog = DIGITAL; Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd = new SqlCommand("SELECT username from LOGIN ORDER by username ASC", con);
            con.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   Users.Items.Add(dr["username"]);
                }
                dr.Close();
                dr.Dispose();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

