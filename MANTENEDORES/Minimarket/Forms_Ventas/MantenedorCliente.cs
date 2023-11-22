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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            ListarCliente();
            groupBoxCliente.Enabled = false;
            txtCliente.Enabled = false;

        }
        public void ListarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxCliente.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();

            btnModificar.Visible = false;
        }
        private void LimpiarVariables()
        {
            txtCliente.Text = "";
            txtDni.Text = "";
            txtMetodo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = " ";
            txtDireccion.Text = " ";
            //cbkCategoria.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente c = new entCliente();
                
                c.DNI = txtDni.Text.Trim();
                c.MetodoPagoID = int.Parse(txtMetodo.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Estado = cbkCliente.Checked;
                logCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxCliente.Enabled = false;
            ListarCliente();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxCliente.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                
                c.ClienteID = int.Parse(txtCliente.Text.Trim());
                c.DNI = txtDni.Text.Trim();
                c.MetodoPagoID = int.Parse(txtMetodo.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Estado = cbkCliente.Checked;
                logCliente.Instancia.EditarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxCliente.Enabled = false;
            ListarCliente();

        }

        private void dgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtCliente.Text = filaActual.Cells[0].Value.ToString();
            txtDni.Text = filaActual.Cells[1].Value.ToString();
            txtMetodo.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            txtDireccion.Text = filaActual.Cells[5].Value.ToString();
            cbkCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.ClienteID = int.Parse(txtCliente.Text.Trim());
                //cbkCategoria.Checked = false;
                //c.Estado = cbkCategoria.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxCliente.Enabled = false;
            ListarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }


    }
}
