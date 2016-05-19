using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Assignment2
{
    public partial class frmCaptureStock : Form
    {
       
        public frmCaptureStock()
        {
            
            InitializeComponent();
            lstView.SelectionMode = SelectionMode.MultiExtended; // from Microsoft Dev Network https://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.selectionmode(v=vs.110).aspx
            
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectionPage Selection = new frmSelectionPage();
            Selection.ShowDialog();
            
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)

        {





            lstView.Items.Clear();
            int counter = 0;
            counter = File.ReadLines("Stock.txt").Count();
            String[] item = new String[Program.Count()];
            String[] quantity = new String[Program.Count()];
            string category = "";
            category = cmbCategory.Text;
          
            if (category.Equals("Cases"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("Cases.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if (category.Equals("CorrectionEquip"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("CorrectionEquip.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                    
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }   
            else if (category.Equals("CuttingAndSticking"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("CuttingAndSticking.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                    
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if (category.Equals("DesktopOrganises"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("DesktopOrganises.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                    
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if (category.Equals("PensPencilsAndMarkers"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("PensPencilsAndMarkers.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                    
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if (category.Equals("PunchAndStaples"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("PunchAndStaples.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                   
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if(category.Equals("RulersAndSetSquares"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("RulersAndSetSquares.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                    
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            else if (category.Equals("Stamps"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("Stamps.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                   
                }
                for (int i = 0; i < item.Length; i++)
                {
                    lstView.Items.Add(item[i] + "\t" + quantity[i]);
                }
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int temp = 0;
            String[] item = new String[Program.Count()];
            String[] quantity = new String[Program.Count()];
            int[] quantities = new int[Program.Count()];
            string category = "";
            int counter = 0;
            int[] index = new int[Program.Count()];
            category = cmbCategory.Text;
            if (category.Equals("Cases"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("Cases.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;
                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Correction Equipment"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("CorrectionEquip.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Cutting and sticking"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("CuttingAndSticking.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Desktop Organises"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("DesktopOrganises.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Pens, pencils and markers"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("PensPencilsAndMarkers.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Punches and staples"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("PunchAndStaples.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Rulers and set squares"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("RulersAndSetSquares.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            else if (category.Equals("Stamps"))
            {
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("Stamps.txt");
                int count = 0;

                while ((line = file.ReadLine()) != null)
                {
                    String[] text = line.Split(',');
                    item[count] = text[0];
                    quantity[count] = text[1];
                    count++;

                }
                foreach (int Index in lstView.SelectedIndices)
                {
                    index[counter] = Index;
                    counter++;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                temp = index[i];
                
                int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Please enter the number of" + item[temp]), out quantities[i]);
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(category+".txt"))
                {
                    for (int j = 0; j < item.Length; j++)
                    {
                        writer.WriteLine(item[j] + "," + quantity[j]);
                    }
                }
            }
        }
    }
    }

