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
    public partial class SubjectAnalysis : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        SqlDataAdapter cmd;
       
        public SubjectAnalysis()
        {

            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)

        {
            Checking();

            CatsReport frm = new CatsReport();
            frm.Show();
        }

        private void btnMerit_Click(object sender, EventArgs e)
        {
            MeritListWindow frm = new MeritListWindow();
            frm.Show();
        }

        private void btnSubjClass_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
              SqlCommand  update = new SqlCommand("SubjectAnalysis", cn);
                update.CommandType = CommandType.StoredProcedure;
                update.CommandTimeout = 300;
                update.ExecuteNonQuery();
                SubjectMean frm = new SubjectMean();
                frm.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          
          
        }

        private void btnSubjChamps_Click(object sender, EventArgs e)
        {
            TopPerSubject frm = new TopPerSubject();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeanForm frm = new MeanForm();
            frm.Show();
        }

        private void btnTopClass_Click(object sender, EventArgs e)
        {
            TopStudent frm = new TopStudent();
                frm.Show();
        }

        private void btnTopGender_Click(object sender, EventArgs e)
        {
            TopGender frm = new TopGender();
            frm.Show();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            BottomClass frm = new BottomClass();
            frm.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
               
        }

        

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           



        }

        public void Checking()
        {
            try
            {
                cn.Open();
              SqlCommand  command = new SqlCommand("InsertMarksIntoCats", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 300;
                command.ExecuteNonQuery();
              
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

