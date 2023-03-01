using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miVentana=new Form2();

            miVentana.ShowDialog();
            lblNombre.Text = "Hola: " + miVentana.Nombre +" " + miVentana.Apellido;
        }
    }
}
