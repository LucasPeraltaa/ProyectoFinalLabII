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
    public partial class Proveedor : Form
    {
        private ProveedorCLN objProveedorCLN;
        private DataTable miTabla;

        private int indice;
        private object ID_PROVEEDOR;

        public Proveedor()
        {
            InitializeComponent();
            objProveedorCLN = new ProveedorCLN();
            miTabla = new DataTable();

            indice = 0;
            ID_PROVEEDOR = new object();

        }

        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objProveedorCLN.consultarProveedores();
            dgvProveedores.DataSource = miTabla;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            cargarDataGridView();

            int cantFilas = dgvProveedores.Rows.Count;
            int posicionUltFila = objProveedorCLN.getPosicionUltFila(cantFilas);

            ID_PROVEEDOR = dgvProveedores.Rows[posicionUltFila].Cells[0].Value;

            IDultimaP();
            limpiarTextBox();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (txtnombreProveedor.Text == "" || txtTelefono.Text == "" || txtNombreVendedor.Text == "")
            {
                MessageBox.Show("Campos vacios, cargue un proveedor", "Aviso Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar un proveedor?", "Aviso Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProveedorCLN.agregarProveedor(ID_PROVEEDOR, txtnombreProveedor.Text,
                                       txtTelefono.Text, txtNombreVendedor.Text);
                }

            }

            cargarDataGridView();
            limpiarTextBox();
            IDultimaP();
            txtID_proveedor.Text = ID_PROVEEDOR.ToString();
        }
            
            
            

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            
            if (txtnombreProveedor.Text == "" || txtTelefono.Text == "" || txtNombreVendedor.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un proveedor", "Aviso Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea actualizar un proveedor?", "Aviso Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProveedorCLN.actualizarProveedor(ID_PROVEEDOR, txtnombreProveedor.Text,
                                                txtTelefono.Text, txtNombreVendedor.Text);
                }

            }

            cargarDataGridView();
            limpiarTextBox();
            IDultimaP();
            txtID_proveedor.Text = ID_PROVEEDOR.ToString();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (txtnombreProveedor.Text == "" || txtTelefono.Text == "" || txtNombreVendedor.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un proveedor", "Aviso Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar un proveedor?", "Aviso Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProveedorCLN.eliminarProveedor(ID_PROVEEDOR);
                }

            }

            cargarDataGridView();
            limpiarTextBox();
            IDultimaP();
            txtID_proveedor.Text = ID_PROVEEDOR.ToString();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indice = e.RowIndex;
                ID_PROVEEDOR = dgvProveedores.Rows[indice].Cells[0].Value;

                txtnombreProveedor.Text = dgvProveedores.Rows[indice].Cells[1].Value.ToString();
                txtTelefono.Text = dgvProveedores.Rows[indice].Cells[2].Value.ToString();
                txtNombreVendedor.Text = dgvProveedores.Rows[indice].Cells[3].Value.ToString();

                txtID_proveedor.Text = ID_PROVEEDOR.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiartxt_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            txtID_proveedor.Text = ID_PROVEEDOR.ToString();
        }

        public void limpiarTextBox()
        {
            txtnombreProveedor.Clear();
            txtTelefono.Clear();
            txtNombreVendedor.Clear();
            txtID_proveedor.Clear();
        }

        private void IDultimaP()
        {
            int cantFilas = dgvProveedores.Rows.Count;
            int posicionUltFila = objProveedorCLN.getPosicionUltFila(cantFilas);
            ID_PROVEEDOR = dgvProveedores.Rows[posicionUltFila].Cells[0].Value;
        }
    }

            









}
