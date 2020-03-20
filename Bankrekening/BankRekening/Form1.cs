using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRekening
{
    public partial class Form1 : Form
    { 
        BankRekening bankrekening = new BankRekening(100);
        public Form1()
        {
            InitializeComponent();
            UpdateSaldo();
        }

        private void storten_Click(object sender, EventArgs e)
        {
            bankrekening.StortenSaldo(int.Parse(textBox1.Text));
            UpdateSaldo();
        }

        public void UpdateSaldo()
        {
            if (bankrekening.Saldo < 0)
            {
                label1.ForeColor = Color.Red;
                label1.Text = bankrekening.ToString();
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = bankrekening.ToString();
            }
        }

        private void afhalen_Click_1(object sender, EventArgs e)
        {
            bankrekening.AfhalenSaldo(int.Parse(textBox1.Text));
            UpdateSaldo();

        }
    }
}
