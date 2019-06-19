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
using Negocio;


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

            if (SubMenuABM.Visible == false)
            {
                SubMenuABM.Visible = true;
                btnTomaDePedido.Location = new Point(0,SubMenuABM.Location.Y+SubMenuABM.Height+5);
                pntomadepedido.Location = new Point(0, SubMenuABM.Location.Y + SubMenuABM.Height+5);
                pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height+5);
                btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height+5);
            }
            else
            {
                SubMenuABM.Visible = false;
                btnTomaDePedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
                pntomadepedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
                pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
                btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            }



        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio =new  UsuarioNegocio();

            try
            {
                usuarioLogueado = new Usuario();
                UsuarioLogueado.User = "admin";// para no loguearse a cada rato
                usuarioLogueado.Pass = "admin";//
                usuarioNegocio.validarUsuario(usuarioLogueado);//
                /*frmLogin login = new frmLogin(usuarioLogueado); //para loguearse

                login.ShowDialog();
                

                if (usuarioLogueado.Tipo.Id == TipoUsuario.ADMINISTRADOR)
                {*/
                    btnAbm.Visible = true;
                    pnABM.Visible = true;
               // }
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
            btnTomaDePedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pntomadepedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            AbrirFormHijo<AltaIngrediente>();
        }

        private void btnComid_Click(object sender, EventArgs e)
        {
            
            SubMenuABM.Visible = false;
            btnTomaDePedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pntomadepedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            AbrirFormHijo<AltaComida>();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            btnTomaDePedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pntomadepedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenuABM.Visible = false;
            btnTomaDePedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pntomadepedido.Location = new Point(0, btnAbm.Location.Y + btnAbm.Height + 5);
            pnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            btnReporte.Location = new Point(0, btnTomaDePedido.Location.Y + btnTomaDePedido.Height + 5);
            AbrirFormHijo<IngredientePorComida>();
        }

        private void btnTomaDePedido_Click(object sender, EventArgs e)
        {
            AbrirFormHijo<TomaDePedido>();
        }
    }
}
