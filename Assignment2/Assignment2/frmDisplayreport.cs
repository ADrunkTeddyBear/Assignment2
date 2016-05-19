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
    public partial class frmDisplayreport : Form
    {
        public frmDisplayreport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectionPage Selection = new frmSelectionPage();
            Selection.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String[] item = new String[Program.Count()];
            String[] quantity = new String[Program.Count()];
            String[] prices = new String[Program.Count()];
            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Stock.txt");
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                String[] text = line.Split(',');
                item[count] = text[0];
                quantity[count] = text[1];
                prices[count] = text[2];
                count++;
            }
            file.Close();

            for (int i = 0; i < item.Length; i++)
            {
                lstReport.Items.Add(item[i] + "\t"+quantity[i]);
            }
        }
    }
}
