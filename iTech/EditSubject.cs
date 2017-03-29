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
 
    public partial class EditSubject : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        public EditSubject()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
              SqlDataAdapter  da = new SqlDataAdapter("SELECT Id, ADM,Name,SUBJECT  from iTech where ADM='" + textADm.Text + "' ", con);
                
               DataTable data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedItem = new List<string>();

                DataGridViewRow drow = new DataGridViewRow();
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    drow = dataGridView1.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[4].Value) == true) //checking if checked or not.
                    {
                        string id = drow.Cells[0].Value.ToString();
                        selectedItem.Add(id); //If checked adding it to the list
                    }
                }
                con.Open();
                foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.
                {
                    SqlCommand cmd = new SqlCommand("delete from iTech where id='" + s + "'", con);
                    int result = cmd.ExecuteNonQuery();
                }
                con.Close();
               
                filldata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void filldata()
        {
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, ADM,Name,SUBJECT  from iTech where ADM='" + textADm.Text + "' ", con);

                DataTable data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSubject_Load(object sender, EventArgs e)
        {
           

        }
    }
}
