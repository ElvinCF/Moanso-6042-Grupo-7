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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            ListarProveedor();
            groupBoxProveedor.Enabled = false;
            txtProveedor.Enabled = false;

        }
        public void ListarProveedor()
        {
            dgProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxProveedor.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();

            btnModificar.Visible = false;
        }
        private void LimpiarVariables()
        {
            txtProveedor.Text = "";
            txtCiudad.Text = "";
            txtRuc.Text = "";
            txtNombre.Text = "";
            txtRazon.Text = " ";
            txtTelefono.Text = " ";
            txtDireccion.Text = " ";
            //cbkCategoria.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProveedor c = new entProveedor();
                c.CiudadID = int.Parse(txtCiudad.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.Ruc = txtRuc.Text.Trim();
                c.RazSocial = txtRazon.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Estado = cbkProveedor.Checked;
                logProveedor.Instancia.InsertarProveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProveedor.Enabled = false;
            ListarProveedor();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxProveedor.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.ProveedorID = int.Parse(txtProveedor.Text.Trim());
                c.CiudadID = int.Parse(txtCiudad.Text.Trim());
                c.Ruc = txtRuc.Text.Trim();
                c.Nombre = txtNombre.Text.Trim();
                c.RazSocial = txtRazon.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Estado = cbkProveedor.Checked;
                logProveedor.Instancia.EditarProveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProveedor.Enabled = false;
            ListarProveedor();

        }

        private void dgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgProveedor.Rows[e.RowIndex];
            txtProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRuc.Text = filaActual.Cells[1].Value.ToString();
            txtCiudad.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            txtRazon.Text = filaActual.Cells[4].Value.ToString();
            txtTelefono.Text = filaActual.Cells[5].Value.ToString();
            txtDireccion.Text = filaActual.Cells[6].Value.ToString();
            cbkProveedor.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.ProveedorID = int.Parse(txtProveedor.Text.Trim());
                //cbkCategoria.Checked = false;
                //c.Estado = cbkCategoria.Checked;
                logProveedor.Instancia.DeshabilitarProveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxProveedor.Enabled = false;
            ListarProveedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}

