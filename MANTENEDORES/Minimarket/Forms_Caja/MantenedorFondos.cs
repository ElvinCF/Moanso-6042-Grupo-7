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

namespace Minimarket.Forms_Caja
{
    public partial class MantenedorFondos : Form
    {
        public MantenedorFondos()
        {
            InitializeComponent();
            ListarFondos();
            txtCapital.Enabled = false;
            groupBoxDatos.Enabled = false;


        }
        private void LimpiarVariables()
        {
            txtCapital.Text = "";
            txtMonto.Text = "";
            dtmFecha.Text = "";
           


            //cbkCategoria.Checked = false;
        }

        private void MantenedorCapital_Load(object sender, EventArgs e)
        {

        }
        public void ListarFondos()
        {
            dgvFondos.DataSource = logFondos.Instancia.Listarfondos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entFondos c = new entFondos();
                c.Monto = int.Parse(txtMonto.Text.Trim());

                c.Fecha = DateTime.Parse(dtmFecha.Text.Trim());
                logFondos.Instancia.InsertarFondos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            
            ListarFondos();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entFondos c = new entFondos();
                c.FondosID = int.Parse(txtCapital.Text.Trim());
                //cbkCategoria.Checked = false;
                //c.Estado = cbkCategoria.Checked;
                logFondos.Instancia.DeshabilitarFondos(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarFondos();
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            groupBoxDatos.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();

            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void dgvFondos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvFondos.Rows[e.RowIndex];
            txtCapital.Text = filaActual.Cells[0].Value.ToString();
            txtMonto.Text = filaActual.Cells[1].Value.ToString();
            dtmFecha.Text = filaActual.Cells[2].Value.ToString();
            cbkFondos.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entFondos c = new entFondos();
                c.FondosID = int.Parse(txtCapital.Text.Trim());
                c.Monto = decimal.Parse(txtMonto.Text.Trim());
                c.Estado = cbkFondos.Checked;
                c.Fecha = DateTime.Parse(dtmFecha.Text.Trim());
                logFondos.Instancia.EditarCapital(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarFondos();
        }
    }
}
