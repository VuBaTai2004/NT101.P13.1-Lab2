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
    public partial class ModularExponentiation : Form
    {
        public ModularExponentiation()
        {
            InitializeComponent();
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            Int128 result = 1;
            int value = Convert.ToInt32(txtB_Value.Text);
            int exponent = Convert.ToInt32(txtB_Exponent.Text);
            int modulus = Convert.ToInt32(txtB_Modulus.Text);

            //Power
            for(int i = 0; i < exponent; i++)
            {
                result *= value;
            }

            result %= modulus;
            txtB_Result.Text = result.ToString();
        }
    }
}
