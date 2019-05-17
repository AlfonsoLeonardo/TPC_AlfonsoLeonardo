using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using AgregarIngrediente;

namespace Principal
{
    public partial class frmPrincipal : Form
    {
      
        private Usuario usuarioLogueado;
            
  
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnAbm_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = true;
          
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
           /* try
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
            }*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true; 
           
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngre_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            AbrirFormHijo(new FormIngredientes());
        }

        private void btnComid_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            AbrirFormHijo(new AltaComida());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
        }

        private void AbrirFormHijo(object formhija)
        {

            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh =  formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
    }
}
