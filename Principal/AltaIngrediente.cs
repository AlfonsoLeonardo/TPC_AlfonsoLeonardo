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
using AccesoDatos;

namespace Principal
{
    public partial class AltaIngrediente : Form
    {
        public AltaIngrediente()
        {
            InitializeComponent();
        }

        bool estado = false;
    
        private List<Ingrediente> listaIngredienteLocal;

        private void DeleteAlls()
        {
            textNombreIngrediente.Text = "";
            textCantidadIngrediente.Text = "";
            textPrecioIngrediente.Text = "";
        }

        private void cargarGrilla()
        {

            IngredienteNegocio negocio = new IngredienteNegocio();
            UnidadMedidaNegocio unidMedi = new UnidadMedidaNegocio();
            try
            {
                cboUnidadmedida.DataSource = unidMedi.listarUnidadMedida();
                cboUnidadmedida.DisplayMember = "DescripcionCorta"; //Nombre de la varible a mostrar en pantalla
                cboUnidadmedida.ValueMember = "IdUnidad";// nobre de la variable del id a mostar
                listaIngredienteLocal = negocio.ListarIngrediente();
                dgvIngredientes.DataSource = listaIngredienteLocal;
                dgvIngredientes.Columns[2].Visible = false;
                dgvIngredientes.Columns[10].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaIngrediente_Load(object sender, EventArgs e)
        {
            textNombreIngrediente.CharacterCasing = CharacterCasing.Upper;
            cargarGrilla();
            textNombreIngrediente.Focus();
        }

        private void AceptarAgregaIngrediente_Click_1(object sender, EventArgs e)
        {
            Ingrediente ingrediente = new Ingrediente();
            IngredienteNegocio negocio = new IngredienteNegocio();
            UnidadDeMedida unidadDeMedida = new UnidadDeMedida();
            try
            {

                if (textNombreIngrediente.Text.Trim() == string.Empty)
                {

                    lTxtvacioNombre.Visible = true;
                    
                    pnNombreing.BackColor = System.Drawing.Color.Red;
                    dgvIngredientes.Enabled = false;
                    return;

                }
                else
                {
                    lTxtvacioNombre.Visible = false;
                    
                    pnNombreing.BackColor = System.Drawing.Color.Black;
                    dgvIngredientes.Enabled = true;

                }
                if (textCantidadIngrediente.Text.Trim() == string.Empty|| Convert.ToDecimal(textCantidadIngrediente.Text)<1)
                {
                    ltxtcantidadIngrediente.Visible = true;
                    pnCantidading.BackColor = System.Drawing.Color.Red;
                    dgvIngredientes.Enabled = true;
                    return;
                }
                else
                {
                    ltxtcantidadIngrediente.Visible = false;
                    pnCantidading.BackColor = System.Drawing.Color.Black;
                    dgvIngredientes.Enabled = true;
                }

                if (textPrecioIngrediente.Text.Trim() == string.Empty ||( Convert.ToDecimal(textPrecioIngrediente.Text)) < 1)
                {
                    ltxtprecioingrediente.Visible = true;
                    pnPrecioing.BackColor = System.Drawing.Color.Red;
                    dgvIngredientes.Enabled = true;
                    return;
                }
                else
                {
                    ltxtprecioingrediente.Visible = false;
                    pnPrecioing.BackColor = System.Drawing.Color.Black;
                    dgvIngredientes.Enabled = true;
                }

                if (estado == false)
                {
                   
                    DateTime fecha = DateTime.Today;
                    ingrediente.Nombre = textNombreIngrediente.Text;
                    ingrediente.Stock = 0;
                    ingrediente.Master = Convert.ToDecimal(textCantidadIngrediente.Text);
                    ingrediente.Precio = Convert.ToDecimal(textPrecioIngrediente.Text);
                    ingrediente.UM = (UnidadDeMedida)cboUnidadmedida.SelectedItem;
                    ingrediente.F_Mod = fecha.ToLocalTime();
                    ingrediente.UserMod = Usuario.UsuarioLogin;
                    ingrediente.F_Add = fecha.ToLocalTime();
                    ingrediente.UserAdd = Usuario.UsuarioLogin;
                    if (negocio.validarIngrediente(ingrediente))
                    {
                        lIngredienteexiste.Visible = true;
                        pnNombreing.BackColor = System.Drawing.Color.Red;
                        dgvIngredientes.Enabled = false;
                        return;
                    }
                    else
                    {

                        lIngredienteexiste.Visible = false;
                        pnNombreing.BackColor = System.Drawing.Color.Black;
                        dgvIngredientes.Enabled = true;

                    }

                    //ingrediente.estado = true;

                    //negocio.agregarIngrediente(ingrediente);
                    textNombreIngrediente.Text = "";
                    textCantidadIngrediente.Text = "";
                    textPrecioIngrediente.Text = "";
                    cargarGrilla();
                }
                if (estado == true)
                {
                    DateTime fecha = DateTime.Today;
                    IngredienteNegocio ingredienteNegocio = new IngredienteNegocio();
                    Ingrediente ingredient = new Ingrediente();
                    Ingrediente ing = (Ingrediente)dgvIngredientes.CurrentRow.DataBoundItem;
                    ingredient.Id = ing.Id;
                    ingredient.Nombre = textNombreIngrediente.Text;
                    ingredient.Master = Convert.ToDecimal(textCantidadIngrediente.Text);
                    ingredient.UM = (UnidadDeMedida)cboUnidadmedida.SelectedItem;
                    ingredient.Precio = Convert.ToDecimal(textPrecioIngrediente.Text);
                    ingredient.F_Mod = fecha.ToLocalTime();
                    ingredient.UserMod = Usuario.UsuarioLogin;
                    ingredient.estado = true;
                    negocio.modificarIngrediente(ingredient);
                    textNombreIngrediente.Text = "";
                    textCantidadIngrediente.Text = "";
                    textPrecioIngrediente.Text = "";
                    cargarGrilla();
                    estado = false;
                    dgvIngredientes.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeleteAlls();
            estado = false;
            lTxtvacioNombre.Visible = false;
            pnNombreing.BackColor = System.Drawing.Color.Black;
            ltxtcantidadIngrediente.Visible = false;
            pnCantidading.BackColor = System.Drawing.Color.Black;
            ltxtprecioingrediente.Visible = false;
            pnPrecioing.BackColor = System.Drawing.Color.Black;
            dgvIngredientes.Enabled = true;
            cargarGrilla();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            IngredienteNegocio negocio = new IngredienteNegocio();

            Ingrediente ing;

            ing = (Ingrediente)dgvIngredientes.CurrentRow.DataBoundItem;


            DialogResult result = MessageBox.Show("Reamente desea eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                negocio.eliminarIngrediente(ing);
                DeleteAlls();
                cargarGrilla();
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                IngredienteNegocio ingredienteNegocio = new IngredienteNegocio();

                Ingrediente ing;

                ing = (Ingrediente)dgvIngredientes.CurrentRow.DataBoundItem;
                textNombreIngrediente.Text = ing.Nombre;
                textCantidadIngrediente.Text = ing.Master.ToString();
                textPrecioIngrediente.Text = ing.Precio.ToString();
                cboUnidadmedida.Text = ing.UM.DescripcionCorta;
                dgvIngredientes.Enabled = false;

                estado = true;





            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("algo paso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (textBusqueda.Text == "")
            {
                dgvIngredientes.DataSource = listaIngredienteLocal;
            }
            else
            {
                if (textBusqueda.Text.Length >= 1)
                {
                    List<Ingrediente> lista;
                    lista = listaIngredienteLocal.FindAll(X => X.Nombre.Contains(textBusqueda.Text.ToUpper()));
                    dgvIngredientes.DataSource = lista;
                }
            }
        }

        private void textCantidadIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13&&e.KeyChar!='.')
            {
                e.Handled = true;
                ltxtcantidadIngrediente.Visible = true;
                pnCantidading.BackColor = System.Drawing.Color.Red;
            }
            
            else 
            {
                ltxtcantidadIngrediente.Visible = false;
                pnCantidading.BackColor = System.Drawing.Color.Black;
                 textCantidadIngrediente.Focus();
            }
        }

        private void textPrecioIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != '.')
            {
                e.Handled = true;
                ltxtprecioingrediente.Visible = true;
                pnPrecioing.BackColor = System.Drawing.Color.Red;
            }
         
            else 
            {
                ltxtprecioingrediente.Visible = false;
                pnPrecioing.BackColor = System.Drawing.Color.Black;

                textPrecioIngrediente.Focus();
            }
        }
    }
}


