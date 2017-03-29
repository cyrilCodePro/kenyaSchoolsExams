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
    public partial class EndTermAnalysis : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=CYRIL;Initial Catalog=DIGITAL;Integrated Security=True");
        SqlDataAdapter cmd;
        
        public EndTermAnalysis()
        {
            InitializeComponent();
        }

        private void btnMerit_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
               SqlCommand upate= new SqlCommand("TermReport", cn);
                upate.CommandType = CommandType.StoredProcedure;
                upate.CommandTimeout = 300;

                upate.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
            MeritListEndTerm frm = new MeritListEndTerm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubjChamps_Click(object sender, EventArgs e)
        {
            EndTermSubjectChamps frm = new EndTermSubjectChamps();
            frm.Show();
        }

        private void btnSubjClass_Click(object sender, EventArgs e)
        {
            SubjectMean frm = new SubjectMean();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeanForm frm = new MeanForm();
            frm.Show();
        }

        private void btnTopClass_Click(object sender, EventArgs e)
        {
            TopTenForms frm = new TopTenForms();
            frm.Show();
        }
    }
}
