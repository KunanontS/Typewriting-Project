using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class WPM : Form
    {
        public WPM()
        {
            InitializeComponent();
            show_wpm.Text = E_25.wpm.ToString();
            show_acc.Text = E_25.acc.ToString() + "%";
        }
        private void Detail(Graphics g)
        {
            Font myFont = new Font("Cordia New", 100);
            int yline = 380;
            int yspace = 150;
            g.DrawString("CERTIFICATE", myFont, Brushes.Gold, 100, 50);
            g.DrawString("of practicing", new Font("Cordia New", 70), Brushes.Gold, 205, 145);
            g.DrawString("//________________ (◍•ᴗ•◍)❤ _______________\\\\", new Font("Cordia New", 38), Brushes.LightPink, 0, 300);
            g.DrawString("                          ❤                    ", new Font("Cordia New", 38), Brushes.Red, 210, 300);
            g.DrawString("WPM : ", myFont, Brushes.BlueViolet, 140, yline);
            g.DrawString(E_25.wpm.ToString(), myFont, Brushes.BlueViolet, 500, yline);
            yline += yspace;
            g.DrawString("ACC : ", myFont, Brushes.Coral, 140, yline);
            g.DrawString(E_25.acc.ToString(), myFont, Brushes.Coral, 500, yline);
            g.DrawString("%", myFont, Brushes.Coral, 650, yline);
            yline += 200;
            g.DrawString("//____________ *+:꒰◍•ᴗ•◍꒱:+* ______________\\\\", new Font("Cordia New", 38), Brushes.LightPink, 0, yline);
            yline += yspace;
            g.DrawString("A test by PaoType", new Font("Cordia New", 20), Brushes.Black, 330, yline);
        }
        private void save_result_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Detail(e.Graphics);
        }
        private void show_wpm_Click(object sender, EventArgs e)
        {

        }
        private void WPM_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            E_25 back = new E_25();
            back.ShowDialog();
            this.Close();
        }
    }
}
