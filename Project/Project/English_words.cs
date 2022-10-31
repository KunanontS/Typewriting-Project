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
    public partial class English_words : Form
    {
        public English_words()
        {
            InitializeComponent();
        }

        private void back_e_Click(object sender, EventArgs e)
        {
            this.Hide();
            main c_eng = new main();
            c_eng.ShowDialog();
            this.Close();
        }

        private void e_10_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_10 c_e10 = new E_10();
            c_e10.ShowDialog();
            this.Close();

        }

        private void e_25_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_25 c_e25 = new E_25();
            c_e25.ShowDialog();
            this.Close();
        }

        private void e_50_Click(object sender, EventArgs e)
        {
        }
    }
}
