using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pago=0.0;

            if (chbMonitor.Checked == true)
            {
                pago = pago +250;
            }
            if (chbTeclado.Checked == true)
            {
                pago = pago + 15;
            }
            if (chbMouse.Checked == true)
            {
                pago = pago + 10;
            }
            MessageBox.Show("El total es: " + pago.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSeleccion.Text = " ";
        }

        private void chbMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMonitor.Checked == true)
            {
                lblSeleccion.Text = "Has seleccionado un Monitor"; 
            }
            else
            {
                lblSeleccion.Text = " ";
            }
        }

        private void chbTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTeclado.Checked == true)
            {
                lblSeleccion.Text = "Has seleccionado un teclado";
            }
            else
            {
                lblSeleccion.Text = " ";
            }
        }

        private void chbMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMouse.Checked == true)
            {
                lblSeleccion.Text = "Has seleccionado un mouse ";
            }
            else
            {
                lblSeleccion.Text = " ";
            }
        }
    }
}
