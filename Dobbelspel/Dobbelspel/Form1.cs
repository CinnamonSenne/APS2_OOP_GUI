using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelspel
{
    public partial class Form1 : Form
    {
        private const decimal START_GELD = 100.00m;
        private Geld geld;
        private Dobbelsteen dobbelsteen;

        public Form1()
        {
            InitializeComponent();
            geld = new Geld(START_GELD);
            label1.Text = geld.ToString();
            dobbelsteen = new Dobbelsteen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int worp = dobbelsteen.Gooi();
            pictureBox1.Image = Image.FromFile(@"C:\Users\senne\OneDrive - AP Hogeschool Antwerpen\Documenten\School\OOP\dobbelsteenpics\" + worp + ".png");
            if (geld.PasSaldoAan(worp) && geld.Saldo != 0)
                label1.Text = $"U hebt {worp} gegooid. {geld.ToString()}";
            else
            {
                label1.Text = "Geld is op";
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
