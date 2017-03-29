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
    public partial class EndTermSubjectChamps : Form
    {
        public EndTermSubjectChamps()
        {
            InitializeComponent();
        }

        private void EndTermSubjectChamps_Load(object sender, EventArgs e)
        {
          

         
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechRePortTableAdapter.FillBy(this.iTechData.iTechRePort, comboClass.Text, comboSubject.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechRePortTableAdapter.FillBy(this.iTechData.iTechRePort, comboClass.Text, comboSubject.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
