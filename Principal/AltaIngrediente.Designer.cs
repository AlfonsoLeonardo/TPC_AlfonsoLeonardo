using System.Drawing;
using System.Windows.Forms;

namespace Principal
{
    partial class AltaIngrediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lBusqueda = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AceptarAgregaIngrediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnidadmedida = new System.Windows.Forms.ComboBox();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.textPrecioIngrediente = new System.Windows.Forms.TextBox();
            this.textCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.textNombreIngrediente = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.lIngredienteexiste = new System.Windows.Forms.Label();
            this.lTxtvacioNombre = new System.Windows.Forms.Label();
            this.ltxtprecioingrediente = new System.Windows.Forms.Label();
            this.ltxtcantidadIngrediente = new System.Windows.Forms.Label();
            this.pnNombreing = new System.Windows.Forms.Panel();
            this.pnPrecioing = new System.Windows.Forms.Panel();
            this.pnCantidading = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.pnNombreing.SuspendLayout();
            this.pnPrecioing.SuspendLayout();
            this.pnCantidading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBusqueda
            // 
            this.lBusqueda.AutoSize = true;
            this.lBusqueda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBusqueda.ForeColor = System.Drawing.Color.White;
            this.lBusqueda.Location = new System.Drawing.Point(385, 48);
            this.lBusqueda.Name = "lBusqueda";
            this.lBusqueda.Size = new System.Drawing.Size(120, 25);
            this.lBusqueda.TabIndex = 34;
            this.lBusqueda.Text = "Busqueda:";
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(516, 46);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(147, 29);
            this.textBusqueda.TabIndex = 7;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(446, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 55);
            this.panel3.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(-2, -2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 55);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnModificar);
            this.panel4.Location = new System.Drawing.Point(635, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 55);
            this.panel4.TabIndex = 32;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(-2, -2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 55);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(38, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 55);
            this.panel2.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(-2, -2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 55);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AceptarAgregaIngrediente);
            this.panel1.Location = new System.Drawing.Point(180, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 55);
            this.panel1.TabIndex = 29;
            // 
            // AceptarAgregaIngrediente
            // 
            this.AceptarAgregaIngrediente.FlatAppearance.BorderSize = 0;
            this.AceptarAgregaIngrediente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AceptarAgregaIngrediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AceptarAgregaIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarAgregaIngrediente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarAgregaIngrediente.ForeColor = System.Drawing.Color.White;
            this.AceptarAgregaIngrediente.Location = new System.Drawing.Point(-2, -2);
            this.AceptarAgregaIngrediente.Name = "AceptarAgregaIngrediente";
            this.AceptarAgregaIngrediente.Size = new System.Drawing.Size(113, 55);
            this.AceptarAgregaIngrediente.TabIndex = 5;
            this.AceptarAgregaIngrediente.Text = "Ingresar";
            this.AceptarAgregaIngrediente.UseVisualStyleBackColor = true;
            this.AceptarAgregaIngrediente.Click += new System.EventHandler(this.AceptarAgregaIngrediente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Unidad Medida:";
            // 
            // cboUnidadmedida
            // 
            this.cboUnidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadmedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadmedida.FormattingEnabled = true;
            this.cboUnidadmedida.ItemHeight = 24;
            this.cboUnidadmedida.Location = new System.Drawing.Point(242, 292);
            this.cboUnidadmedida.Name = "cboUnidadmedida";
            this.cboUnidadmedida.Size = new System.Drawing.Size(68, 32);
            this.cboUnidadmedida.TabIndex = 2;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngredientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvIngredientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngredientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngredientes.ColumnHeadersHeight = 20;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngredientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIngredientes.EnableHeadersVisualStyles = false;
            this.dgvIngredientes.GridColor = System.Drawing.Color.White;
            this.dgvIngredientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvIngredientes.Location = new System.Drawing.Point(344, 57);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvIngredientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIngredientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(708, 424);
            this.dgvIngredientes.TabIndex = 8;
            // 
            // textPrecioIngrediente
            // 
            this.textPrecioIngrediente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textPrecioIngrediente.Location = new System.Drawing.Point(4, 3);
            this.textPrecioIngrediente.Name = "textPrecioIngrediente";
            this.textPrecioIngrediente.Size = new System.Drawing.Size(147, 30);
            this.textPrecioIngrediente.TabIndex = 4;
            this.textPrecioIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecioIngrediente_KeyPress);
            // 
            // textCantidadIngrediente
            // 
            this.textCantidadIngrediente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textCantidadIngrediente.Location = new System.Drawing.Point(4, 3);
            this.textCantidadIngrediente.Name = "textCantidadIngrediente";
            this.textCantidadIngrediente.Size = new System.Drawing.Size(143, 30);
            this.textCantidadIngrediente.TabIndex = 2;
            this.textCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidadIngrediente_KeyPress);
            // 
            // textNombreIngrediente
            // 
            this.textNombreIngrediente.BackColor = System.Drawing.Color.White;
            this.textNombreIngrediente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textNombreIngrediente.Location = new System.Drawing.Point(3, 3);
            this.textNombreIngrediente.Name = "textNombreIngrediente";
            this.textNombreIngrediente.Size = new System.Drawing.Size(164, 30);
            this.textNombreIngrediente.TabIndex = 1;
            this.textNombreIngrediente.TabStop = false;
            this.textNombreIngrediente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNombreIngrediente_KeyDown);
            this.textNombreIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreIngrediente_KeyPress);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(33, 218);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(81, 25);
            this.labelPrecio.TabIndex = 22;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidad.ForeColor = System.Drawing.Color.White;
            this.labelcantidad.Location = new System.Drawing.Point(33, 136);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(114, 25);
            this.labelcantidad.TabIndex = 21;
            this.labelcantidad.Text = "Cantidad:";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.Color.White;
            this.labelnombre.Location = new System.Drawing.Point(33, 71);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(101, 25);
            this.labelnombre.TabIndex = 20;
            this.labelnombre.Text = "Nombre:";
            // 
            // lIngredienteexiste
            // 
            this.lIngredienteexiste.AutoSize = true;
            this.lIngredienteexiste.BackColor = System.Drawing.Color.Red;
            this.lIngredienteexiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIngredienteexiste.ForeColor = System.Drawing.Color.White;
            this.lIngredienteexiste.Location = new System.Drawing.Point(180, 102);
            this.lIngredienteexiste.Name = "lIngredienteexiste";
            this.lIngredienteexiste.Size = new System.Drawing.Size(130, 13);
            this.lIngredienteexiste.TabIndex = 35;
            this.lIngredienteexiste.Text = "*Ingrediente ya existe";
            this.lIngredienteexiste.Visible = false;
            // 
            // lTxtvacioNombre
            // 
            this.lTxtvacioNombre.AutoSize = true;
            this.lTxtvacioNombre.BackColor = System.Drawing.Color.Red;
            this.lTxtvacioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTxtvacioNombre.ForeColor = System.Drawing.Color.White;
            this.lTxtvacioNombre.Location = new System.Drawing.Point(96, 102);
            this.lTxtvacioNombre.Name = "lTxtvacioNombre";
            this.lTxtvacioNombre.Size = new System.Drawing.Size(214, 13);
            this.lTxtvacioNombre.TabIndex = 36;
            this.lTxtvacioNombre.Text = "*Debe ingresar al menos un caracter";
            this.lTxtvacioNombre.Visible = false;
            // 
            // ltxtprecioingrediente
            // 
            this.ltxtprecioingrediente.AutoSize = true;
            this.ltxtprecioingrediente.BackColor = System.Drawing.Color.Red;
            this.ltxtprecioingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtprecioingrediente.ForeColor = System.Drawing.Color.White;
            this.ltxtprecioingrediente.Location = new System.Drawing.Point(79, 247);
            this.ltxtprecioingrediente.Name = "ltxtprecioingrediente";
            this.ltxtprecioingrediente.Size = new System.Drawing.Size(231, 13);
            this.ltxtprecioingrediente.TabIndex = 38;
            this.ltxtprecioingrediente.Text = "*Debe ingresar un numero mayor a cero";
            this.ltxtprecioingrediente.Visible = false;
            // 
            // ltxtcantidadIngrediente
            // 
            this.ltxtcantidadIngrediente.AutoSize = true;
            this.ltxtcantidadIngrediente.BackColor = System.Drawing.Color.Red;
            this.ltxtcantidadIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtcantidadIngrediente.ForeColor = System.Drawing.Color.White;
            this.ltxtcantidadIngrediente.Location = new System.Drawing.Point(79, 167);
            this.ltxtcantidadIngrediente.Name = "ltxtcantidadIngrediente";
            this.ltxtcantidadIngrediente.Size = new System.Drawing.Size(231, 13);
            this.ltxtcantidadIngrediente.TabIndex = 39;
            this.ltxtcantidadIngrediente.Text = "*Debe ingresar un numero mayor a cero";
            this.ltxtcantidadIngrediente.Visible = false;
            // 
            // pnNombreing
            // 
            this.pnNombreing.BackColor = System.Drawing.Color.Black;
            this.pnNombreing.Controls.Add(this.textNombreIngrediente);
            this.pnNombreing.Location = new System.Drawing.Point(140, 63);
            this.pnNombreing.Name = "pnNombreing";
            this.pnNombreing.Size = new System.Drawing.Size(170, 36);
            this.pnNombreing.TabIndex = 40;
            // 
            // pnPrecioing
            // 
            this.pnPrecioing.BackColor = System.Drawing.Color.Black;
            this.pnPrecioing.Controls.Add(this.textPrecioIngrediente);
            this.pnPrecioing.Location = new System.Drawing.Point(156, 208);
            this.pnPrecioing.Name = "pnPrecioing";
            this.pnPrecioing.Size = new System.Drawing.Size(154, 36);
            this.pnPrecioing.TabIndex = 0;
            // 
            // pnCantidading
            // 
            this.pnCantidading.BackColor = System.Drawing.Color.Black;
            this.pnCantidading.Controls.Add(this.textCantidadIngrediente);
            this.pnCantidading.Location = new System.Drawing.Point(159, 128);
            this.pnCantidading.Name = "pnCantidading";
            this.pnCantidading.Size = new System.Drawing.Size(151, 36);
            this.pnCantidading.TabIndex = 0;
            // 
            // AltaIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1084, 570);
            this.Controls.Add(this.pnCantidading);
            this.Controls.Add(this.pnPrecioing);
            this.Controls.Add(this.pnNombreing);
            this.Controls.Add(this.ltxtcantidadIngrediente);
            this.Controls.Add(this.ltxtprecioingrediente);
            this.Controls.Add(this.lTxtvacioNombre);
            this.Controls.Add(this.lIngredienteexiste);
            this.Controls.Add(this.lBusqueda);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUnidadmedida);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labelnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaIngrediente";
            this.Text = "AltaIngrediente";
            this.Load += new System.EventHandler(this.AltaIngrediente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreIngrediente_KeyPress);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.pnNombreing.ResumeLayout(false);
            this.pnNombreing.PerformLayout();
            this.pnPrecioing.ResumeLayout(false);
            this.pnPrecioing.PerformLayout();
            this.pnCantidading.ResumeLayout(false);
            this.pnCantidading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBusqueda;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AceptarAgregaIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUnidadmedida;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.TextBox textPrecioIngrediente;
        private System.Windows.Forms.TextBox textCantidadIngrediente;
        private System.Windows.Forms.TextBox textNombreIngrediente;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelcantidad;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label lIngredienteexiste;
        private System.Windows.Forms.Label lTxtvacioNombre;
        private System.Windows.Forms.Label ltxtprecioingrediente;
        private System.Windows.Forms.Label ltxtcantidadIngrediente;
        private Panel pnNombreing;
        private Panel pnPrecioing;
        private Panel pnCantidading;
    }
}