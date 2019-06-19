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
using Negocio;

namespace Principal
{
    public partial class IngredientePorComida : Form
    {

        public IngredientePorComida()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {

            IngredienteNegocio negocio = new IngredienteNegocio();
            IngredientePorComidaNegocio porComidaNegocio = new IngredientePorComidaNegocio();
            ComidaNegocio negocioc = new ComidaNegocio();
            Comida comida = new Comida();

            try
            {
                comida = (Comida)cboComida.SelectedItem;
                int xx = comida.Id;
                dgvIngreporComida.DataSource = porComidaNegocio.ListarIngredienteporcomida(xx);
                dgvIngreporComida.Columns[1].Visible = false;
                dgvIngreporComida.Columns[2].Visible = false;
                dgvIngreporComida.Columns[4].Visible = false;
                dgvIngreporComida.Columns[3].Visible = false;
                dgvIngreporComida.Columns[5].Visible = false;
                dgvIngredienteppcc.DataSource = porComidaNegocio.ListarIngredientecc(xx);
                dgvIngredienteppcc.Columns[0].Visible = false;
                dgvIngredienteppcc.Columns[2].Visible = false;
                dgvIngredienteppcc.Columns[3].Visible = false;
                dgvIngredienteppcc.Columns[4].Visible = false;
                dgvIngredienteppcc.Columns[5].Visible = false;
                dgvIngredienteppcc.Columns[6].Visible = false;
                dgvIngredienteppcc.Columns[7].Visible = false;
                dgvIngredienteppcc.Columns[8].Visible = false;
                dgvIngredienteppcc.Columns[9].Visible = false;
                dgvIngredienteppcc.Columns[10].Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void IngredientePorComida_Load(object sender, EventArgs e)
        {
            ComidaNegocio negocioc = new ComidaNegocio();
            cboComida.DataSource = negocioc.ListarComida();
            cboComida.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
            cboComida.ValueMember = "Id";// nobre de la variable del id a mostar
            cargarGrilla();
        }

        private void cboComida_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregarIngredienteporcomida_Click(object sender, EventArgs e)
        {
            IngredientePorComidaNegocio porComidaNegocio = new IngredientePorComidaNegocio();
            Comida comida = new Comida();
            Ingrediente ingrediente = new Ingrediente();
            DateTime fecha = DateTime.Today;
            IngreditePorComida ingreditePorComida  = new IngreditePorComida();

            comida = (Comida)cboComida.SelectedItem;
            ingrediente=(Ingrediente)dgvIngredienteppcc.CurrentRow.DataBoundItem;
            ingreditePorComida.Ingrediente = ingrediente;
            ingreditePorComida.Comida = comida;
            ingreditePorComida.UsuarioCreacion= Usuario.UsuarioLogin;
            ingreditePorComida.UsuarioModificacion= Usuario.UsuarioLogin;
            ingreditePorComida.FechaCreacion= fecha.ToLocalTime();
            ingreditePorComida.FechaModificacion= fecha.ToLocalTime();
            string canti;
            canti =Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad:", "Agregar cantidad a la Comida", "0", 100, 100);
            ingreditePorComida.Cantidad = Convert.ToDecimal(canti);
            porComidaNegocio.validarIngredienteporComida(ingreditePorComida);
        }

        private void btnEliminaringredienteporcomida_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarIngredientePorComida_Click(object sender, EventArgs e)
        {

        }

       /*  private void dgvIngreporComida_CurrentCellDirtyStateChanged(object sender, EventArgs e)
             {
                 if(dgvIngreporComida.IsCurrentCellDirty)
                 {
                     dgvIngreporComida.CommitEdit(DataGridViewDataErrorContexts.Commit);
                 }
             }

             private void dgvIngreporComida_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 //
                 // Detecta si se ha seleccionado el header de la grilla
                 //
                 if (e.RowIndex == -1)
                     return;

                 if (dgvIngreporComida.Columns[e.ColumnIndex].Name == "Agregar")
                 {

                     //
                     // Se toma la fila seleccionada
                     //
                     DataGridViewRow row = dgvIngreporComida.Rows[e.RowIndex];

                     //
                     // Se selecciona la celda del checkbox
                     //
                     DataGridViewCheckBoxCell cellSelecion = row.Cells["Agregar"] as DataGridViewCheckBoxCell;

                     if (Convert.ToBoolean(cellSelecion.Value))
                     {

                        row.Cells["Cantidad"].ReadOnly = false;
                        // dgvIngreporComida.Rows[e.RowIndex].Cells["Cantidad"].Selected = true;


                         // dgvIngreporComida.EditMode= DataGridViewEditMode.EditOnEnter;






                         // row.Cells["Cantidad"].ben
                         //row.DefaultCellStyle.BackColor = Color.Green;

                     }
                     //DataGridView.EndEdit.dgvIngreporComida;
                     else
                     {
                         row.Cells["Cantidad"].ReadOnly = true;
                         row.DefaultCellStyle.ApplyStyle(dgvIngreporComida.DefaultCellStyle);


                     }
                 }
             }

             private void dgvIngreporComida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
             {

                if(this.dgvIngreporComida.Columns[e.ColumnIndex].Name=="Agregar")

                     {
                     DataGridViewRow dataGridViewRow = dgvIngreporComida.Rows[e.RowIndex];
                     if (Convert.ToBoolean(e.Value) == true)

                         {
                         dgvIngreporComida.EditMode = DataGridViewEditMode.EditOnEnter;


                         dataGridViewRow.Cells["Cantidad"].ReadOnly = false;

                         dataGridViewRow.DefaultCellStyle.BackColor= Color.GreenYellow;

                         }

                 }
             }

             private void dgvIngreporComida_DataError(object sender, DataGridViewDataErrorEventArgs e)
             {



                 // If the data source raises an exception when a cell value is 
                 // commited, display an error message.
                 if (e.Exception != null &&
                     e.Context == DataGridViewDataErrorContexts.Commit)
                 {
                     //MessageBox.Show("CustomerID value must be unique.");
                 }
             }

             private void dgvIngreporComida_KeyPress(object sender, KeyPressEventArgs c)
             {
                 if ((c.KeyChar < 48 || c.KeyChar > 57) && c.KeyChar != 8 && c.KeyChar != 13 && c.KeyChar != '.')
                 {
                     c.Handled = true;

                 }
             }*/
    }
}
