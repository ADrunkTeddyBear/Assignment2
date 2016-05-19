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
    public partial class frmSelectionPage : Form
    {
        public frmSelectionPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wanna exit?","Sure sure?", MessageBoxButtons.YesNoCancel);
            //if(DialogResult.Yes)
            //{

            //}
            Environment.Exit(0);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rbtCapture.Checked)
            {
                this.Hide();
                frmCaptureStock frmCapture = new frmCaptureStock();
                frmCapture.ShowDialog();
                this.Close();

            }
            else if (rbtOrder.Checked)
            {
                this.Hide();
                frmMakeOrder frmOrder = new frmMakeOrder();
                frmOrder.ShowDialog();
                this.Close();
            }
            else if (rbtReport.Checked)
            {
                this.Hide();
                frmDisplayreport frmReport = new frmDisplayreport();
                frmReport.ShowDialog();
                this.Close();

            }
        }

        private void rbtOrder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
