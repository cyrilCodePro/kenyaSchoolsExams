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
    public partial class MeanTestSubject : Form
    {
        public MeanTestSubject()
        {
            InitializeComponent();
        }

        private void MeanTestSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.iTech' table. You can move, or remove it, as needed.
            this.iTechTableAdapter.Fill(this.iTechData.iTech);

        
            
        }

      

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iTechTableAdapter.TEST(this.iTechData.iTech, comboForm.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
