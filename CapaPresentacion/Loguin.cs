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
    public partial class Login : Form
    {
        private UsuarioCLN objUsuarioCLN;

        public Login()
        {
            InitializeComponent();
            objUsuarioCLN = new UsuarioCLN();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {
            // no agregar nada
            txtContrasena.PasswordChar = '*';
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            bandera = objUsuarioCLN.validarUsuario(txtUsuario.Text, txtContrasena.Text);
            

            if (bandera == 1)
            {
                Menu frmMenuPrincipal = new Menu();
                frmMenuPrincipal.Show();
                Hide();
            }

            if(bandera == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Usuario Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiartxtUsuario();
            }

        }

        private void limpiartxtUsuario()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
        }
    }
}

