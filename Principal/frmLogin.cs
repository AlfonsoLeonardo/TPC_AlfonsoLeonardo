using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Principal
{
    public partial class frmLogin : Form
    {

        private Usuario usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuario.NombreUsuario = txtUsuario.Text.Trim();
                usuario.Pass = txtPass.Text.Trim();
                if (usuarioNegocio.validarUsuario(usuario))
                {

                    //frmPrincipal frmPrincipal = new frmPrincipal();
                    Close();
                }
                else
                {
                    MessageBox.Show("usuario o pass incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (usuario.Id == 0)
            {
                Application.Exit();
            }
        }
    }
}