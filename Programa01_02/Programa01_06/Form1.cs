using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estamos probando");
            //MessageBox.Show("Estamos probando", "Mensaje Prueba"); 
            DialogResult r= MessageBox.Show("Diferentes Botones", "Botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            if (r == DialogResult.Abort)
            {
                lbl1.Text = "Anular";
            }
            if (r == DialogResult.Retry)
            {
                lbl1.Text = "Reintentar";
            }
            if (r == DialogResult.Ignore)
            {
                lbl1.Text = "Omitir";
            }
        }
    }
}
