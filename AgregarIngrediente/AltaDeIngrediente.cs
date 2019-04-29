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

namespace AgregarIngrediente
{
    public partial class FormIngredientes : Form
    {
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
               /* dgvIngredientes.Columns[0].Visible = false;
                dgvIngredientes.Columns[3].Visible = false;
                dgvIngredientes.Columns[4].Visible = false;
                dgvIngredientes.Columns[5].Visible = false;
                */
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
                ingrediente.NombreIngrediente = textNombreIngrediente.Text;
               ingrediente.StockIngrediente =0;
                
                ingrediente.MasterPack = Convert.ToDecimal(textCantidadIngrediente.Text);
                ingrediente.PrecioIngrediente = Convert.ToDecimal(textPrecioIngrediente.Text);

                negocio.agregarIngrediente(ingrediente);
                textNombreIngrediente.Text = "";
                textCantidadIngrediente.Text = "";
                textPrecioIngrediente.Text = "";
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //doy de alta el formulario de ALTA pero para modificar, entonces le paso por constructor
                //el heroe seleccionado en la grilla.
               /* object modificar;
                modificar= dgvIngredientes.CurrentRow.DataBoundItem
                textNombreIngrediente.Text = dgvIngredientes.
                textCantidadIngrediente.Text = "";
                textPrecioIngrediente.Text = "";

                
                dgvIngredientes.CurrentRow.DataBoundItem
               dgvIn.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();*/
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
    }
}
