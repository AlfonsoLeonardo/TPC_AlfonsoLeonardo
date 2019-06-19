namespace Principal
{
    partial class AltaComida
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
            this.btnagregarcomida = new System.Windows.Forms.Button();
            this.btnmodificarcomida = new System.Windows.Forms.Button();
            this.comida = new System.Windows.Forms.Label();
            this.preciocomida = new System.Windows.Forms.Label();
            this.textComida = new System.Windows.Forms.TextBox();
            this.textcomidaprecio = new System.Windows.Forms.TextBox();
            this.dgvlistacomida = new System.Windows.Forms.DataGridView();
            this.btnEliminarComida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnNombrecomida = new System.Windows.Forms.Panel();
            this.pnPreciocomida = new System.Windows.Forms.Panel();
            this.lComidaNombre = new System.Windows.Forms.Label();
            this.lComidaexiste = new System.Windows.Forms.Label();
            this.lComidapecio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lBusquedacomi = new System.Windows.Forms.Label();
            this.textBusquedacomida = new System.Windows.Forms.TextBox();
            this.cboTipoComida = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistacomida)).BeginInit();
            this.pnNombrecomida.SuspendLayout();
            this.pnPreciocomida.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnagregarcomida
            // 
            this.btnagregarcomida.FlatAppearance.BorderSize = 0;
            this.btnagregarcomida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnagregarcomida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnagregarcomida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcomida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnagregarcomida.ForeColor = System.Drawing.Color.White;
            this.btnagregarcomida.Location = new System.Drawing.Point(-1, -2);
            this.btnagregarcomida.Name = "btnagregarcomida";
            this.btnagregarcomida.Size = new System.Drawing.Size(113, 55);
            this.btnagregarcomida.TabIndex = 0;
            this.btnagregarcomida.Text = "Agregar";
            this.btnagregarcomida.UseVisualStyleBackColor = true;
            this.btnagregarcomida.Click += new System.EventHandler(this.btnagregarcomida_Click);
            // 
            // btnmodificarcomida
            // 
            this.btnmodificarcomida.FlatAppearance.BorderSize = 0;
            this.btnmodificarcomida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnmodificarcomida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmodificarcomida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificarcomida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnmodificarcomida.ForeColor = System.Drawing.Color.White;
            this.btnmodificarcomida.Location = new System.Drawing.Point(-2, -2);
            this.btnmodificarcomida.Name = "btnmodificarcomida";
            this.btnmodificarcomida.Size = new System.Drawing.Size(113, 55);
            this.btnmodificarcomida.TabIndex = 1;
            this.btnmodificarcomida.Text = "Modificar";
            this.btnmodificarcomida.UseVisualStyleBackColor = true;
            this.btnmodificarcomida.Click += new System.EventHandler(this.btnmodificarcomida_Click);
            // 
            // comida
            // 
            this.comida.AutoSize = true;
            this.comida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.comida.ForeColor = System.Drawing.Color.White;
            this.comida.Location = new System.Drawing.Point(36, 130);
            this.comida.Name = "comida";
            this.comida.Size = new System.Drawing.Size(100, 25);
            this.comida.TabIndex = 2;
            this.comida.Text = "Comida:";
            // 
            // preciocomida
            // 
            this.preciocomida.AutoSize = true;
            this.preciocomida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.preciocomida.ForeColor = System.Drawing.Color.White;
            this.preciocomida.Location = new System.Drawing.Point(39, 186);
            this.preciocomida.Name = "preciocomida";
            this.preciocomida.Size = new System.Drawing.Size(81, 25);
            this.preciocomida.TabIndex = 3;
            this.preciocomida.Text = "Precio:";
            // 
            // textComida
            // 
            this.textComida.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textComida.Location = new System.Drawing.Point(3, 3);
            this.textComida.Name = "textComida";
            this.textComida.Size = new System.Drawing.Size(164, 30);
            this.textComida.TabIndex = 4;
            // 
            // textcomidaprecio
            // 
            this.textcomidaprecio.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.textcomidaprecio.Location = new System.Drawing.Point(3, 3);
            this.textcomidaprecio.Name = "textcomidaprecio";
            this.textcomidaprecio.Size = new System.Drawing.Size(164, 30);
            this.textcomidaprecio.TabIndex = 5;
            this.textcomidaprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcomidaprecio_KeyPress);
            // 
            // dgvlistacomida
            // 
            this.dgvlistacomida.AllowUserToAddRows = false;
            this.dgvlistacomida.AllowUserToDeleteRows = false;
            this.dgvlistacomida.AllowUserToResizeColumns = false;
            this.dgvlistacomida.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistacomida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlistacomida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlistacomida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvlistacomida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvlistacomida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlistacomida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistacomida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlistacomida.ColumnHeadersHeight = 20;
            this.dgvlistacomida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlistacomida.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlistacomida.EnableHeadersVisualStyles = false;
            this.dgvlistacomida.GridColor = System.Drawing.Color.White;
            this.dgvlistacomida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvlistacomida.Location = new System.Drawing.Point(364, 47);
            this.dgvlistacomida.MultiSelect = false;
            this.dgvlistacomida.Name = "dgvlistacomida";
            this.dgvlistacomida.ReadOnly = true;
            this.dgvlistacomida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlistacomida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvlistacomida.RowHeadersVisible = false;
            this.dgvlistacomida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvlistacomida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvlistacomida.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvlistacomida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistacomida.Size = new System.Drawing.Size(708, 511);
            this.dgvlistacomida.TabIndex = 8;
            // 
            // btnEliminarComida
            // 
            this.btnEliminarComida.FlatAppearance.BorderSize = 0;
            this.btnEliminarComida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminarComida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarComida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarComida.ForeColor = System.Drawing.Color.White;
            this.btnEliminarComida.Location = new System.Drawing.Point(-2, -2);
            this.btnEliminarComida.Name = "btnEliminarComida";
            this.btnEliminarComida.Size = new System.Drawing.Size(113, 55);
            this.btnEliminarComida.TabIndex = 7;
            this.btnEliminarComida.Text = "Eliminar";
            this.btnEliminarComida.UseVisualStyleBackColor = true;
            this.btnEliminarComida.Click += new System.EventHandler(this.btnEliminarComida_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnNombrecomida
            // 
            this.pnNombrecomida.BackColor = System.Drawing.Color.Black;
            this.pnNombrecomida.Controls.Add(this.textComida);
            this.pnNombrecomida.Location = new System.Drawing.Point(136, 119);
            this.pnNombrecomida.Name = "pnNombrecomida";
            this.pnNombrecomida.Size = new System.Drawing.Size(170, 36);
            this.pnNombrecomida.TabIndex = 41;
            // 
            // pnPreciocomida
            // 
            this.pnPreciocomida.BackColor = System.Drawing.Color.Black;
            this.pnPreciocomida.Controls.Add(this.textcomidaprecio);
            this.pnPreciocomida.Location = new System.Drawing.Point(139, 175);
            this.pnPreciocomida.Name = "pnPreciocomida";
            this.pnPreciocomida.Size = new System.Drawing.Size(170, 36);
            this.pnPreciocomida.TabIndex = 42;
            // 
            // lComidaNombre
            // 
            this.lComidaNombre.AutoSize = true;
            this.lComidaNombre.BackColor = System.Drawing.Color.Red;
            this.lComidaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComidaNombre.ForeColor = System.Drawing.Color.White;
            this.lComidaNombre.Location = new System.Drawing.Point(92, 158);
            this.lComidaNombre.Name = "lComidaNombre";
            this.lComidaNombre.Size = new System.Drawing.Size(214, 13);
            this.lComidaNombre.TabIndex = 44;
            this.lComidaNombre.Text = "*Debe ingresar al menos un caracter";
            this.lComidaNombre.Visible = false;
            // 
            // lComidaexiste
            // 
            this.lComidaexiste.AutoSize = true;
            this.lComidaexiste.BackColor = System.Drawing.Color.Red;
            this.lComidaexiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComidaexiste.ForeColor = System.Drawing.Color.White;
            this.lComidaexiste.Location = new System.Drawing.Point(176, 158);
            this.lComidaexiste.Name = "lComidaexiste";
            this.lComidaexiste.Size = new System.Drawing.Size(130, 13);
            this.lComidaexiste.TabIndex = 43;
            this.lComidaexiste.Text = "*Ingrediente ya existe";
            this.lComidaexiste.Visible = false;
            // 
            // lComidapecio
            // 
            this.lComidapecio.AutoSize = true;
            this.lComidapecio.BackColor = System.Drawing.Color.Red;
            this.lComidapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComidapecio.ForeColor = System.Drawing.Color.White;
            this.lComidapecio.Location = new System.Drawing.Point(75, 214);
            this.lComidapecio.Name = "lComidapecio";
            this.lComidapecio.Size = new System.Drawing.Size(231, 13);
            this.lComidapecio.TabIndex = 45;
            this.lComidapecio.Text = "*Debe ingresar un numero mayor a cero";
            this.lComidapecio.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(54, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 55);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnagregarcomida);
            this.panel1.Location = new System.Drawing.Point(196, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 55);
            this.panel1.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnEliminarComida);
            this.panel3.Location = new System.Drawing.Point(95, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 55);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnmodificarcomida);
            this.panel4.Location = new System.Drawing.Point(237, 461);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 55);
            this.panel4.TabIndex = 48;
            // 
            // lBusquedacomi
            // 
            this.lBusquedacomi.AutoSize = true;
            this.lBusquedacomi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBusquedacomi.ForeColor = System.Drawing.Color.White;
            this.lBusquedacomi.Location = new System.Drawing.Point(399, 14);
            this.lBusquedacomi.Name = "lBusquedacomi";
            this.lBusquedacomi.Size = new System.Drawing.Size(120, 25);
            this.lBusquedacomi.TabIndex = 51;
            this.lBusquedacomi.Text = "Busqueda:";
            // 
            // textBusquedacomida
            // 
            this.textBusquedacomida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusquedacomida.Location = new System.Drawing.Point(530, 12);
            this.textBusquedacomida.Name = "textBusquedacomida";
            this.textBusquedacomida.Size = new System.Drawing.Size(147, 29);
            this.textBusquedacomida.TabIndex = 50;
            this.textBusquedacomida.TextChanged += new System.EventHandler(this.textBusquedacomida_TextChanged);
            // 
            // cboTipoComida
            // 
            this.cboTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoComida.FormattingEnabled = true;
            this.cboTipoComida.Location = new System.Drawing.Point(182, 246);
            this.cboTipoComida.Name = "cboTipoComida";
            this.cboTipoComida.Size = new System.Drawing.Size(121, 21);
            this.cboTipoComida.TabIndex = 52;
            // 
            // AltaComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1084, 570);
            this.Controls.Add(this.cboTipoComida);
            this.Controls.Add(this.lBusquedacomi);
            this.Controls.Add(this.textBusquedacomida);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lComidapecio);
            this.Controls.Add(this.lComidaNombre);
            this.Controls.Add(this.lComidaexiste);
            this.Controls.Add(this.pnPreciocomida);
            this.Controls.Add(this.pnNombrecomida);
            this.Controls.Add(this.dgvlistacomida);
            this.Controls.Add(this.preciocomida);
            this.Controls.Add(this.comida);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaComida";
            this.Text = "AltaComida";
            this.Load += new System.EventHandler(this.AltaComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistacomida)).EndInit();
            this.pnNombrecomida.ResumeLayout(false);
            this.pnNombrecomida.PerformLayout();
            this.pnPreciocomida.ResumeLayout(false);
            this.pnPreciocomida.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregarcomida;
        private System.Windows.Forms.Button btnmodificarcomida;
        private System.Windows.Forms.Label comida;
        private System.Windows.Forms.Label preciocomida;
        private System.Windows.Forms.TextBox textComida;
        private System.Windows.Forms.TextBox textcomidaprecio;
        private System.Windows.Forms.DataGridView dgvlistacomida;
        private System.Windows.Forms.Button btnEliminarComida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnNombrecomida;
        private System.Windows.Forms.Panel pnPreciocomida;
        private System.Windows.Forms.Label lComidaNombre;
        private System.Windows.Forms.Label lComidaexiste;
        private System.Windows.Forms.Label lComidapecio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lBusquedacomi;
        private System.Windows.Forms.TextBox textBusquedacomida;
        private System.Windows.Forms.ComboBox cboTipoComida;
    }
}