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
    public partial class TopPerSubject : Form
    {
        public TopPerSubject()
        {
            InitializeComponent();
        }

        private void TopPerSubject_Load(object sender, EventArgs e)
        {

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy4(this.iTechData.iTech, comboSubject.Text, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy4(this.iTechData.iTech, comboSubject.Text, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
