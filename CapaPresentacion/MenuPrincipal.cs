using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void Menu_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
        }
        private void btnOrigen_Click(object sender, EventArgs e)
        {
            Origen origen = new Origen();
            origen.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
        }

    }
}

        

