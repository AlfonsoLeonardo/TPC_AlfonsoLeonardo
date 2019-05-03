namespace Principal
{
    partial class frmPrincipal
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
            this.btnAbm = new System.Windows.Forms.Button();
            this.btnTomaDePedido = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbm
            // 
            this.btnAbm.Location = new System.Drawing.Point(142, 94);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(127, 87);
            this.btnAbm.TabIndex = 1;
            this.btnAbm.Text = "ABM";
            this.btnAbm.UseVisualStyleBackColor = true;
            this.btnAbm.Click += new System.EventHandler(this.btnAbm_Click);
            // 
            // btnTomaDePedido
            // 
            this.btnTomaDePedido.Location = new System.Drawing.Point(312, 94);
            this.btnTomaDePedido.Name = "btnTomaDePedido";
            this.btnTomaDePedido.Size = new System.Drawing.Size(120, 86);
            this.btnTomaDePedido.TabIndex = 2;
            this.btnTomaDePedido.Text = "Toma De Pedidos";
            this.btnTomaDePedido.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(478, 94);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(129, 86);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnTomaDePedido);
            this.Controls.Add(this.btnAbm);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbm;
        private System.Windows.Forms.Button btnTomaDePedido;
        private System.Windows.Forms.Button btnReporte;
    }
}

