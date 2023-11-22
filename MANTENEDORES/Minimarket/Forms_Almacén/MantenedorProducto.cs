using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Minimarket
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            ListarProducto();
            groupBoxProducto.Enabled = false;
            txtProducto.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ListarProducto()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new MantenedorCategoriaProducto();
            form.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProducto c = new entProducto();
                c.CategoriaID = int.Parse(txtCategoria.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                c.Stock = int.Parse(txtStock.Text.Trim());
                c.Precio = int.Parse(txtPrecio.Text.Trim());
                c.Estado = cbkProducto.Checked;
                c.FechaVencimiento = DateTime.Parse(dtpFecha.Text.Trim());
                logProducto.Instancia.InsertarProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProducto.Enabled = false;
            ListarProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
                groupBoxProducto.Enabled = true;

                btnAgregar.Visible = true;
                LimpiarVariables();

                btnModificar.Visible = false;
            
        }
        private void LimpiarVariables()
        {
            txtProducto.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtStock.Text = " ";
            txtPrecio.Text = "";

            //cbkCategoria.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.CategoriaID = int.Parse(txtCategoria.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                c.Stock = int.Parse(txtStock.Text.Trim());
                c.Precio = int.Parse(txtPrecio.Text.Trim());
                c.Estado = cbkProducto.Checked;
                c.FechaVencimiento = DateTime.Parse(dtpFecha.Text.Trim());
                logProducto.Instancia.EditarProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProducto.Enabled = false;
            ListarProducto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.ProductosID = int.Parse(txtProducto.Text.Trim());
                //cbkCategoria.Checked = false;
                //c.Estado = cbkCategoria.Checked;
                logProducto.Instancia.DeshabilitarProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProducto.Enabled = false;
            ListarProducto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxProducto.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtProducto.Text = filaActual.Cells[0].Value.ToString();
            txtCategoria.Text = filaActual.Cells[1].Value.ToString();
            txtNombre.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            txtNombre.Text = filaActual.Cells[4].Value.ToString();
            txtPrecio.Text = filaActual.Cells[5].Value.ToString();
            txtStock.Text = filaActual.Cells[6].Value.ToString();
            
            cbkProducto.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }
    }
}
