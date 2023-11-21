using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minimarket.Forms_Caja;

namespace Minimarket
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new CierreCaja();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenedorCliente();
            formulario.Show();
        }
    }
}
