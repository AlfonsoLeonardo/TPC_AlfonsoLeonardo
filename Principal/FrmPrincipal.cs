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
        public void setusuario(Usuario usuario)
        {
            this.usuarioLogueado = usuario;
        }

        private Usuario usuarioLogueado;
            
  
        public frmPrincipal()
        {
            InitializeComponent();
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
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
