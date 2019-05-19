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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
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
            this.textBusqueda.TabIndex = 33;
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
            this.btnEliminar.TabIndex = 14;
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
            this.btnModificar.TabIndex = 9;
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
            this.btnCancelar.TabIndex = 13;
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
            this.AceptarAgregaIngrediente.TabIndex = 7;
            this.AceptarAgregaIngrediente.Text = "Ingresar";
            this.AceptarAgregaIngrediente.UseVisualStyleBackColor = true;
            this.AceptarAgregaIngrediente.Click += new System.EventHandler(this.AceptarAgregaIngrediente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 206);
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
            this.cboUnidadmedida.Location = new System.Drawing.Point(225, 201);
            this.cboUnidadmedida.Name = "cboUnidadmedida";
            this.cboUnidadmedida.Size = new System.Drawing.Size(68, 32);
            this.cboUnidadmedida.TabIndex = 27;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvIngredientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvIngredientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngredientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvIngredientes.ColumnHeadersHeight = 20;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngredientes.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvIngredientes.EnableHeadersVisualStyles = false;
            this.dgvIngredientes.GridColor = System.Drawing.Color.White;
            this.dgvIngredientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvIngredientes.Location = new System.Drawing.Point(343, 126);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvIngredientes.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvIngredientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(708, 365);
            this.dgvIngredientes.TabIndex = 26;
            // 
            // textPrecioIngrediente
            // 
            this.textPrecioIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioIngrediente.Location = new System.Drawing.Point(146, 249);
            this.textPrecioIngrediente.Name = "textPrecioIngrediente";
            this.textPrecioIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textPrecioIngrediente.TabIndex = 25;
            // 
            // textCantidadIngrediente
            // 
            this.textCantidadIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadIngrediente.Location = new System.Drawing.Point(146, 166);
            this.textCantidadIngrediente.Name = "textCantidadIngrediente";
            this.textCantidadIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textCantidadIngrediente.TabIndex = 24;
            // 
            // textNombreIngrediente
            // 
            this.textNombreIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreIngrediente.Location = new System.Drawing.Point(146, 126);
            this.textNombreIngrediente.Name = "textNombreIngrediente";
            this.textNombreIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textNombreIngrediente.TabIndex = 23;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(33, 253);
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
            this.labelcantidad.Location = new System.Drawing.Point(33, 169);
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
            this.labelnombre.Location = new System.Drawing.Point(33, 128);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(101, 25);
            this.labelnombre.TabIndex = 20;
            this.labelnombre.Text = "Nombre:";
            // 
            // AltaIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1084, 613);
            this.Controls.Add(this.lBusqueda);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUnidadmedida);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.textPrecioIngrediente);
            this.Controls.Add(this.textCantidadIngrediente);
            this.Controls.Add(this.textNombreIngrediente);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labelnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaIngrediente";
            this.Text = "AltaIngrediente";
            this.Load += new System.EventHandler(this.AltaIngrediente_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
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
    }
}