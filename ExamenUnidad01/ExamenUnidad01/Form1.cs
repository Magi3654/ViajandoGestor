using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreP.Text;
            String apellido = txtApellidoP.Text;

            double total = 0.0;
            double pago = 0.0;
            double anticipo = Convert.ToDouble(txtAnticipo.Text);

            if (chdBWine.Checked == true)
            {
                pago = pago + 1758;
                if (rbtYesA.Checked== true)
                {
                    pago = pago - anticipo;

                }
                if (rbNotA.Checked == true)
                {
                    pago = pago + 0;
                }
                
            }
            if (chdSea.Checked == true)
            {
                pago = pago + 875;

                if (rbtYesA.Checked == true)
                {
                    pago = pago - anticipo;
                }
                if (rbNotA.Checked == true)
                {
                    pago = pago + 0;
                }

                
            }

            Form2 cotizador = new Form2();
            cotizador.Show();
            //cotizador.txtQuote.Text = string.Format("Reservacion efectuada !", nombre, apellido, "Anticipo de: ", anticipo, "La reservacion tiene un saldo de: ", pago, Environment.NewLine);
            cotizador.txtQuote.Text ="¡Reservacion Efectuada!" + "   " + nombre + apellido +"    "+ "Anticipo: "+ txtAnticipo.Text + "   " + "La reservacion tiene un saldo pendiente de: " + pago.ToString();
           




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 cotizador = new Form2();
            cotizador.ShowDialog();

        }
    }
}
