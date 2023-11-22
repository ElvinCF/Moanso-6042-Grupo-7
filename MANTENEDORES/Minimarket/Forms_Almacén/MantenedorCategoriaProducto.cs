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
    public partial class MantenedorCategoriaProducto : Form
    {
        public MantenedorCategoriaProducto()
        {
            InitializeComponent();
            ListarCategoria();
            groupBoxDatos.Enabled = false;
            txtCategoria.Enabled = false;
        }
        public void ListarCategoria()
        {
            dgCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();

            btnModificar.Visible = false;
        }
        private void LimpiarVariables()
        {
            txtCategoria.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = " ";
            //cbkCategoria.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCategoria c = new entCategoria();
                c.NombreCategoria = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                c.Estado = cbkCategoria.Checked;
                logCategoria.Instancia.InsertarCategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.CategoriaID = int.Parse(txtCategoria.Text.Trim());
                c.NombreCategoria = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                c.Estado = cbkCategoria.Checked;
                logCategoria.Instancia.EditarCategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCategoria();

        }

       
        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgCategoria.Rows[e.RowIndex];
            txtCategoria.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cbkCategoria.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.CategoriaID = int.Parse(txtCategoria.Text.Trim());
                //cbkCategoria.Checked = false;
                //c.Estado = cbkCategoria.Checked;
                logCategoria.Instancia.DeshabilitarCategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCategoria();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
    
}
    