using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace LAB2_Task1._1
{
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
            MersennePrimeNumber();
        }

        private void MersennePrimeNumber()
        {
            int[] first10PrimeNum = { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89 };
            BigInteger[] mersennePrimeNum = new BigInteger[10];
            BigInteger[][] biggestPrimeNumberUnderMersenne = new BigInteger[10][];
            BigInteger temp;

            for (int i = 0; i < first10PrimeNum.Length; i++)
            {
                mersennePrimeNum[i] = Pow(2, first10PrimeNum[i]) - 1;
            }

            for (int i = 0; i < mersennePrimeNum.Length; i++)
            {
                biggestPrimeNumberUnderMersenne[i] = new BigInteger[10];
                for (int j = 0; j < 10; j++)
                {

                    if (mersennePrimeNum[i] == 3)
                    {
                        biggestPrimeNumberUnderMersenne[i][j] = 2;
                        break;
                    }

                    temp = 2;
                    if (j > 0)
                    {
                        if (mersennePrimeNum[i] - temp >= biggestPrimeNumberUnderMersenne[i][j - 1])
                        {
                            do
                            {
                                temp += 2;
                            } while (mersennePrimeNum[i] - temp >= biggestPrimeNumberUnderMersenne[i][j - 1]);
                        }
                    }
                    while (!MillerRabinTest(mersennePrimeNum[i] - temp, 10))
                    {
                        temp += 2;
                    }

                    if (mersennePrimeNum[i] - temp == 3)
                    {
                        biggestPrimeNumberUnderMersenne[i][j] = mersennePrimeNum[i] - temp;
                        if (j < 9)
                        {
                            biggestPrimeNumberUnderMersenne[i][j + 1] = 2;
                            break;
                        }
                    }


                    biggestPrimeNumberUnderMersenne[i][j] = mersennePrimeNum[i] - temp;
                }
            }

            rtb_Mersenne.Text += "\n Biggest 10 Prime Number Under First 10 Mersenne Prime Number: \n";
            for (int i = 0; i < 10; i++)
            {
                rtb_Mersenne.Text += mersennePrimeNum[i].ToString() + ": ";
                for (int j = 0; j < 10; j++)
                {
                    if (biggestPrimeNumberUnderMersenne[i][j] == 0) break;
                    rtb_Mersenne.Text += biggestPrimeNumberUnderMersenne[i][j].ToString() + " | ";
                }
                rtb_Mersenne.Text += "\n";
            }
            rtb_Mersenne.Text += "\n";

        }
        private static BigInteger Pow(int a, int n)
        {
            BigInteger result = a;
            for (int i = 1; i < n; i++)
            {
                result *= a;
            }

            return result;
        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            txtB_8bits.Text = GenerateRandomPrime(8).ToString();
            txtB_16bits.Text = GenerateRandomPrime(16).ToString();
            txtB_64bits.Text = GenerateRandomPrime(64).ToString();
        }
        private void btn_CkArInteger_Click(object sender, EventArgs e)
        {
            BigInteger input = BigInteger.Parse(txtB_ArInteger.Text);
            if (MillerRabinTest(input, 10))
            {
                MessageBox.Show(input.ToString() + " is prime !!!", "True");
            }
            else
            {
                MessageBox.Show(input.ToString() + " is not prime !!!", "False");
            }

        }
        public static bool ckInteger(BigInteger input)
        {
            BigInteger i = 2;
            while (input > i)
            {
                BigInteger temp = input % i;
                if (temp == 0) return false;
                i++;
            }
            return true;
        }
        public static BigInteger GenerateRandomPrime(int bits)
        {
            Random random = new Random();
            BigInteger prime;
            do
            {
                prime = GenerateRandomOddNumber(bits, random);
            } while (!MillerRabinTest(prime, 10)); // 10 rounds of testing for better accuracy

            return prime;
        }

        private static BigInteger GenerateRandomOddNumber(int bits, Random random)
        {
            byte[] bytes = new byte[bits / 8];
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] += 0x01; // Ensure it's odd
            /*bytes[0] |= 0x80; // Ensure it's at least of the specified bit length*/

            BigInteger result = new BigInteger(bytes);
            if (result < 1)
            {
                bytes[0] += 0x80;
                result = new BigInteger(bytes);
            }

            return result;
        }

        private static bool MillerRabinTest(BigInteger n, int k)
        {
            if (n < 2) return false;
            if (n != 2 && n % 2 == 0) return false;
            if (n == 2 || n == 3) return true;

            BigInteger s = 0;
            BigInteger d = n - 1;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            for (int i = 0; i < k; i++)
            {
                BigInteger a = RandomBigIntegerInRange(2, n - 2);
                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1) continue;

                bool composite = true;

                for (BigInteger r = 0; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == n - 1 || x == 1)
                    {
                        composite = false;
                        break;
                    }
                }

                if (composite) return false;
            }

            return true;
        }

        private static BigInteger RandomBigIntegerInRange(BigInteger min, BigInteger max)
        {
            Random random = new Random();
            byte[] bytes = max.ToByteArray();
            BigInteger result;

            do
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= 0x7F; // Ensure it's positive
                result = new BigInteger(bytes);
            } while (result < min || result >= max);

            return result;
        }

        
    }
}
