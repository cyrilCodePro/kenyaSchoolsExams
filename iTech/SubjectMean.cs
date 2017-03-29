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
    public partial class SubjectMean : Form
    {
        public SubjectMean()
        {
            InitializeComponent();
        }

        private void SubjectMean_Load(object sender, EventArgs e)
        {
        }


        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.MEANSUBJECTTableAdapter.FillBy(this.iTechData.MEANSUBJECT, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
    }
}
