using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenedorCategoria();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new Devoluciones();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroProducto();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenedorProveedor();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenedorProducto();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new OrdenCompra();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenedorPedidoCliente();
            formulario.Show();
        }
    }
}
