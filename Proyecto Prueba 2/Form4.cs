using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Prueba_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Celular_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Celular ce;
            ce = new Celular();
            ce.Llamada = "";
            Form formulario = new Form3();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Celular c;
            c = new Celular();
            c.Mensaje = "Hola como estas Marisol ";
            MessageBox.Show(c.ToString());
        }
    }
}
