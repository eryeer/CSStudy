using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalc
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate() {
            float Amount = float.Parse(this.txtAmount.Text);
            float Int_rate = float.Parse(this.txtInterest.Text) / 100;
            float AmountAfter = Amount * (Int_rate + 1);
            this.txtAmountAfterOneYear.Text = AmountAfter.ToString();
        }
    }
}
