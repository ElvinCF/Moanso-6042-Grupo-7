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
using CapaEntidad;
using CapaLogica;

namespace Minimarket
{
    public partial class Venta : Form
    {
        public static int confilas = 0;
        public static decimal Total = 0;
        entVenta Pedido = new entVenta();
        List<entDetallePedido> lstDetPedido = new List<entDetallePedido>();
        int idCliente;

        public Venta()
        {
            InitializeComponent();
            cargarComboClientes();
            cargarComboProducto();
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

        private void label26_Click(object sender, EventArgs e)
        {

        }
        private void cargarComboClientes()
        {
            List<entCliente> lstClientes = new List<entCliente>();
            entCliente c = new entCliente
            {
                ClienteID = 0,
                DNI = "Seleccionar"
            };
            lstClientes.Add(c);
            lstClientes.AddRange(logCliente.Instancia.ListarCliente());

            cboDni.DataSource = lstClientes;
            cboDni.ValueMember = "ClienteId";
            cboDni.DisplayMember = "DNI";
            cboDni.SelectedIndex = 0;
        }
        private void cargarComboProducto()
        {
            List<entProducto> lstProducto = new List<entProducto>();
            entProducto c = new entProducto
            {
                ProductosID = 0,
                Nombre = "Seleccionar"
            };
            lstProducto.Add(c);
            lstProducto.AddRange(logProducto.Instancia.ListarProducto());

            cboProducto.DataSource = lstProducto;
            cboProducto.ValueMember = "ProductosID";
            cboProducto.DisplayMember = "Nombre";
            cboProducto.SelectedIndex = 0;
        }

        private void cboDni_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((int)cboDni.SelectedIndex > 0)
            {

                entCliente objCliente = logCliente.Instancia.buscarCliente(Convert.ToInt32(cboDni.SelectedValue));
                txtNombreCliente.Text = objCliente.Nombre.ToString();
                txtTelefono.Text = objCliente.Telefono;
                cboDni.SelectedItem = cboDni.SelectedValue;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboProducto.SelectedIndex > 0)
            {

                entProducto objCliente = logProducto.Instancia.buscarProducto(Convert.ToInt32(cboProducto.SelectedValue));
                txtCantidad.Text = "0";
                txtPrecio.Text = "0";
                cboProducto.SelectedItem = cboProducto.SelectedValue;
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {

            entDetallePedido dPe = new entDetallePedido();
            entProducto Prod = new entProducto();

            if ((cboProducto.SelectedIndex > 0) && (cboDni.SelectedIndex > 0) && (txtCantidad.Text.Trim() != "") && txtPrecio.Text != "")
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0))
                {
                    if (confilas == 0)
                    {
                        entProducto productoSeleccionado = (entProducto)cboProducto.SelectedItem;
                        gvCarrito.Rows.Add(productoSeleccionado.ProductosID, productoSeleccionado.Nombre, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(gvCarrito.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(gvCarrito.Rows[confilas].Cells[3].Value);
                        gvCarrito.Rows[confilas].Cells[4].Value = subTotal;
                        confilas++;
                        
                    }
                    else
                    {
                        entProducto productoSeleccionado = (entProducto)cboProducto.SelectedItem;
                        gvCarrito.Rows.Add(productoSeleccionado.ProductosID, productoSeleccionado.Nombre, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(gvCarrito.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(gvCarrito.Rows[confilas].Cells[3].Value);
                        gvCarrito.Rows[confilas].Cells[4].Value = subTotal;
                        confilas++;
                        //gvCarrito.Rows.Add(productoSeleccionado.ProductosID, productoSeleccionado.Nombre, txtCantidad.Text, txtPrecio.Text);
                    }

                    //Limpiar();
                }
                Total = 0;
                foreach (DataGridViewRow Fila in gvCarrito.Rows)
                {

                    Total += Convert.ToDecimal(Fila.Cells[4].Value);
                }
                labelTotal.Text = Total.ToString();
                ActualizarVuelto();
            }
        }

        private void btnQuitarProduto_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total = Total = Convert.ToDecimal(gvCarrito.Rows[gvCarrito.CurrentRow.Index].Cells[4].Value);
                labelTotal.Text = Total.ToString();
                gvCarrito.Rows.RemoveAt(gvCarrito.CurrentRow.Index);
                confilas--;
            }
        }

        private void txtPagoCon_TextChanged(object sender, EventArgs e)
        {
            ActualizarVuelto();
        }
        private void ActualizarVuelto()
        {
            if (decimal.TryParse(labelTotal.Text, out decimal total) && total > 0 &&
                decimal.TryParse(txtPagoCon.Text, out decimal pago) && pago >= total)
            {
                lblVuelto.Text = (pago - total).ToString();
            }
            else
            {
                lblVuelto.Text = "0.0";
            }
        }
        private void lblVuelto_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminarVenta_Click(object sender, EventArgs e)
        {


            Close();



        }
        private void GrabarDetalle()
        {
            entDetallePedido dPed = new entDetallePedido();
            lstDetPedido = new List<entDetallePedido>();
            foreach (DataGridViewRow Fila in gvCarrito.Rows)
            {

                entProducto prod = new entProducto();


                prod.ProductosID = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                dPed.idProducto = prod;
                dPed.idProducto.ProductosID = prod.ProductosID;

                dPed.cantProducto = Convert.ToInt32(Fila.Cells[2].Value.ToString());
                dPed.precProducto = Convert.ToDecimal(Fila.Cells[3].Value.ToString());


                lstDetPedido.Add(dPed);
            }

        }
        private void LimpiarVariables()
        {
            cboDni.Text = "";
            cboTipoPago.Text = "";
            txtNombreCliente.Text = "";
            txtTelefono.Text = "";
            cboProducto.Text = "";
            txtPrecio.Text = " ";
            txtCantidad.Text = " ";
            txtPagoCon.Text = " ";
            //cbkCategoria.Checked = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }
    }
      
}
