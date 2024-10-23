using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.AccessControl;

namespace LAB2_Task1._1
{
    public partial class GCD : Form
    {
        public GCD()
        {
            InitializeComponent();
        }

        private void btn_GCD_Click(object sender, EventArgs e)
        {
            BigInteger firstNum = BigInteger.Parse(txtB_First.Text);
            BigInteger secondNum = BigInteger.Parse(txtB_Second.Text);
            BigInteger result = FindGCD(firstNum, secondNum);
            if(result != 0)
            {
                txtB_Result.Text = result.ToString();
            }
            else
            {
                txtB_Result.Text = "1";
            }
        }
        private static BigInteger FindGCD(BigInteger firstNum, BigInteger secondNum)
        {
            BigInteger a = firstNum;
            BigInteger b = secondNum;
            BigInteger q;
            BigInteger r;
            BigInteger result;

            do
            {
                q = a / b;
                r = a % b;
                a = b;
                b = r;
            } while (b != 0);

            result = a;
            return result;
        }
    }
}
