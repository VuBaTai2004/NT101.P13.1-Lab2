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

namespace RSA_Cipher
{
    public partial class Form1 : Form
    {
        int pValue, qValue, eValue, nValue, phi_nValue, dValue = -1;
        List<BigInteger> listEncrypt;
        
        string symbol = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()-_=+[]{}:;',.<>? ";
        public Form1()
        {
            InitializeComponent();
        }
        //Kiểm tra số nguyên tố
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number;
         i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        //Tìm số nguyên tố thứ n
        public int NthPrime(int n)
        {
            int count = 0, number = 2;
            while (count < n)
            {
                if (IsPrime(number))
                    count++;
                number++;
            }
            return number - 1;
        }

        //Tìm UCLN
        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        //Tìm dValue 
        public int Find_d_Value(int e, int phi_n)
        {
            int d = 1;
            while( (e*d)%phi_n != 1)
            {
                d++;
            }

            return d;
        }

        //Encrypt
        public List<BigInteger> Encrypt(string plain)
        {
            List<BigInteger> result = new List<BigInteger>();
            try
            {
                BigInteger M = Convert.ToInt32(plain);
                BigInteger C = (BigInteger.Pow(M, eValue)) % nValue;
                result.Add(C);
            }
            catch
            {
                foreach(char x in plain)
                {
                    if (symbol.Contains(x))
                    {
                        BigInteger M = symbol.IndexOf(x);
                        BigInteger C = (BigInteger.Pow(M, eValue)) % nValue;
                        result.Add(C);
                    }
                }
            }
            return result;
        }

        //Decrypt
        public string Decrypt(string cipher)
        {
            string result = "";
            string[] s = cipher.Trim().Split(' ');

            foreach (string x in s)
            {
                BigInteger C = BigInteger.Parse(x);
                BigInteger M = (BigInteger.Pow(C, dValue)) % nValue;
                try
                {
                    result += symbol[(int)M];
                }
                catch
                {
                }
            }
            return result;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int p = NthPrime(rd.Next(10, 100));
            int q = NthPrime(rd.Next(10, 100));
            int phi_n = (p - 1) * (q - 1);

            //Tìm eValue 
            int evalue = NthPrime(rd.Next(10, 50));
            while ( UCLN(evalue, phi_n) != 1 || evalue > phi_n){
                evalue = NthPrime(rd.Next(10, 100));
            }
            
            txt_p.Text = p.ToString();
            txt_q.Text = q.ToString();
            txt_e.Text = evalue.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(txt_p.Text == string.Empty || txt_q.Text == string.Empty || txt_e.Text == string.Empty)
            {
                MessageBox.Show("Fill all blank!");
                return;
            }

            pValue = Convert.ToInt32(txt_p.Text);
            qValue = Convert.ToInt32(txt_q.Text);
            eValue = Convert.ToInt32(txt_e.Text);
            nValue = pValue * qValue;
            phi_nValue = (pValue - 1) * (qValue - 1);
            dValue = Find_d_Value(eValue, phi_nValue);

            lb_PU.Text = $"PU(n, e): ({nValue},{eValue})";
            lb_PR.Text = $"PR(d): ({dValue})";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (dValue == -1)
            {
                MessageBox.Show("You don't have a key to excute!");
                return;
            }

            listEncrypt = Encrypt(txtPlain.Text);
            string result = "";
            foreach (long x in listEncrypt)
            {
                result += x.ToString() + " ";
            }
            txtResult_Encrypt.Text = result;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (dValue == -1)
            {
                MessageBox.Show("You don't have a key to excute!");
                return;
            }

            txtResult_Decrypt.Text = Decrypt(txtCipher.Text);
        }
    }

}
