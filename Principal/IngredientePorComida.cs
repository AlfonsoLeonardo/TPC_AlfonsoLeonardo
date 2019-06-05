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
                

                comida=(Comida)cboComida.SelectedItem;
                int xx = comida.Id;

               
                dgvIngreporComida.DataSource = porComidaNegocio.ListarIngredienteporcomida(xx);
                //dgvIngreporComida.Rows[2] = false;
                
                dgvIngreporComida.Columns["Nombre"].ReadOnly = true;
                dgvIngreporComida.Columns["Cantidad"].ReadOnly = true;
                dgvIngreporComida.Columns[1].Visible = false;
                dgvIngreporComida.Columns[4].Visible = false;



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

        private void dgvIngreporComida_CurrentCellDirtyStateChanged(object sender, EventArgs e)
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
                    
                   // row.Cells["Cantidad"].ReadOnly = false;
                    dgvIngreporComida.Rows[e.RowIndex].Cells["Cantidad"].Selected = true;
                    // dgvIngreporComida.EditMode= DataGridViewEditMode.EditOnEnter;






                    // row.Cells["Cantidad"].ben
                    //row.DefaultCellStyle.BackColor = Color.Green;

                }
                //DataGridView.EndEdit.dgvIngreporComida;
                else
                {
                    row.Cells["Cantidad"].ReadOnly = true;
                    row.DefaultCellStyle.ApplyStyle(dgvIngreporComida.DefaultCellStyle);
                    
                    //row.Cells["Cantidad"]

                    //row.Cells["Agregar"].ReadOnly = true;
                    //row.DefaultCellStyle.BackColor = Color.White;
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

        private void dgvIngreporComida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
