namespace Principal
{
    partial class frmABMmenu
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
            this.btnAltaingrediente = new System.Windows.Forms.Button();
            this.btnAltacomida = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaingrediente
            // 
            this.btnAltaingrediente.Location = new System.Drawing.Point(25, 94);
            this.btnAltaingrediente.Name = "btnAltaingrediente";
            this.btnAltaingrediente.Size = new System.Drawing.Size(236, 80);
            this.btnAltaingrediente.TabIndex = 0;
            this.btnAltaingrediente.Text = "Alta de Ingredientes";
            this.btnAltaingrediente.UseVisualStyleBackColor = true;
            this.btnAltaingrediente.Click += new System.EventHandler(this.btnAltaingrediente_Click);
            // 
            // btnAltacomida
            // 
            this.btnAltacomida.Location = new System.Drawing.Point(284, 94);
            this.btnAltacomida.Name = "btnAltacomida";
            this.btnAltacomida.Size = new System.Drawing.Size(236, 80);
            this.btnAltacomida.TabIndex = 1;
            this.btnAltacomida.Text = "Alta de comidas";
            this.btnAltacomida.UseVisualStyleBackColor = true;
            this.btnAltacomida.Click += new System.EventHandler(this.btnAltacomida_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(539, 94);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(236, 80);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // frmABMmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAltacomida);
            this.Controls.Add(this.btnAltaingrediente);
            this.Name = "frmABMmenu";
            this.Text = "frmABMmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaingrediente;
        private System.Windows.Forms.Button btnAltacomida;
        private System.Windows.Forms.Button btnUsuario;
    }
}