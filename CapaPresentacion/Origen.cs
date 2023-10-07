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
    public partial class Origen : Form
    {
        private int indice;
        private DataTable miTabla;
        private OrigenCLN objOrigenCLN;
        private object ID_ORIGEN;

        public Origen()
        {
            InitializeComponent();
            objOrigenCLN = new OrigenCLN();
            miTabla = new DataTable();
            ID_ORIGEN = new object();
            
            indice = 0;
        }

        private void Origen_Load(object sender, EventArgs e)
        {
            consultarOrigen();

            int cantFilas = dgvOrigen.Rows.Count;
            int posicionUltFila = objOrigenCLN.getPosicionUltFila(cantFilas);

            ID_ORIGEN = Convert.ToInt32(dgvOrigen.Rows[posicionUltFila].Cells[0].Value);
            txtIDorigen.Text = ID_ORIGEN.ToString();

            dgvOrigen.AllowUserToAddRows = false;
            dgvOrigen.ReadOnly = true;
            dgvOrigen.MultiSelect = false;
            dgvOrigen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAgregarOrigen_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "")
            {
                MessageBox.Show("Campos vacios, cargue un origen", "Aviso Origen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea cargar un origen?", "Aviso Origen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objOrigenCLN.agregarOrigen(ID_ORIGEN, txtOrigen.Text);
                    consultarOrigen();
                    IDultimaP();
                    txtOrigen.Clear();
                    txtIDorigen.Text = ID_ORIGEN.ToString();

                }

            }

            
        }

        private void btnActualizarOrigen_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un origen", "Aviso Origen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea actualizar un origen?", "Aviso Origen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objOrigenCLN.actualizarOrigen(ID_ORIGEN, txtOrigen.Text);

                    consultarOrigen();
                    IDultimaP();

                    txtOrigen.Clear();
                    txtIDorigen.Text = ID_ORIGEN.ToString();

                }

            }
            
        }

        private void btnEliminarOrigen_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "")
            {
                MessageBox.Show("Campos vacios, seleccione un origen", "Aviso Origen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar un origen?", "Aviso Origen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objOrigenCLN.eliminarOrigen(ID_ORIGEN);

                    consultarOrigen();
                    IDultimaP();

                    txtOrigen.Clear();
                    txtIDorigen.Text = ID_ORIGEN.ToString();
                }

            }
            
        }



        public void consultarOrigen()
        {
            miTabla.Clear();
            miTabla = objOrigenCLN.consultarOrigen();
            dgvOrigen.DataSource = miTabla;
        }

        

        private void dgvOrigen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            ID_ORIGEN = Convert.ToInt32(dgvOrigen.Rows[indice].Cells[0].Value);

            txtIDorigen.Text = dgvOrigen.Rows[indice].Cells[0].Value.ToString();
            txtOrigen.Text = dgvOrigen.Rows[indice].Cells[1].Value.ToString();
        }

        private void IDultimaP()
        {
            int cantFilas = dgvOrigen.Rows.Count;
            int posicionUltFila = objOrigenCLN.getPosicionUltFila(cantFilas);
            ID_ORIGEN = dgvOrigen.Rows[posicionUltFila].Cells[0].Value;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
