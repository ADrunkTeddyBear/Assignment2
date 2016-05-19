using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class frmTermsAndConditions : Form
    {
        public frmTermsAndConditions()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (cbxTermsAndConditions.Checked)
            {
                this.Hide();
                frmSelectionPage frmSelection = new frmSelectionPage();
                frmSelection.ShowDialog();
                this.Close();
            }
            if (cbxExit.Checked)
            {
                Environment.Exit(0);
            }
        }
        private void cbxExit_CheckedChanged(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
        }
    }
}
