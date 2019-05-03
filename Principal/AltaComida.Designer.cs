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
            this.btnagregarcomida = new System.Windows.Forms.Button();
            this.btnmodificarcomida = new System.Windows.Forms.Button();
            this.comida = new System.Windows.Forms.Label();
            this.preciocomida = new System.Windows.Forms.Label();
            this.textComida = new System.Windows.Forms.TextBox();
            this.textcomidaprecio = new System.Windows.Forms.TextBox();
            this.dgvlistacomida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistacomida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregarcomida
            // 
            this.btnagregarcomida.Location = new System.Drawing.Point(120, 216);
            this.btnagregarcomida.Name = "btnagregarcomida";
            this.btnagregarcomida.Size = new System.Drawing.Size(75, 23);
            this.btnagregarcomida.TabIndex = 0;
            this.btnagregarcomida.Text = "Agregar";
            this.btnagregarcomida.UseVisualStyleBackColor = true;
            this.btnagregarcomida.Click += new System.EventHandler(this.btnagregarcomida_Click);
            // 
            // btnmodificarcomida
            // 
            this.btnmodificarcomida.Location = new System.Drawing.Point(226, 215);
            this.btnmodificarcomida.Name = "btnmodificarcomida";
            this.btnmodificarcomida.Size = new System.Drawing.Size(75, 23);
            this.btnmodificarcomida.TabIndex = 1;
            this.btnmodificarcomida.Text = "Modificar";
            this.btnmodificarcomida.UseVisualStyleBackColor = true;
            // 
            // comida
            // 
            this.comida.AutoSize = true;
            this.comida.Location = new System.Drawing.Point(102, 62);
            this.comida.Name = "comida";
            this.comida.Size = new System.Drawing.Size(45, 13);
            this.comida.TabIndex = 2;
            this.comida.Text = "Comida:";
            // 
            // preciocomida
            // 
            this.preciocomida.AutoSize = true;
            this.preciocomida.Location = new System.Drawing.Point(102, 104);
            this.preciocomida.Name = "preciocomida";
            this.preciocomida.Size = new System.Drawing.Size(40, 13);
            this.preciocomida.TabIndex = 3;
            this.preciocomida.Text = "Precio:";
            // 
            // textComida
            // 
            this.textComida.Location = new System.Drawing.Point(164, 62);
            this.textComida.Name = "textComida";
            this.textComida.Size = new System.Drawing.Size(100, 20);
            this.textComida.TabIndex = 4;
            // 
            // textcomidaprecio
            // 
            this.textcomidaprecio.Location = new System.Drawing.Point(164, 101);
            this.textcomidaprecio.Name = "textcomidaprecio";
            this.textcomidaprecio.Size = new System.Drawing.Size(100, 20);
            this.textcomidaprecio.TabIndex = 5;
            // 
            // dgvlistacomida
            // 
            this.dgvlistacomida.AllowUserToAddRows = false;
            this.dgvlistacomida.AllowUserToDeleteRows = false;
            this.dgvlistacomida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistacomida.Location = new System.Drawing.Point(384, 37);
            this.dgvlistacomida.Name = "dgvlistacomida";
            this.dgvlistacomida.ReadOnly = true;
            this.dgvlistacomida.Size = new System.Drawing.Size(372, 224);
            this.dgvlistacomida.TabIndex = 6;
            // 
            // AltaComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvlistacomida);
            this.Controls.Add(this.textcomidaprecio);
            this.Controls.Add(this.textComida);
            this.Controls.Add(this.preciocomida);
            this.Controls.Add(this.comida);
            this.Controls.Add(this.btnmodificarcomida);
            this.Controls.Add(this.btnagregarcomida);
            this.Name = "AltaComida";
            this.Text = "AltaComida";
            this.Load += new System.EventHandler(this.AltaComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistacomida)).EndInit();
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
    }
}