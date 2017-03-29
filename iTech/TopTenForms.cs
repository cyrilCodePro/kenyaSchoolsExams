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
    public partial class TopTenForms : Form
    {
        public TopTenForms()
        {
            InitializeComponent();
        }

        private void TopTenForms_Load(object sender, EventArgs e)
        {
           

           
        }

       
private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.TermTableAdapter.FillBy1(this.iTechData.Term, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
