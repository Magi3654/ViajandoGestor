using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad01
{
    public partial class Form2 : Form
    {
        private string cotizacion;
        public Form2()
        {
            InitializeComponent();
            //txtQuote.Text = quote;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form1 ventana=new Form1();
            ventana.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
