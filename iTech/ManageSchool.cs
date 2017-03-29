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
using System.IO;

namespace iTech
{
    public partial class ManageSchool : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        public ManageSchool()
        {
            InitializeComponent();
        }

        private void ManageSchool_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.Stream' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stream (NAME,SYMBOL) values(@NAME,@SYMBOL)", con);
            cmd.Parameters.AddWithValue("@NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@SYMBOL", txtInitial.Text);
            cmd.ExecuteNonQuery();
            FillDatagRid();
            con.Close();

        }
        void FillDatagRid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID, NAME,SYMBOL  from Stream", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter();
                SqlCommandBuilder scb = new SqlCommandBuilder(cmd);
                DataTable data = new DataTable();
                cmd.Update(data);
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
               
                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select schoolName,Box,Area,Centre,Email,Logo from SchoolManage ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textSchool.Text = Convert.ToString(dr["schoolName"]);
                textBox.Text = Convert.ToString(dr["Box"]);
                textArea.Text = Convert.ToString(dr["Area"]);
                textPost.Text = Convert.ToString(dr["Centre"]);
                textEmail.Text = Convert.ToString(dr["Email"]);
                if (dr.HasRows)
                {
                    try
                    {
                        byte[] getImg = new byte[0];
                        getImg = (byte[])dr["Logo"];
                        byte[] img = getImg;
                        if (img == null)
                        {
                            pictureSchool.Image = null;

                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            pictureSchool.Image = Image.FromStream(mstream);
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("No  image found press ok to proceed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png))";
            DialogResult res = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Select school logo";
            if (res == DialogResult.OK)
            {
                pictureSchool.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureSchool.Image = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureSchool.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] pic = stream.ToArray();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("schoolManagement ", con);
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
            cmd.SelectCommand.Parameters.AddWithValue("@schoolName",textSchool.Text);
            cmd.SelectCommand.Parameters.AddWithValue("@Box", textBox.Text);
            cmd.SelectCommand.Parameters.AddWithValue("@Area", textArea.Text);
            cmd.SelectCommand.Parameters.AddWithValue("@Center", textPost.Text);
            cmd.SelectCommand.Parameters.AddWithValue("@Email", textPost.Text);
            cmd.SelectCommand.Parameters.AddWithValue("@Logo", pic);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            MessageBox.Show("Updated");
            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            DialogResult res = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Select school logo";
            if (res == DialogResult.OK)
            {
                pictureEmail.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                pictureEmail.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic = stream.ToArray();
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("PrincipalSchool ", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("@PrincipalName", textPrincipal.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@PrincipalSign", pic);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                MessageBox.Show("Updated");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select PrincipalName,PrincipalSign from SchoolManage ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textPrincipal.Text = Convert.ToString(dr["PrincipalName"]);
         

                if (dr.HasRows)
                {
                    try
                    {
                        byte[] getImg = new byte[0];
                        getImg = (byte[])dr["principalSign"];
                        byte[] img = getImg;
                        if (img == null)
                        {
                            pictureEmail.Image = null;

                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            pictureEmail.Image = Image.FromStream(mstream);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No  image found press ok to proceed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

