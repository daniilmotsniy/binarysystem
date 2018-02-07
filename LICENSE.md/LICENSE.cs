using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        int num;
        Int64 BinaryHolder;
        char[] BinaryArray;
        string BinaryResult = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {
            this.num = Int32.Parse(textBox_Result.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            while (num > 0)
            {
                BinaryHolder = num % 2;
                BinaryResult += BinaryHolder;
                num = num / 2;
            }

            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);
            label1.Text += BinaryResult;

        }

        }
    }
