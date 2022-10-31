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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();        
        }
        private void c_e_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_25 c_eng = new E_25();
            c_eng.ShowDialog();
            this.Close();
        }
        private void c_t_Click(object sender, EventArgs e)
        {
            this.Hide();
            T_10 c_t = new T_10();
            c_t.ShowDialog();
            this.Close();
        }
        private void main_Load(object sender, EventArgs e)
        {            
        }
    }
}
