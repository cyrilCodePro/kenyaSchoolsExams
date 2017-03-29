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
    public partial class iTechTest : Form
    {
        SqlConnection cn=new SqlConnection("Data Source = CYRIL\\SQLEXPRESS; Initial Catalog = DIGITAL; Integrated Security = True; Connect Timeout = 30");
        public iTechTest()
        {
            InitializeComponent();
        }

        private void iTechTest_Load(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
        }

     

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy(this.iTechData.iTech, comboForm.Text, comboSubject.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy(this.iTechData.iTech, comboForm.Text, comboSubject.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
