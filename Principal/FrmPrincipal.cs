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
        private void btnAbm_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = true;
          
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
                    btnAbm.Visible = true;
                    pnABM.Visible = true;
                }
                lUsernombre.Text = "Usuario: "+ usuarioLogueado.Apellido.ToString()+" "+usuarioLogueado.Nombre.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnIngre_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            AbrirFormHijo<AltaIngrediente>();
        }

        private void btnComid_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            AbrirFormHijo<AltaComida>();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            AbrirFormHijo<AltaUsuario>();
        }

        private void AbrirFormHijo<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelcontenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelcontenedor.Controls.Add(formulario);
                panelcontenedor.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }
    }
}
