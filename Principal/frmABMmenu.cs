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
using AgregarIngrediente;


namespace Principal
{
    public partial class frmABMmenu : Form
    {
        public void setusuario(Usuario usuario)
        {
            this.usuarioLogueado = usuario;
        }

        private Usuario usuarioLogueado;

        public frmABMmenu(Usuario usuario)
        {
            InitializeComponent();
            setusuario(usuario);
        }

        private void btnAltaingrediente_Click(object sender, EventArgs e)
        {
            FormIngredientes formIngredientes = new FormIngredientes();


            formIngredientes.ShowDialog();
        }

        private void btnAltacomida_Click(object sender, EventArgs e)
        {
            AltaComida altaComida = new AltaComida();
            altaComida.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }
    }
    }

