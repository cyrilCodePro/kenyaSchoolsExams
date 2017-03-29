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
    public partial class MeritListEndTerm : Form
    {
        public MeritListEndTerm()
        {
            InitializeComponent();
        }

        private void MeritListEndTerm_Load(object sender, EventArgs e)
        {
        

            
        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.TermTableAdapter.FillBy(this.iTechData.Term, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
