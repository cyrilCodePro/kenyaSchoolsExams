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
    public partial class MarkSheetGenerate : Form
    {
        public MarkSheetGenerate()
        {
            InitializeComponent();
        }

        private void MarkSheetGenerate_Load(object sender, EventArgs e)
        {
           


        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy2(this.iTechData.iTech, comboForm.Text, comboStream.Text, comboSubject.Text);
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
                this.iTechTableAdapter.FillBy2(this.iTechData.iTech, comboForm.Text, comboStream.Text, comboSubject.Text);
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void year_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboCats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CatsMarkSheetBlankBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy2(this.iTechData.iTech, comboForm.Text, comboStream.Text, comboSubject.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
