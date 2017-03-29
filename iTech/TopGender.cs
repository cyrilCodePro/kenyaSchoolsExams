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
    public partial class TopGender : Form
    {
        public TopGender()
        {
            InitializeComponent();
        }

        private void TopGender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.Cats' table. You can move, or remove it, as needed.
            this.CatsTableAdapter.Fill(this.iTechData.Cats);

        }

        private void tOPGENDERToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsTableAdapter.FillBy2(this.iTechData.Cats, comboForm.Text, comboGender.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CatsTableAdapter.FillBy2(this.iTechData.Cats, comboForm.Text, comboGender.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

      
    }
}
