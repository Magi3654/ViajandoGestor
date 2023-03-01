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
    public partial class Form2 : Form
    {
        private string nombre;
        private string apellido;

        public Form2()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido}
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido=txtApellido.Text;
            this.Close();
        }
    }
}
