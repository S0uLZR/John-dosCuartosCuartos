using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitectura.Capa_GUI
{
    public partial class Pedidos : Form
    {
        Capa_CONN.Conexion cn = new Capa_CONN.Conexion();
        Capa_DTO.Pedido pe = new Capa_DTO.Pedido();

        public Pedidos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;

            string plato = "";

            if(checkBox3.Checked)
            {

                p1 = 1;

                plato = "filete mar y tierra";
            }

            if (checkBox1.Checked)
            {

                p2 = 1;

                plato = "plateada a la olla";

            }

            if (checkBox4.Checked)
            {

                p3 = 1;

                plato = "asado de tira";

            }

            if (checkBox2.Checked)
            {

                p4 = 1;

                plato = "filete a lo pobre";

            }

            int precioT = p1 + p2 + p3 + p4;

            string precio = precioT.ToString();

            pe.insertar(plato, precio);

            string numeroPedido = DateTime.Now.ToString("yyyyMMddHHmm");

            MessageBox.Show(" Su numero de pedido es el "+ numeroPedido);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
