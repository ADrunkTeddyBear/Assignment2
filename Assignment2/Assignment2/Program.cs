using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTermsAndConditions());
            
    }
        

       
        


        public static int Count()
        {
            int counter = 0;
            counter = File.ReadLines("Stock.txt").Count();
            return counter;
        }

        public static void Update(String[] brand, String[] quantity, String[] prices)//writes updated content to txt file
        {
            using (StreamWriter writer = new StreamWriter("Stock.txt"))
            {
                for (int j = 0; j < brand.Length; j++)
                {
                    writer.WriteLine(brand[j] + "," + quantity[j] + "," + prices[j]);
                }
            }
        }
    }
}
