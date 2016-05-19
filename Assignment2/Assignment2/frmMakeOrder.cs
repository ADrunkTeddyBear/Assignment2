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
    public partial class frmMakeOrder : Form
    {
        public frmMakeOrder()
        {
            InitializeComponent();
            lstItems.SelectionMode = SelectionMode.MultiExtended; // from Microsoft Dev Network https://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.selectionmode(v=vs.110).aspx
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
                lstItems.Items.Add(item[i]+"\t\tR"+prices[i]);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectionPage Selection = new frmSelectionPage();
            Selection.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String[] item = new String[Program.Count()];
            String[] quantity = new String[Program.Count()];
            String[] prices = new String[Program.Count()];
            String line;
            int[] quantities = new int[Program.Count()];

            System.IO.StreamReader file = new System.IO.StreamReader("Stock.txt");
            int count = 0;
            int temp;
            int price;

            while ((line = file.ReadLine()) != null)
            {
                String[] text = line.Split(',');
                item[count] = text[0];
                quantity[count] = text[1];
                prices[count] = text[2];
                count++;
            }
            file.Close();

            string[,] cart = new string[Program.Count(), Program.Count()];
            int[] index = new int[Program.Count()];
            int counter = 0;
            int total = 0;

            foreach (int Index in lstItems.SelectedIndices )
            {
                index[counter] = Index;
                counter++; 
            }

            for (int i = 0; i <counter; i++)
            {
                temp = index[i];
                price = int.Parse(prices[temp]);
                int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Please enter the number of"+item[temp]),out quantities[i]);
                total = total + (price * quantities[i]);
            }
            MessageBox.Show("Your total is R"+total);

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("Stock.txt"))
            {
                for (int j = 0; j < item.Length; j++)
                {
                    writer.WriteLine(item[j] + "," + quantity[j] + "," + prices[j]);
                }
            }
        }
    }
}
