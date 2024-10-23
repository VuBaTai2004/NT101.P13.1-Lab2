using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_Task1._1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_PrimeNum_Click(object sender, EventArgs e)
        {
            PrimeNumber a = new PrimeNumber();
            a.Show();
        }

        private void btn_GCD_Click(object sender, EventArgs e)
        {
            GCD a = new GCD();
            a.Show();
        }

        private void ModulusExponent_Click(object sender, EventArgs e)
        {
            ModularExponentiation a = new ModularExponentiation();
            a.Show();
        }
    }
}
