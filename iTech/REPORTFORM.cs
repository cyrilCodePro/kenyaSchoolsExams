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
    public partial class REPORTFORM : Form
    {
        public REPORTFORM()
        {
            InitializeComponent();
        }

        private void REPORTFORM_Load(object sender, EventArgs e)
        {
         
        }

        private void reportTestToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void textADM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.iTechRePortTableAdapter.ReportTest(this.iTechData.iTechRePort, new System.Nullable<int>(((int)(System.Convert.ChangeType(textADM.Text, typeof(int))))));

                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
