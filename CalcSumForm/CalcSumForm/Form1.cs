using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSumForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            String num1 = this.number1.Text;
            int n1 = Convert.ToInt32(num1); 
        }

        private void inputBox2_TextChanged(object sender, EventArgs e)
        {
            String num2 = this.number2.Text;
            int n2 = Convert.ToInt32(num2);
        }

        private void resulttBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void calc_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.num1 = int.Parse(number1.Text);
            calc.num2 = int.Parse(number2.Text);
            int result = calc.Add();
            add_result.Text = result.ToString();
        }
    }
}
