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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn=new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select* from LOGIN where username='"+comboUserName.Text+"'and password='"+txtPassword.Text+"'",cn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            int count = 0;
            while(dr.Read())
            {
                count += 1;

            }
            if (count == 1)
            {
                MessageBox.Show("Welcome to the System","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
               iTechSplash frm = new iTechSplash();
                frm.Show();


            }
            else if(count>0)
            {
                MessageBox.Show("Duplicate Username and Password!","Message",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username and Password Incorrect", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            cn.Close();
            txtPassword.Clear();
           
        }

        private void btnUsers_Click(object sender, EventArgs e)
    
        {
            comboUserName.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT username from LOGIN ORDER by username ASC",cn);
            cn.Open();
            try
            {
                 SqlDataReader dr = cmd.ExecuteReader();
                 while(dr.Read())
                {
                comboUserName.Items.Add(dr["username"]);
                  }
                dr.Close();
                dr.Dispose();
               

        

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

           if( MessageBox.Show("Are you sure you want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}