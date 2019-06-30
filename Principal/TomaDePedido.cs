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

        private List<Comida> listaLocal;

        public TomaDePedido()
        {
            InitializeComponent();
        }


        public int Ancho(DataGridView x)
        {
            int width = 0;
            int Y = 0;
            foreach (DataGridViewColumn col in x.Columns)
            {

                if (x.Columns[Y].Visible == true)
                {
                    width += col.Width;
                   // width += x.RowHeadersWidth;
                }
               // width += x.RowHeadersWidth;
                Y++;
                
            }
            
            return width;
        }

        public int Alto(DataGridView x)
        {
            int height = 0;
            foreach (DataGridViewRow row in x.Rows)
            {
                height += row.Height;
            }
            height += x.ColumnHeadersHeight;



            return height;
        }

        private void cargarGrilla()
        {

            ComidaPorOrdenNegocio negocio = new ComidaPorOrdenNegocio();

            try
            {
               
                    listaLocal = negocio.ListarComida(1, 6);
                    dgvPizzas.DataSource = listaLocal;

                    dgvPizzas.Columns[0].Visible = false;
                    dgvPizzas.Columns[2].Visible = false;
                    dgvPizzas.Columns[1].ReadOnly = true;
                    dgvPizzas.Columns[3].ReadOnly = true;
                    dgvPizzas.Columns[4].ReadOnly = true;
                    dgvPizzas.Columns[5].ReadOnly = true;
                    dgvPizzas.Location = new Point(3, 35);
                    dgvPizzas.ClientSize = new Size(Ancho(dgvPizzas) + 2, Alto(dgvPizzas) + 2);
                    lPizzas.Location = new Point((Ancho(dgvPizzas) - lPizzas.Width) / 2, 0);
          
                    listaLocal = negocio.ListarComida(2, 9999);
                    dgvempanadas.DataSource = listaLocal;
                    dgvempanadas.Columns[0].Visible = false;
                    dgvempanadas.Columns[2].Visible = false;
                    dgvempanadas.Columns[1].ReadOnly = true;
                    dgvempanadas.Columns[3].ReadOnly = true;
                    dgvempanadas.Columns[4].ReadOnly = true;
                    dgvempanadas.Columns[5].ReadOnly = true;
                    dgvempanadas.Location = new Point(Ancho(dgvPizzas) + 2, 35);

                    dgvempanadas.ClientSize = new Size(Ancho(dgvempanadas) + 2, Alto(dgvempanadas) + 2);

                    lEmpanadas.Location = new Point((Ancho(dgvempanadas) - lEmpanadas.Width) / 2 + Ancho(dgvPizzas), 0);

                    lMilaCombos.Location = new Point((Ancho(dgvPizzas) + 5), Alto(dgvempanadas) + lMilaCombos.Height + 8);

                    dgvMilaCombo.Location = new Point(Ancho(dgvPizzas) + 5, lMilaCombos.Location.Y + lMilaCombos.Height + 2);

                    listaLocal = negocio.ListarComida(8, 10);
                    dgvMilaCombo.DataSource = listaLocal;
                    dgvMilaCombo.Columns[0].Visible = false;
                    dgvMilaCombo.Columns[2].Visible = false;
                    dgvMilaCombo.Columns[1].ReadOnly = true;
                    dgvMilaCombo.Columns[3].ReadOnly = true;
                    dgvMilaCombo.Columns[4].ReadOnly = true;
                    dgvMilaCombo.Columns[5].ReadOnly = true;

                    dgvMilaCombo.ClientSize = new Size(Ancho(dgvMilaCombo) + 2, Alto(dgvMilaCombo) + 2);
                
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



        private void dgvempanadas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvempanadas.IsCurrentCellDirty)
            {
                dgvempanadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvsuperEspecial_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMilaCombo.IsCurrentCellDirty)
            {
                dgvMilaCombo.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvespeciales_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPizzas.IsCurrentCellDirty)
            {
                dgvPizzas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void dgvempanadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvempanadas.Columns[e.ColumnIndex].Name == "M" && e.RowIndex >= 0)
            {
                dgvempanadas.Columns["M"].DefaultCellStyle.NullValue = " + ";
                dgvempanadas.Columns["M"].DefaultCellStyle.BackColor = Color.FromArgb(154, 205, 50);
            }
            if (e.ColumnIndex >= 0 && this.dgvempanadas.Columns[e.ColumnIndex].Name == "R" && e.RowIndex >= 0)
            {
                dgvempanadas.Columns["R"].DefaultCellStyle.NullValue = " - ";
                dgvempanadas.Columns["R"].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
            }


        }
        private void dgvsuperEspecial_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvMilaCombo.Columns[e.ColumnIndex].Name == "M" && e.RowIndex >= 0)
            {
                dgvMilaCombo.Columns["M"].DefaultCellStyle.NullValue = " + ";
                dgvMilaCombo.Columns["M"].DefaultCellStyle.BackColor = Color.FromArgb(154, 205, 50);
            }
            if (e.ColumnIndex >= 0 && this.dgvMilaCombo.Columns[e.ColumnIndex].Name == "R" && e.RowIndex >= 0)
            {
                dgvMilaCombo.Columns["R"].DefaultCellStyle.NullValue = " - ";
                dgvMilaCombo.Columns["R"].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
            }
        }
        private void dgvespeciales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPizzas.Columns[e.ColumnIndex].Name == "M" && e.RowIndex >= 0)
            {
                dgvPizzas.Columns["M"].DefaultCellStyle.NullValue = " + ";
                dgvPizzas.Columns["M"].DefaultCellStyle.BackColor = Color.FromArgb(154, 205, 50);


            }
            if (e.ColumnIndex >= 0 && this.dgvPizzas.Columns[e.ColumnIndex].Name == "R" && e.RowIndex >= 0)
            {

                dgvPizzas.Columns["R"].DefaultCellStyle.NullValue = " - ";
                dgvPizzas.Columns["R"].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);


            }

        }

        private void dgvempanadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvempanadas.Columns[e.ColumnIndex].Name == "M")
            {
                this.dgvempanadas.Rows[e.RowIndex].Cells["C"].Value = (1 + Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["C"].Value.ToString())).ToString();
            }

            if (dgvempanadas.Columns[e.ColumnIndex].Name == "R")
            {
                int x = Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["C"].Value.ToString());
                if (x > 0)
                {
                    this.dgvempanadas.Rows[e.RowIndex].Cells["C"].Value = (Convert.ToInt32(dgvempanadas.Rows[e.RowIndex].Cells["C"].Value.ToString()) - 1).ToString();
                }
            }


        }

        private void dgvsuperEspecial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvMilaCombo.Columns[e.ColumnIndex].Name == "M")
            {
                this.dgvMilaCombo.Rows[e.RowIndex].Cells["C"].Value = (1 + Convert.ToInt32(dgvMilaCombo.Rows[e.RowIndex].Cells["C"].Value.ToString())).ToString();
            }

            if (dgvMilaCombo.Columns[e.ColumnIndex].Name == "R")
            {
                int x = Convert.ToInt32(dgvMilaCombo.Rows[e.RowIndex].Cells["C"].Value.ToString());
                if (x > 0)
                {
                    this.dgvMilaCombo.Rows[e.RowIndex].Cells["C"].Value = (Convert.ToInt32(dgvMilaCombo.Rows[e.RowIndex].Cells["C"].Value.ToString()) - 1).ToString();
                }
            }
            if (dgvMilaCombo.Columns[e.ColumnIndex].Name == "observacion")
            {
                dgvMilaCombo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                dgvMilaCombo.EditMode = DataGridViewEditMode.EditOnEnter;

            }
        }

        private void dgvespeciales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvPizzas.Columns[e.ColumnIndex].Name == "M")
            {
                this.dgvPizzas.Rows[e.RowIndex].Cells["C"].Value = (1 + Convert.ToInt32(dgvPizzas.Rows[e.RowIndex].Cells["C"].Value.ToString())).ToString();
            }

            if (dgvPizzas.Columns[e.ColumnIndex].Name == "R")
            {
                int x = Convert.ToInt32(dgvPizzas.Rows[e.RowIndex].Cells["C"].Value.ToString());
                if (x > 0)
                {
                    this.dgvPizzas.Rows[e.RowIndex].Cells["C"].Value = (Convert.ToInt32(dgvPizzas.Rows[e.RowIndex].Cells["C"].Value.ToString()) - 1).ToString();
                }
            }
            if (dgvPizzas.Columns[e.ColumnIndex].Name == "observacion")
            {
                dgvPizzas.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                dgvPizzas.EditMode = DataGridViewEditMode.EditOnEnter;

            }
        }

        private void lEmpanadas_Click(object sender, EventArgs e)
        {

        }

        private void lPizzas_Click(object sender, EventArgs e)
        {
           
        }
    }
}
