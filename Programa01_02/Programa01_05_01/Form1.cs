using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, r = 0 ;

            a= Convert.ToDouble(txtA);
            b= Convert.ToDouble(txtB);

            if(rbSumar.Checked==true)
            {
                r = a + b;
            }
            if (rbRestar.Checked == true)
            {
                r = a - b;
            }
            if (rbMulti.Checked == true)
            {
                r = a * b;
            }
            if (rbDividir.Checked == true)
            {
                r = a / b;
            }

            lblResultado.Text = "Resultado: " +r.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = " ";
        }
    }
}
