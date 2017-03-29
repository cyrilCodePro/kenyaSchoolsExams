using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTech
{
    public partial class iTechSplash : Form
    {
        public iTechSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iTechSplash_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterCats_Click(object sender, EventArgs e)
        {
            iTechWindow frm = new iTechWindow();
                frm.Show();
        }

        private void btnEndTerm_Click(object sender, EventArgs e)
        {
            ExamsHistory frm = new ExamsHistory();
            frm.Show();
        }
        private void btnCatReports_Click(object sender, EventArgs e)
        {
            iTechTest frm = new iTechTest();
            frm.Show();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            StudentsData frm = new StudentsData();
            frm.Show();
        }

        private void btnEndTermReports_Click(object sender, EventArgs e)
        {
            EndTermAnalysis frm = new EndTermAnalysis();
            frm.Show();
        }

        private void pictureReportForm_Click(object sender, EventArgs e)
        {
            SubjectAnalysis frm=new SubjectAnalysis();
                frm.Show();
        }

        private void pictureUsers_Click(object sender, EventArgs e)
        {
            ManageUsers frm = new ManageUsers();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picturePrintReports_Click(object sender, EventArgs e)
        {
            ReportFormFinal frm = new ReportFormFinal();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            REPORTFORM frm = new REPORTFORM();
            frm.Show();
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            StudentsInSystem frm = new StudentsInSystem();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSchool frm = new ManageSchool();
            frm.Show();
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            ManageTeachers frm = new ManageTeachers();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditSubject frm = new EditSubject();
            frm.Show();
        }
    }

    

       
      
    
    }

