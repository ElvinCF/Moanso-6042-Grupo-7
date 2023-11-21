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
    public partial class OrdenCompra : Form
    {
        public OrdenCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Form formulario = new MantenedorProveedor();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Egresos();
            formulario.Show();
        }
    }
}
