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
    public partial class TESTREPORT : Form
    {
        public TESTREPORT()
        {
            InitializeComponent();
        }

        private void TESTREPORT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTechData.iTechRePort' table. You can move, or remove it, as needed.
            this.iTechRePortTableAdapter.Fill(this.iTechData.iTechRePort);

            this.reportViewer1.RefreshReport();
        }
    }
}
