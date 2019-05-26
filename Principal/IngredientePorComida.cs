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
            try
            {
                cboComida.DataSource = negocioc.ListarComida();
                cboComida.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
                cboComida.ValueMember = "Id";// nobre de la variable del id a mostar

                chkingrediente.DataSource = negocio.ListarIngrediente();
                chkingrediente.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
                chkingrediente.ValueMember = "Id";// nobre de la variable del id a mostar


               // DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
               // checkBoxColumn.HeaderText = "Agregar";
                
                //DataGridViewTextBoxColumn Catn = new DataGridViewTextBoxColumn();
               // Catn.HeaderText = "Cantidad";
                
                dgvIngreporComida.DataSource = porComidaNegocio.ListarIngredienteporcomida();
               // dgvIngreporComida.Columns.Add(checkBoxColumn);
               // dgvIngreporComida.Columns.Add(Catn);
    


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void IngredientePorComida_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
