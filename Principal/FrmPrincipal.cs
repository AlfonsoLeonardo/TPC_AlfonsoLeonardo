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

namespace Principal
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuarioLogueado;
            
        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
               usuarioLogueado = new Usuario();
                frmLogin login = new frmLogin(usuarioLogueado);
                login.ShowDialog();

                if (usuarioLogueado.Tipo.Id == TipoUsuario.ADMINISTRADOR)
                {
                    
                  // mnuPropiedades.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAbm_Click(object sender, EventArgs e)
        {
            frmABMmenu aBMmenu = new frmABMmenu();
            aBMmenu.ShowDialog();
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            try
            {
                usuarioLogueado = new Usuario();
                frmLogin login = new frmLogin(usuarioLogueado);
                login.ShowDialog();

                if (usuarioLogueado.Tipo.Id == TipoUsuario.ADMINISTRADOR)
                {
                    // mnuPropiedades.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
