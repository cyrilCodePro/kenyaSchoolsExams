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
    public partial class ExamBlankMarkSheet : Form
    {
        public ExamBlankMarkSheet()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ExamBlankMarkSheet_Load(object sender, EventArgs e)
        {
         

        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ExamsMarkSheetBlankTableAdapter.FillBy(this.iTechData.ExamsMarkSheetBlank, comboStream.Text, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ExamsMarkSheetBlankTableAdapter.FillBy(this.iTechData.ExamsMarkSheetBlank, comboStream.Text, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
