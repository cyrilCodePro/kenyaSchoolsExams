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
    public partial class ROWTEST : Form
    {
        public ROWTEST()
        {
            InitializeComponent();
        }

        private void ROWTEST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.iTech' table. You can move, or remove it, as needed.
            
        }

        
        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.FillBy3(this.iTechData.iTech, comboSubject.Text, comboForm.Text, comboStream.Text);

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
                this.iTechTableAdapter.FillBy3(this.iTechData.iTech, comboSubject.Text, comboForm.Text, comboStream.Text);

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
                this.iTechTableAdapter.FillBy3(this.iTechData.iTech, comboSubject.Text, comboForm.Text, comboStream.Text);

                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
