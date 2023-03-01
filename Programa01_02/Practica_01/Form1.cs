using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_01
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

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            String nombre = txtName1.Text;
            String equipamiento = " ";
            double total = 0.0;
            double pago = 0.0;
            double auto = Convert.ToDouble(txtBCosto.Text);

            if (rdBasico.Checked == true)
            {
                pago = pago + 500;

                if (chdBAire.Checked == true)
                {
                    pago = pago + 500;
                    equipamiento = equipamiento + "\n Con" + chdBAire.Text;
                }
                if (chdBEqSonido.Checked == true)
                {
                    pago = pago + 700;
                    equipamiento = equipamiento + "\nCon" + chdBEqSonido.Text;
                }
                txtBRespuesta.Text = "Cotizacion a nombre de: " + txtName1.Text + "\n Con seguro basico de $500.00 " + equipamiento + "\n Total de la cotización: " + pago;

            }
            if (rdbTerceros.Checked == true)
            {
                pago = pago + 700;
                if (chdBAire.Checked == true)
                {
                    pago = pago + 500;
                    equipamiento = equipamiento + "\n Con" + chdBAire.Text;
                }
                if (chdBEqSonido.Checked == true)
                {
                    pago = pago + 700;
                    equipamiento = equipamiento + "\nCon" + chdBEqSonido.Text;
                }
                txtBRespuesta.Text = "Cotizacion a nombre de: " + txtName1.Text + "\n Con seguro basico de $500.00 " + equipamiento + "\n Total de la cotización: " + pago;
            }
                
            if (rdbTotal.Checked == true)
            {
                pago = pago + 1000;
                if (chdBAire.Checked == true)
                {
                    pago = pago + 500;
                    equipamiento = equipamiento + "\n Con" + chdBAire.Text;
                }
                if (chdBEqSonido.Checked == true)
                {
                    pago = pago + 700;
                    equipamiento = equipamiento + "\nCon" + chdBEqSonido.Text;
                }
                txtBRespuesta.Text = "Cotizacion a nombre de: " + txtName1.Text + "\n Con seguro basico de $500.00 " + equipamiento + "\n Total de la cotización: " + pago;
            }
           

            pago = pago + auto;

            txtBRespuesta.Text = "La cotización de: " + txtName1.Text + "Con //seguro, //con equipo // total del la cotizacion: " + pago.ToString();


        }
    } 
    
}
