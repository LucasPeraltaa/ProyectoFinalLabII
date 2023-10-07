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
    public partial class Producto : Form
    {
        private int indice, indiceOrigen, indiceCategoria, indiceProveedor;
        private object ID_PRODUCTO;

        private DataTable miTablaProducto, tablaOrigen, tablaCategoria, tablaProveedor;

        private ProductoCLN objProductoCLN;
        private OrigenCLN objOrigenCLN;
        private CategoriaCLN objCategoriaCLN;
        private ProveedorCLN objProveedorCLN;

        public Producto()
        {
            InitializeComponent();

            miTablaProducto = new DataTable();
            tablaOrigen = new DataTable();
            tablaCategoria = new DataTable();
            tablaProveedor = new DataTable();

            objProductoCLN = new ProductoCLN();
            objCategoriaCLN = new CategoriaCLN();
            objOrigenCLN = new OrigenCLN();
            objProveedorCLN = new ProveedorCLN();

            ID_PRODUCTO = new object();
            indice = 0;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargarListaCategoria();
            cargarListaOrigen();
            cargarListaProveedor();
            IDultimaP();

            txtIdProducto.Text = ID_PRODUCTO.ToString();

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.MultiSelect = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void cargarProductos() // DGV PRODUCTOS
        {
            miTablaProducto.Clear();
            miTablaProducto = objProductoCLN.consultarListaProductos();
            dgvProductos.DataSource = miTablaProducto;
        }


        public void cargarListaProveedor()
        {
            tablaProveedor.Clear();
            tablaProveedor = objProveedorCLN.consultarProveedores();
            cboIDProveedor.ValueMember = "ID_provedor";
            cboIDProveedor.DisplayMember = "nombre_vendedor";
            cboIDProveedor.DataSource = tablaProveedor;
        }
        public void cargarListaOrigen()
        {
            tablaOrigen.Clear();
            tablaOrigen = objOrigenCLN.consultarOrigen();
            cboOrigen.ValueMember = "ID_origen";
            cboOrigen.DisplayMember = "origen";
            cboOrigen.DataSource = tablaOrigen;
            
        }

        public void cargarListaCategoria()
        {
            tablaCategoria.Clear();
            tablaCategoria = objCategoriaCLN.consultarCategoria();
            cboIDCategoria.ValueMember = "ID_categoria";
            cboIDCategoria.DisplayMember = "categoria";
            cboIDCategoria.DataSource = tablaCategoria;
        }

        

        private void cboIDProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceProveedor = cboIDProveedor.SelectedIndex;
            int nombreProveedor = Convert.ToInt32(tablaProveedor.Rows[indiceProveedor].ItemArray[0]);
        }

        private void cboIDCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCategoria = cboIDCategoria.SelectedIndex;
            int nombreCategoria = Convert.ToInt32(tablaCategoria.Rows[indiceCategoria].ItemArray[0]);
        }

        private void cboOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceOrigen = cboOrigen.SelectedIndex;
            int nombreOrigen = Convert.ToInt32(tablaOrigen.Rows[indiceOrigen].ItemArray[0]);
        }


        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtMarca.Text == "" || txtStock.Text == "" || txtCosto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Campos vacios, cargue un producto", "Aviso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea cargar un producto?", "Aviso Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProductoCLN.agregarProducto(ID_PRODUCTO, txtNombreProducto.Text, txtMarca.Text,
                                         txtCosto.Text, txtPrecio.Text,
                                      txtStock.Text, cboIDProveedor.SelectedIndex,
                                      cboIDCategoria.SelectedIndex, cboOrigen.SelectedIndex);
                }
            
            }

            cargarProductos();
            limpiarTextBox();
            IDultimaP();
            txtIdProducto.Text = ID_PRODUCTO.ToString();
        }


        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtMarca.Text == "" || txtStock.Text == "" || txtCosto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un producto", "Aviso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea actualizar un producto?", "Aviso Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProductoCLN.actualizarProducto(ID_PRODUCTO, txtNombreProducto.Text, txtMarca.Text,
                                         txtCosto.Text, txtPrecio.Text,
                                      txtStock.Text, cboIDProveedor.SelectedIndex,
                                      cboIDCategoria.SelectedIndex, cboOrigen.SelectedIndex);

                    cargarProductos();
                    limpiarTextBox();
                    IDultimaP();
                    txtIdProducto.Text = ID_PRODUCTO.ToString();
                }

            }
            
            
        }


        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtMarca.Text == "" || txtStock.Text == "" || txtCosto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un producto", "Aviso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar un producto?", "Aviso Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProductoCLN.eliminarProducto(ID_PRODUCTO);
                }

            }
            
            cargarProductos();
            limpiarTextBox();
            IDultimaP();
            txtIdProducto.Text = ID_PRODUCTO.ToString();
        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            ID_PRODUCTO = Convert.ToInt32(dgvProductos.Rows[indice].Cells[0].Value);

            txtIdProducto.Text = dgvProductos.Rows[indice].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
            txtMarca.Text = dgvProductos.Rows[indice].Cells[2].Value.ToString();
            txtCosto.Text = dgvProductos.Rows[indice].Cells[3].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[indice].Cells[4].Value.ToString();
            txtStock.Text = dgvProductos.Rows[indice].Cells[5].Value.ToString();

            cboIDProveedor.Text = dgvProductos.Rows[indice].Cells[6].Value.ToString();
            cboIDCategoria.Text = dgvProductos.Rows[indice].Cells[7].Value.ToString();
            cboOrigen.Text = dgvProductos.Rows[indice].Cells[8].Value.ToString();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            ID_PRODUCTO = Convert.ToInt32(dgvProductos.Rows[indice].Cells[0].Value.ToString());

            txtIdProducto.Text = dgvProductos.Rows[indice].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
            txtMarca.Text = dgvProductos.Rows[indice].Cells[2].Value.ToString();
            txtCosto.Text = dgvProductos.Rows[indice].Cells[3].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[indice].Cells[4].Value.ToString();
            txtStock.Text = dgvProductos.Rows[indice].Cells[5].Value.ToString();

            cboIDProveedor.Text = dgvProductos.Rows[indice].Cells[6].Value.ToString();
            cboIDCategoria.Text = dgvProductos.Rows[indice].Cells[7].Value.ToString();
            cboOrigen.Text = dgvProductos.Rows[indice].Cells[8].Value.ToString();
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiarTextBox()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtMarca.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void IDultimaP()
        {
            int cantFilas = dgvProductos.Rows.Count;
            int posicionUltFila = objProductoCLN.getPosicionUltFila(cantFilas);
            ID_PRODUCTO = dgvProductos.Rows[posicionUltFila].Cells[0].Value;
        }
    }
}
