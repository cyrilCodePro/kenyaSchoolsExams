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
    public partial class ExamsHistory : Form
    {
        public ExamsHistory()
        {
            InitializeComponent();
        }

        private void ExamsHistory_Load(object sender, EventArgs e)
        {
           

            
        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsHistoryTableAdapter.FillBy(this.iTechData.CatsHistory, comboForm.Text, comboCat.Text, comboTerm.Text, textYear.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsHistoryTableAdapter.FillBy(this.iTechData.CatsHistory, comboForm.Text, comboCat.Text, comboTerm.Text, textYear.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsHistoryTableAdapter.FillBy(this.iTechData.CatsHistory, comboForm.Text, comboCat.Text, comboTerm.Text, textYear.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsHistoryTableAdapter.FillBy(this.iTechData.CatsHistory, comboForm.Text, comboCat.Text, comboTerm.Text, textYear.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
