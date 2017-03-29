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
    public partial class MeanForm : Form
    {
        public MeanForm()
        {
            InitializeComponent();
        }

        private void MeanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.CLASSMEANS' table. You can move, or remove it, as needed.
            this.CLASSMEANSTableAdapter.Fill(this.iTechData.CLASSMEANS);

            this.reportViewer1.RefreshReport();
        }
    }
}
