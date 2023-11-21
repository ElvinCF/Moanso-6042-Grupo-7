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
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroProducto ();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
