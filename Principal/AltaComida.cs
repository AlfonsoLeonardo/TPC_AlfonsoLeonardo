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
        private List<Comida> listaComidaLocal;
        public AltaComida()
        {
            InitializeComponent(); 
        }
        private void DeleteAllsc()
        {
            textComida.Text = "";
            textcomidaprecio.Text="";
            lComidaexiste.Visible = false;
            pnNombrecomida.BackColor = System.Drawing.Color.Black;
            pnPreciocomida.BackColor = System.Drawing.Color.Black;
            lComidapecio.Visible = false;
            dgvlistacomida.Enabled = true;
            lComidaNombre.Visible = false;
        }
        private void AltaComida_Load(object sender, EventArgs e)
        {
            textComida.CharacterCasing = CharacterCasing.Upper;
            textComida.Focus();
            cargarGrillacomida();
        }
        private void cargarGrillacomida()
        {

            ComidaNegocio negocio = new ComidaNegocio();
            TipoComidaNegocio tipoComida = new TipoComidaNegocio();
            try
            {

                listaComidaLocal = negocio.ListarComida();
                cboTipoComida.DataSource = tipoComida.ListarTipoComida();
                cboTipoComida.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
                cboTipoComida.ValueMember = "Id";// nobre de la variable del id a mostar
                dgvlistacomida.DataSource = listaComidaLocal;
                dgvlistacomida.Columns[7].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnagregarcomida_Click(object sender, EventArgs e)
        {
            if (textComida.Text.Trim() == string.Empty)
            {

                lComidaNombre.Visible = true;

                pnNombrecomida.BackColor = System.Drawing.Color.Red;
                dgvlistacomida.Enabled = false;
                return;

            }
            else
            {
                lComidaNombre.Visible = false;

                pnNombrecomida.BackColor = System.Drawing.Color.Black;
                dgvlistacomida.Enabled = true;

            }
            if (textcomidaprecio.Text.Trim() == string.Empty || (Convert.ToDecimal(textcomidaprecio.Text)) < 1)
            {
                lComidapecio.Visible = true;
                pnPreciocomida.BackColor = System.Drawing.Color.Red;
                dgvlistacomida.Enabled = true;
                return;
            }
            else
            {
                lComidapecio.Visible = false;
                pnPreciocomida.BackColor = System.Drawing.Color.Black;
                dgvlistacomida.Enabled = true;
            }


            if (estado == false) {
                Comida comida = new Comida();
                TipoComida tipoComida = new TipoComida();
                ComidaNegocio negocio = new ComidaNegocio();
                try
                {
                    DateTime fecha = DateTime.Today;

                    comida.Nombre = textComida.Text;
                    comida.Precio = Convert.ToDecimal(textcomidaprecio.Text);
                    comida.TC= (TipoComida)cboTipoComida.SelectedItem;
                    comida.F_Add = fecha.ToLocalTime();
                    comida.UserAdd = Usuario.UsuarioLogin;
                    comida.F_Mod = fecha.ToLocalTime();
                    comida.UserMod = Usuario.UsuarioLogin;
                    if (negocio.validarComida(comida))
                    {
                        lComidaexiste.Visible = true;
                        pnNombrecomida.BackColor = System.Drawing.Color.Red;
                        dgvlistacomida.Enabled = false;
                        return;
                    }
                    else
                    {
                        lComidaexiste.Visible = false;
                        pnNombrecomida.BackColor = System.Drawing.Color.Black;
                        dgvlistacomida.Enabled = true;
                    }
                    DeleteAllsc();
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
                comida.Id = comi.Id;
                comida.Nombre = textComida.Text;
                comida.Precio = Convert.ToDecimal(textcomidaprecio.Text);
                comida.TC = (TipoComida)cboTipoComida.SelectedItem;
                comida.Estado = true;
                comida.F_Mod = fecha.ToLocalTime();
                comida.UserMod = Usuario.UsuarioLogin;
                negocio.modificarComida(comida);
                estado = false;
                DeleteAllsc();
                cargarGrillacomida();
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

            textComida.Text = comida.Nombre.ToString();
            textcomidaprecio.Text = comida.Precio.ToString();
            estado = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllsc();
            estado = false;
            cargarGrillacomida();
        }

        private void textcomidaprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != '.')
            {
                e.Handled = true;
                lComidapecio.Visible = true;
                pnPreciocomida.BackColor = System.Drawing.Color.Red;
            }

            else
            {
                lComidapecio.Visible = false;
                pnPreciocomida.BackColor = System.Drawing.Color.Black;
                textcomidaprecio.Focus();
            }
        }

        private void textBusquedacomida_TextChanged(object sender, EventArgs e)
        {
            if (textBusquedacomida.Text == "")
            {
                dgvlistacomida.DataSource = listaComidaLocal;
            }
            else
            {
                if (textBusquedacomida.Text.Length >= 1)
                {
                    List<Comida> lista;
                    lista = listaComidaLocal.FindAll(X => X.Nombre.Contains(textBusquedacomida.Text.ToUpper()));
                    dgvlistacomida.DataSource = lista;
                }
            }
        }
    }
}
