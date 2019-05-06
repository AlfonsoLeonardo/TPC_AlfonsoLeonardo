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
using AgregarIngrediente;
using Dominio;
using Negocio;

namespace AgregarIngrediente
{
    public partial class FormIngredientes : Form
    {
        bool estado = false;
   
        private List<Ingrediente> listaIngredienteLocal;
        public FormIngredientes()
        {
            InitializeComponent();
        }
        private void DeleteAlls()
        {
            textNombreIngrediente.Text = "";
            textCantidadIngrediente.Text = "";
            textPrecioIngrediente.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cargarGrilla();
          
        }       

        private void cargarGrilla()
        {
         
          IngredienteNegocio negocio  = new IngredienteNegocio();
            try
            {

                listaIngredienteLocal = negocio.ListarIngrediente();
                dgvIngredientes.DataSource = listaIngredienteLocal;
                dgvIngredientes.Columns[2].Visible = false;
               // dgvIngredientes.Columns[4].Visible = false;
                dgvIngredientes.Columns[5].Visible = false;
                dgvIngredientes.Columns[6].Visible = false;
                dgvIngredientes.Columns[7].Visible = false;
                dgvIngredientes.Columns[8].Visible = false;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AceptarAgregaIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = new Ingrediente();
            IngredienteNegocio negocio = new IngredienteNegocio();
            try
            {
                if (estado == false)
                {
                    DateTime fecha = DateTime.Today;

                    ingrediente.NombreIngrediente = textNombreIngrediente.Text;
                    ingrediente.StockIngrediente = 0;
                    ingrediente.MasterPack = Convert.ToDecimal(textCantidadIngrediente.Text);
                    ingrediente.PrecioIngrediente = Convert.ToDecimal(textPrecioIngrediente.Text);
                    ingrediente.FechaCreacion = fecha.ToLocalTime();
                    ingrediente.UsuarioCreacion = 1;
                    ingrediente.FechaModificacion = fecha.ToLocalTime();
                    ingrediente.UsuarioModificacion = 1;

                    negocio.agregarIngrediente(ingrediente);
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

                    Ingrediente ing;

                    ing = (Ingrediente)dgvIngredientes.CurrentRow.DataBoundItem;
                   
                                  
                    ingredient.IdIngrediente = ing.IdIngrediente;
                    ingredient.NombreIngrediente = textNombreIngrediente.Text;
                    ingredient.StockIngrediente = ing.StockIngrediente;
                    ingredient.MasterPack = Convert.ToDecimal(textCantidadIngrediente.Text);
                    ingredient.PrecioIngrediente = Convert.ToDecimal(textPrecioIngrediente.Text);
                    ingredient.FechaModificacion = fecha.ToLocalTime();
                    ingredient.UsuarioModificacion = 1;

                    negocio.modificarIngrediente(ingredient);
                    textNombreIngrediente.Text = "";
                    textCantidadIngrediente.Text = "";
                    textPrecioIngrediente.Text = "";
                    cargarGrilla();
                    estado = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormIngredientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                IngredienteNegocio ingredienteNegocio = new IngredienteNegocio();
               
                Ingrediente ing;

                ing = (Ingrediente)dgvIngredientes.CurrentRow.DataBoundItem;
                textNombreIngrediente.Text = ing.NombreIngrediente;
                textCantidadIngrediente.Text = ing.MasterPack.ToString();
                textPrecioIngrediente.Text = ing.PrecioIngrediente.ToString();



                estado = true;


                //ingredienteNegocio.modificarIngrediente(ing);
               // cargarGrilla();

                
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
    }
}
