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
            Form formulario = new MantenedorCategoriaProducto();
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
            Form formulario = new Venta();
            formulario.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form formulario = new MantenedorCliente();
            formulario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new Egresos();
            formulario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new Entrada_de_dinero();
            formulario.Show();
        }
    }
}
