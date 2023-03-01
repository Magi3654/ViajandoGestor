using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_09
{
    public partial class Form2 : Form
    {
        public Form2(string pmsg)
        {
            InitializeComponent();
            lblMsg.Text = pmsg;
        }

        punlic string Mensaje
        {
            set
            {
                mensaje = value;
                lblMsg.Text = mensaje;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
