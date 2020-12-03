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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Telefono t;
            t = new Telefono();
            t.Llamada= "";
            Form formulario = new Form2();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispositivo d;
            d = new Dispositivo();
            d.Sistema = "";
            MessageBox.Show(d.ToString());
        }
    }

}
