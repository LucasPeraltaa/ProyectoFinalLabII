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
    public partial class Categoria : Form
    {
        private int indice;
        private DataTable miTabla;
        private CategoriaCLN objCategoriaCLN;
        private object ID_CATEGORIA;

        public Categoria()
        {
            InitializeComponent();
            objCategoriaCLN = new CategoriaCLN();
            miTabla = new DataTable();
            ID_CATEGORIA = new object();
            indice = 0;
        }


        public void consultarCategorias()
        {
            miTabla.Clear();
            miTabla = objCategoriaCLN.consultarCategoria();
            dgvCategoria.DataSource = miTabla;
        }


        private void Categoria_Load(object sender, EventArgs e)
        {
            consultarCategorias();

            int cantFilas = dgvCategoria.Rows.Count;
            int posicionUltFila = objCategoriaCLN.getPosicionUltFila(cantFilas);

            ID_CATEGORIA = Convert.ToInt32(dgvCategoria.Rows[posicionUltFila].Cells[0].Value);
            txtIDcategoria.Text = ID_CATEGORIA.ToString();

            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.ReadOnly = true;
            dgvCategoria.MultiSelect = false;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

            


        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            ID_CATEGORIA = Convert.ToInt32(dgvCategoria.Rows[indice].Cells[0].Value);

            txtIDcategoria.Text = dgvCategoria.Rows[indice].Cells[0].Value.ToString();
            txtCategoria.Text = dgvCategoria.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            

            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Campos vacios, cargue una categoria", "Aviso Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea cargar una categoria?", "Aviso Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objCategoriaCLN.agregarCategoria(ID_CATEGORIA, txtCategoria.Text);

                    consultarCategorias();
                    IDultimaP();

                    txtCategoria.Clear();
                    txtIDcategoria.Clear();
                    txtIDcategoria.Text = ID_CATEGORIA.ToString();
                }
                    
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione una categoria", "Aviso Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar una categoria?", "Aviso Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objCategoriaCLN.eliminarCategoria(ID_CATEGORIA);

                    consultarCategorias();
                    IDultimaP();

                    txtCategoria.Clear();
                    txtIDcategoria.Text = ID_CATEGORIA.ToString();
                }
                    

            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione una categoria", "Aviso Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("¿Desea actualizar una categoria?", "Aviso Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objCategoriaCLN.actualizarCategoria(ID_CATEGORIA, txtCategoria.Text);

                    consultarCategorias();
                    IDultimaP();

                    txtCategoria.Clear();
                    txtIDcategoria.Text = ID_CATEGORIA.ToString();
                }
            }
        }


        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            ID_CATEGORIA = Convert.ToInt32(dgvCategoria.Rows[indice].Cells[0].Value);

            txtIDcategoria.Text = dgvCategoria.Rows[indice].Cells[0].Value.ToString();
            txtCategoria.Text = dgvCategoria.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDultimaP()
        {
            int cantFilas = dgvCategoria.Rows.Count;
            int posicionUltFila = objCategoriaCLN.getPosicionUltFila(cantFilas);
            ID_CATEGORIA = dgvCategoria.Rows[posicionUltFila].Cells[0].Value;
        }

    }
}
