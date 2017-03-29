using System;
using System.Data;
using System.Drawing;
using System.Linq;using System.Collections.Generic;
using System.ComponentModel;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace iTech
{
    public partial class PopUpWindow : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        public PopUpWindow()
        {
            InitializeComponent();
        }


        private void PopUpWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textADM_TextChanged(object sender, EventArgs e)
        {





        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Name,GENDER,STREAM,Image from AddStudents where ADM='" + textADM.Text + "' and FORM='" + comboForm.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textName.Text = Convert.ToString(dr["Name"]);
                textGender.Text = Convert.ToString(dr["GENDER"]);
                comboSTREAM.Text = Convert.ToString(dr["STREAM"]);
                if (dr.HasRows)
                {

                    byte[] getImg = new byte[0];
                    getImg = (byte[])dr["Image"];
                    byte[] img = getImg;
                    if (img == null)
                    {
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(mstream);
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            else
            {
                MessageBox.Show("Now Data Found");
            }
            cn.Close();
        }

        private void comboSTREAM_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Name,GENDER,STREAM,FORM from AddStudents where ADM='" + textADM.Text + "'  ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textName.Text = Convert.ToString(dr["Name"]);
                textGender.Text = Convert.ToString(dr["GENDER"]);
                comboSTREAM.Text = Convert.ToString(dr["STREAM"]);
                comboForm.Text = Convert.ToString(dr["FORM"]);
            }

            else
            {
                MessageBox.Show("No Data Found");
            }
            
            cn.Close();
        
    }
        

        private void checkMath_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkEng_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void checkKis_CheckedChanged(object sender, EventArgs e)
        {
        
            

        }

        private void checkChem_CheckedChanged(object sender, EventArgs e)
        {
            
           

        }

        private void checkBio_CheckedChanged(object sender, EventArgs e)
        {
         
            

        }

        private void checkPhy_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkHist_CheckedChanged(object sender, EventArgs e)
        {
           
            

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkGeo_CheckedChanged(object sender, EventArgs e)
        {
            
          


        }

        private void checkCre_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void checkAgr_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBst_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textADM.Text == "" || textName.Text == "" || comboForm.Text == "" || textGender.Text == "" || comboSTREAM.Text == "")
            {
                MessageBox.Show("Please Check for a student using ADM");
            }
            else
            {
                cn.Open();
               


                    if (checkAgr.Checked)
                    {

                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT)", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "AGR");
                        cmd.ExecuteNonQuery();
                        checkAgr.Checked = false;

                    }
                    if (checkBio.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "BIO");
                        cmd.ExecuteNonQuery();

                        checkBio.Checked = false;

                    }
                    if (checkChem.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "CHEM");
                        cmd.ExecuteNonQuery();

                        checkChem.Checked = false;

                    }
                    if(checkMath.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "MAT");
                        cmd.ExecuteNonQuery();

                        checkMath.Checked = false;
                    }
                    if (checkKis.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT)", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT","KIS" );
                        cmd.ExecuteNonQuery();
                        checkKis.Checked = false;
                    }
                    if (checkEng.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT)", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "ENG");
                        cmd.ExecuteNonQuery();

                        checkEng.Checked = false;
                    }
                    if (checkPhy.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "PHY");
                        cmd.ExecuteNonQuery();

                        checkPhy.Checked = false;
                    }
                    if (checkGeo.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT)", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "GEO");
                        cmd.ExecuteNonQuery();

                        checkGeo.Checked = false;
                    }
                    if (checkHist.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "HIST");
                        cmd.ExecuteNonQuery();
                        checkHist.Checked = false;
                    }
                    if (checkBst.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "BST");
                        cmd.ExecuteNonQuery();
                        checkBst.Checked = false;
                    }
                    if (checkCre.Checked)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT  INTO iTech(Name,ADM,FORM,STREAM,GENDER,SUBJECT) VALUES (@Name,@ADM,@FORM,@STREAM,@GENDER,@SUBJECT) ", cn);
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@ADM", textADM.Text);
                        cmd.Parameters.AddWithValue("@FORM", comboForm.Text);
                        cmd.Parameters.AddWithValue("@STREAM", comboSTREAM.Text);
                        cmd.Parameters.AddWithValue("@GENDER", textGender.Text);
                        cmd.Parameters.AddWithValue("@SUBJECT", "CRE");
                        cmd.ExecuteNonQuery();
                        checkCre.Checked = false;
                    }  
                }

                cn.Close();
            
            MessageBox.Show("Record Updated");

        }
       

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (textADM.Text == "" || textName.Text == "" || comboForm.Text == "" || textGender.Text == "" || comboSTREAM.Text == "")
            {
                MessageBox.Show("Please Check for a student using ADM");
            }
            else
            {
                if (checkAll.Checked == true)
                {
                    checkAgr.Checked = true;
                    checkBio.Checked = true;
                    checkBst.Checked = true;
                    checkChem.Checked = true;
                    checkCre.Checked = true;
                    checkHist.Checked = true;
                    checkMath.Checked = true;
                    checkPhy.Checked = true;
                    checkKis.Checked = true;
                    checkGeo.Checked = true;
                    checkEng.Checked = true;

                }

            }
        }
    }
        }
    


