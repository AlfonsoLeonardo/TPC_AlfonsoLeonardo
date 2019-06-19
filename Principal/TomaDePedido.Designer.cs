namespace Principal
{
    partial class TomaDePedido
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
            this.dgvempanadas = new System.Windows.Forms.DataGridView();
            this.dgvespeciales = new System.Windows.Forms.DataGridView();
            this.dgvsuperEspecial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempanadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespeciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuperEspecial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempanadas
            // 
            this.dgvempanadas.AllowUserToAddRows = false;
            this.dgvempanadas.AllowUserToDeleteRows = false;
            this.dgvempanadas.AllowUserToResizeColumns = false;
            this.dgvempanadas.AllowUserToResizeRows = false;
            this.dgvempanadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvempanadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvempanadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvempanadas.Location = new System.Drawing.Point(539, 40);
            this.dgvempanadas.Name = "dgvempanadas";
            this.dgvempanadas.ReadOnly = true;
            this.dgvempanadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvempanadas.Size = new System.Drawing.Size(412, 373);
            this.dgvempanadas.TabIndex = 0;
            this.dgvempanadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempanadas_CellClick);
            this.dgvempanadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempanadas_CellContentClick);
            this.dgvempanadas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvempanadas_CellPainting);
            this.dgvempanadas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvempanadas_CurrentCellDirtyStateChanged);
            // 
            // dgvespeciales
            // 
            this.dgvespeciales.AllowUserToAddRows = false;
            this.dgvespeciales.AllowUserToDeleteRows = false;
            this.dgvespeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvespeciales.Location = new System.Drawing.Point(12, 40);
            this.dgvespeciales.Name = "dgvespeciales";
            this.dgvespeciales.ReadOnly = true;
            this.dgvespeciales.Size = new System.Drawing.Size(240, 217);
            this.dgvespeciales.TabIndex = 1;
            // 
            // dgvsuperEspecial
            // 
            this.dgvsuperEspecial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsuperEspecial.Location = new System.Drawing.Point(280, 141);
            this.dgvsuperEspecial.Name = "dgvsuperEspecial";
            this.dgvsuperEspecial.Size = new System.Drawing.Size(240, 150);
            this.dgvsuperEspecial.TabIndex = 2;
            // 
            // TomaDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.dgvsuperEspecial);
            this.Controls.Add(this.dgvespeciales);
            this.Controls.Add(this.dgvempanadas);
            this.Name = "TomaDePedido";
            this.Text = "TomaDePedido";
            this.Load += new System.EventHandler(this.TomaDePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempanadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespeciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuperEspecial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempanadas;
        private System.Windows.Forms.DataGridView dgvespeciales;
        private System.Windows.Forms.DataGridView dgvsuperEspecial;
    }
}