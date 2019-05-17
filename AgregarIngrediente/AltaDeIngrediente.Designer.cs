namespace AgregarIngrediente
{
    partial class FormIngredientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textNombreIngrediente = new System.Windows.Forms.TextBox();
            this.textCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.textPrecioIngrediente = new System.Windows.Forms.TextBox();
            this.AceptarAgregaIngrediente = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboUnidadmedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.Color.White;
            this.labelnombre.Location = new System.Drawing.Point(85, 77);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(101, 25);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidad.ForeColor = System.Drawing.Color.White;
            this.labelcantidad.Location = new System.Drawing.Point(85, 118);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(114, 25);
            this.labelcantidad.TabIndex = 1;
            this.labelcantidad.Text = "Cantidad:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(85, 202);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(81, 25);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // textNombreIngrediente
            // 
            this.textNombreIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreIngrediente.Location = new System.Drawing.Point(198, 75);
            this.textNombreIngrediente.Name = "textNombreIngrediente";
            this.textNombreIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textNombreIngrediente.TabIndex = 4;
            // 
            // textCantidadIngrediente
            // 
            this.textCantidadIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadIngrediente.Location = new System.Drawing.Point(198, 115);
            this.textCantidadIngrediente.Name = "textCantidadIngrediente";
            this.textCantidadIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textCantidadIngrediente.TabIndex = 5;
            // 
            // textPrecioIngrediente
            // 
            this.textPrecioIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioIngrediente.Location = new System.Drawing.Point(198, 198);
            this.textPrecioIngrediente.Name = "textPrecioIngrediente";
            this.textPrecioIngrediente.Size = new System.Drawing.Size(147, 29);
            this.textPrecioIngrediente.TabIndex = 6;
            // 
            // AceptarAgregaIngrediente
            // 
            this.AceptarAgregaIngrediente.Location = new System.Drawing.Point(223, 325);
            this.AceptarAgregaIngrediente.Name = "AceptarAgregaIngrediente";
            this.AceptarAgregaIngrediente.Size = new System.Drawing.Size(113, 55);
            this.AceptarAgregaIngrediente.TabIndex = 7;
            this.AceptarAgregaIngrediente.Text = "Aceptar";
            this.AceptarAgregaIngrediente.UseVisualStyleBackColor = true;
            this.AceptarAgregaIngrediente.Click += new System.EventHandler(this.AceptarAgregaIngrediente_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(389, 28);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.Size = new System.Drawing.Size(708, 470);
            this.dgvIngredientes.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(751, 518);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 53);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // cboUnidadmedida
            // 
            this.cboUnidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadmedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadmedida.FormattingEnabled = true;
            this.cboUnidadmedida.Location = new System.Drawing.Point(277, 150);
            this.cboUnidadmedida.Name = "cboUnidadmedida";
            this.cboUnidadmedida.Size = new System.Drawing.Size(68, 32);
            this.cboUnidadmedida.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unidad Medida:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 55);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(510, 518);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 53);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUnidadmedida);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.AceptarAgregaIngrediente);
            this.Controls.Add(this.textPrecioIngrediente);
            this.Controls.Add(this.textCantidadIngrediente);
            this.Controls.Add(this.textNombreIngrediente);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labelnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngredientes";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.FormIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelcantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textNombreIngrediente;
        private System.Windows.Forms.TextBox textCantidadIngrediente;
        private System.Windows.Forms.TextBox textPrecioIngrediente;
        private System.Windows.Forms.Button AceptarAgregaIngrediente;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboUnidadmedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

