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
            ComidaNegocio negocioc = new ComidaNegocio();
            try
            {
                cboComida.DataSource = negocioc.ListarComida();
                cboComida.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
                cboComida.ValueMember = "Id";// nobre de la variable del id a mostar

                chkingrediente.DataSource = negocio.ListarIngrediente();
                chkingrediente.DisplayMember = "Nombre"; //Nombre de la varible a mostrar en pantalla
                chkingrediente.ValueMember = "Id";// nobre de la variable del id a mostar

                //listaIngredienteLocal = negocio.ListarIngrediente();
                // dgvIngredientes.DataSource = listaIngredienteLocal;
                //dgvIngredientes.Columns[2].Visible = false;
                //dgvIngredientes.Columns[10].Visible = false;
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
