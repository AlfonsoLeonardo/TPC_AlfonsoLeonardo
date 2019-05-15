using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Principal
{
    public partial class AltaComida : Form
    {
        private Usuario Usuario;
        private List<Comida> listaComidaLocal;
        public AltaComida()
        {
            InitializeComponent();
        }
        private void DeleteAllsc()
        {
            textComida.Text = "";
            textcomidaprecio.Text="";
         
        }
        private void AltaComida_Load(object sender, EventArgs e)
        {
            cargarGrillacomida();
        }


        private void cargarGrillacomida()
        {

            ComidaNegocio negocio = new ComidaNegocio();
            try
            {

                listaComidaLocal = negocio.ListarComida();
                dgvlistacomida.DataSource = listaComidaLocal;
               
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnagregarcomida_Click(object sender, EventArgs e)
        {
            Comida comida= new Comida();
            ComidaNegocio negocio = new ComidaNegocio();
            try
            {
                DateTime fecha = DateTime.Today;

                comida.NombreComida = textComida.Text;
                comida.Precio= Convert.ToDecimal(textcomidaprecio.Text);
                comida.FechaCreacion = fecha.ToLocalTime();
                comida.UsuarioCreacion = this.Usuario;
                comida.FechaModificacion = fecha.ToLocalTime();
                comida.UsuarioModificacion = this.Usuario;
                DeleteAllsc();

                negocio.agregarcomida(comida);
              
                cargarGrillacomida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
