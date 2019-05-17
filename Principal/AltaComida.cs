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

       bool estado = false;
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
            textComida.CharacterCasing = CharacterCasing.Upper;
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

            if (estado == false) {
                Comida comida = new Comida();
                ComidaNegocio negocio = new ComidaNegocio();
                try
                {
                    DateTime fecha = DateTime.Today;

                    comida.NombreComida = textComida.Text;
                    comida.Precio = Convert.ToDecimal(textcomidaprecio.Text);
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
            if (estado == true)
            {
                DateTime fecha = DateTime.Today;
                Comida comida = new Comida();
                ComidaNegocio negocio = new ComidaNegocio();
                Comida comi;
                comi = (Comida)dgvlistacomida.CurrentRow.DataBoundItem;
                comida.IdComida = comi.IdComida;
                comida.NombreComida = textComida.Text;
                comida.Precio = Convert.ToDecimal(textcomidaprecio.Text);
                comida.FechaModificacion = fecha.ToLocalTime();
                comida.UsuarioModificacion = this.Usuario;
                negocio.modificarComida(comida);
                estado = true;
                DeleteAllsc();
            }
        }

        private void btnEliminarComida_Click(object sender, EventArgs e)
        {
            ComidaNegocio comidaNegocio = new ComidaNegocio();


            Comida comida;

            comida = (Comida)dgvlistacomida.CurrentRow.DataBoundItem;


            DialogResult result = MessageBox.Show("Reamente desea eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                comidaNegocio.eliminarComida(comida);
                DeleteAllsc();
                cargarGrillacomida();

               
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void btnmodificarcomida_Click(object sender, EventArgs e)
        {
            ComidaNegocio comidaNegocio = new ComidaNegocio();


            Comida comida;

            comida = (Comida)dgvlistacomida.CurrentRow.DataBoundItem;

            textComida.Text = comida.NombreComida.ToString();
            textcomidaprecio.Text = comida.Precio.ToString();
            estado = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllsc();
            estado = false;
            cargarGrillacomida();
        }
    }
}
