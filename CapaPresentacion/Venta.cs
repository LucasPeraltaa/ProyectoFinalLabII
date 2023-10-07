using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Venta : Form
    {
        private int indice;
        private int total;
        private object ID_VENTA;

        private DataTable miTablaVenta, miTablaProducto;

        private VentaCLN objVentaCLN;
        private ProductoCLN objProductoCLN;


        public Venta()
        {
            InitializeComponent();

            objVentaCLN = new VentaCLN();
            objProductoCLN = new ProductoCLN();

            miTablaVenta = new DataTable();
            miTablaProducto = new DataTable();
            ID_VENTA = new object();

            indice = 0;
            total = 0;
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            consultarListaVenta();
            consultarListaProductos();
            consultarListaPreciosProductos();


            txtIdVenta.Text = ID_VENTA.ToString();

            IDultimaP();

            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.ReadOnly = true;
            dgvVenta.MultiSelect = false;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void consultarListaVenta() // mostrar las ventas que realizamos
        {
            miTablaVenta.Clear();
            miTablaVenta = objVentaCLN.consultarListaVenta();
            dgvVenta.DataSource = miTablaVenta;
        }

        public void consultarListaProductos()  // mosdtar los productos que hay (carga en el cbo)
        {
            miTablaProducto.Clear();
            miTablaProducto = objProductoCLN.consultarListaProductos();

            cboProducto.ValueMember = "ID_producto";
            cboProducto.DisplayMember = "nombre_producto";
            cboProducto.DataSource = miTablaProducto;
        }

        public void consultarListaPreciosProductos()
        {
            miTablaProducto.Clear();
            miTablaProducto = objProductoCLN.consultarListaProductos();

            cboPrecioProducto.ValueMember = "ID_producto";
            cboPrecioProducto.DisplayMember = "precio";
            cboPrecioProducto.DataSource = miTablaProducto;
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarVenta_Click(object sender, EventArgs e) // boton de abajo
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objVentaCLN.actualizarVenta(ID_VENTA, dtpFecha.Text, txtCantidad.Text, cboPrecioProducto.Text, 
                                                                                cboProducto.SelectedIndex);
            consultarListaVenta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objVentaCLN.eliminarVenta(ID_VENTA); 
            consultarListaVenta();
        }

        private void calcularTotal()
        {
            total = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(cboPrecioProducto.Text);
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //consultarListaVenta();

            //indice = e.RowIndex;

            //ID_VENTA = Convert.ToInt32(dgvVenta.Rows[indice].Cells[0].Value);

            //txtIdVenta.Text = dgvVenta.Rows[indice].Cells[0].Value.ToString();
            //dtpFecha.Text = dgvVenta.Rows[indice].Cells[1].Value.ToString();
            //txtCantidad.Text = dgvVenta.Rows[indice].Cells[2].Value.ToString();

            //cboProducto.Text = dgvVenta.Rows[indice].Cells[4].Value.ToString();
        }
        private void IDultimaP()
        {
            int cantFilas = dgvVenta.Rows.Count;
            int posicionUltFila = objProductoCLN.getPosicionUltFila(cantFilas);
            ID_VENTA = dgvVenta.Rows[posicionUltFila].Cells[0].Value;
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultarListaVenta();

            indice = e.RowIndex;

            ID_VENTA = Convert.ToInt32(dgvVenta.Rows[indice].Cells[0].Value);

            txtIdVenta.Text = dgvVenta.Rows[indice].Cells[0].Value.ToString();
            dtpFecha.Text = dgvVenta.Rows[indice].Cells[1].Value.ToString();
            txtCantidad.Text = dgvVenta.Rows[indice].Cells[2].Value.ToString();

            cboProducto.Text = dgvVenta.Rows[indice].Cells[4].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
