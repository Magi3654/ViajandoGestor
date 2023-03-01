using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = " ";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a, b, res; 
            a=Convert.ToDouble(txtA.Text);
            b=Convert.ToDouble(txtB.Text);
            res = a + b;
            
            lblResult.Text=res.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a, b, res;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            res = a - b;

            lblResult.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double a, b, res;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            res = a * b;

            lblResult.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a, b, res;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            res = a / b;

            lblResult.Text = res.ToString();
        }
    }
}
