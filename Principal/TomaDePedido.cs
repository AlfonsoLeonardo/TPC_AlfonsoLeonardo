using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Principal
{
    public partial class TomaDePedido : Form
    {

        private List<ComidaM> listaEmpanadaLocal;
        public TomaDePedido()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {

            ComidaPorOrdenNegocio negocio = new ComidaPorOrdenNegocio();
            
            try
            {
                DataGridViewButtonColumn btnSumar = new DataGridViewButtonColumn();
                DataGridViewButtonColumn btnRestar = new DataGridViewButtonColumn();
                btnSumar.Name = "Agregar";
                btnRestar.Name = "Restar";

                listaEmpanadaLocal = negocio.ListarComidaMEmpanada();
                dgvempanadas.DataSource = listaEmpanadaLocal;
                dgvempanadas.Columns[0].Visible = false;
                dgvempanadas.Columns[2].Visible = false;
                dgvempanadas.Columns.Add(btnRestar);
                dgvempanadas.Columns.Add(btnSumar);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TomaDePedido_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void dgvempanadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvempanadas.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvempanadas.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\mass.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                
                this.dgvempanadas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvempanadas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
                
                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvempanadas.Columns[e.ColumnIndex].Name == "Restar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvempanadas.Rows[e.RowIndex].Cells["Restar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\menos.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvempanadas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvempanadas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8  ;
                
                e.Handled = true;
            }
        }

        private void dgvempanadas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvempanadas.IsCurrentCellDirty)
            {
                dgvempanadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvempanadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvempanadas.Columns[e.ColumnIndex].Name == "Agregar")
            {
                this.dgvempanadas.Rows[e.RowIndex].Cells["Cantidad"].Value = (1 + Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString())).ToString();
            }

            if (dgvempanadas.Columns[e.ColumnIndex].Name == "Restar")
            {
                int x = Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                if (x > 0)
                {
                    this.dgvempanadas.Rows[e.RowIndex].Cells["Cantidad"].Value = (Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString()) - 1).ToString();
                }
            }

        }

        private void dgvempanadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
