﻿namespace Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAbm = new System.Windows.Forms.Button();
            this.btnTomaDePedido = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.SubMenuABM = new System.Windows.Forms.Panel();
            this.pnIngPrcomida = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIngPorComida = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnComid = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnIngre = new System.Windows.Forms.Button();
            this.lUsernombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnABM = new System.Windows.Forms.Panel();
            this.pntomadepedido = new System.Windows.Forms.Panel();
            this.pnReporte = new System.Windows.Forms.Panel();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.SubMenuABM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbm
            // 
            this.btnAbm.BackColor = System.Drawing.Color.Maroon;
            this.btnAbm.FlatAppearance.BorderSize = 0;
            this.btnAbm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAbm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbm.ForeColor = System.Drawing.Color.White;
            this.btnAbm.Image = ((System.Drawing.Image)(resources.GetObject("btnAbm.Image")));
            this.btnAbm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbm.Location = new System.Drawing.Point(0, 177);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(200, 38);
            this.btnAbm.TabIndex = 100;
            this.btnAbm.Text = "ABM";
            this.btnAbm.UseVisualStyleBackColor = false;
            this.btnAbm.Visible = false;
            this.btnAbm.Click += new System.EventHandler(this.btnAbm_Click);
            // 
            // btnTomaDePedido
            // 
            this.btnTomaDePedido.BackColor = System.Drawing.Color.Maroon;
            this.btnTomaDePedido.FlatAppearance.BorderSize = 0;
            this.btnTomaDePedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTomaDePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomaDePedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomaDePedido.ForeColor = System.Drawing.Color.White;
            this.btnTomaDePedido.Location = new System.Drawing.Point(0, 221);
            this.btnTomaDePedido.Name = "btnTomaDePedido";
            this.btnTomaDePedido.Size = new System.Drawing.Size(200, 38);
            this.btnTomaDePedido.TabIndex = 155;
            this.btnTomaDePedido.Text = "Toma De Pedidos";
            this.btnTomaDePedido.UseVisualStyleBackColor = false;
            this.btnTomaDePedido.Click += new System.EventHandler(this.btnTomaDePedido_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Maroon;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(0, 265);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 38);
            this.btnReporte.TabIndex = 150;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.pnBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.pnBarraTitulo.TabIndex = 6;
            this.pnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1232, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1263, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Maroon;
            this.panelmenu.Controls.Add(this.SubMenuABM);
            this.panelmenu.Controls.Add(this.lUsernombre);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Controls.Add(this.pnABM);
            this.panelmenu.Controls.Add(this.pntomadepedido);
            this.panelmenu.Controls.Add(this.pnReporte);
            this.panelmenu.Controls.Add(this.btnAbm);
            this.panelmenu.Controls.Add(this.btnReporte);
            this.panelmenu.Controls.Add(this.btnTomaDePedido);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 38);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(202, 612);
            this.panelmenu.TabIndex = 7;
            // 
            // SubMenuABM
            // 
            this.SubMenuABM.Controls.Add(this.pnIngPrcomida);
            this.SubMenuABM.Controls.Add(this.panel4);
            this.SubMenuABM.Controls.Add(this.btnIngPorComida);
            this.SubMenuABM.Controls.Add(this.panel6);
            this.SubMenuABM.Controls.Add(this.btnUser);
            this.SubMenuABM.Controls.Add(this.btnComid);
            this.SubMenuABM.Controls.Add(this.panel5);
            this.SubMenuABM.Controls.Add(this.btnIngre);
            this.SubMenuABM.Location = new System.Drawing.Point(28, 221);
            this.SubMenuABM.Name = "SubMenuABM";
            this.SubMenuABM.Size = new System.Drawing.Size(172, 145);
            this.SubMenuABM.TabIndex = 5;
            this.SubMenuABM.Visible = false;
            // 
            // pnIngPrcomida
            // 
            this.pnIngPrcomida.BackColor = System.Drawing.Color.Red;
            this.pnIngPrcomida.Location = new System.Drawing.Point(0, 107);
            this.pnIngPrcomida.Name = "pnIngPrcomida";
            this.pnIngPrcomida.Size = new System.Drawing.Size(10, 36);
            this.pnIngPrcomida.TabIndex = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(0, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 36);
            this.panel4.TabIndex = 6;
            // 
            // btnIngPorComida
            // 
            this.btnIngPorComida.BackColor = System.Drawing.Color.Maroon;
            this.btnIngPorComida.FlatAppearance.BorderSize = 0;
            this.btnIngPorComida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnIngPorComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngPorComida.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnIngPorComida.ForeColor = System.Drawing.Color.White;
            this.btnIngPorComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngPorComida.Location = new System.Drawing.Point(0, 107);
            this.btnIngPorComida.Name = "btnIngPorComida";
            this.btnIngPorComida.Size = new System.Drawing.Size(169, 36);
            this.btnIngPorComida.TabIndex = 105;
            this.btnIngPorComida.Text = "Ing. por Comida";
            this.btnIngPorComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngPorComida.UseVisualStyleBackColor = false;
            this.btnIngPorComida.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(0, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 36);
            this.panel6.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Maroon;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 74);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(169, 36);
            this.btnUser.TabIndex = 103;
            this.btnUser.Text = "Usuario";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnComid
            // 
            this.btnComid.BackColor = System.Drawing.Color.Maroon;
            this.btnComid.FlatAppearance.BorderSize = 0;
            this.btnComid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnComid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnComid.ForeColor = System.Drawing.Color.White;
            this.btnComid.Image = ((System.Drawing.Image)(resources.GetObject("btnComid.Image")));
            this.btnComid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComid.Location = new System.Drawing.Point(0, 38);
            this.btnComid.Name = "btnComid";
            this.btnComid.Size = new System.Drawing.Size(169, 36);
            this.btnComid.TabIndex = 102;
            this.btnComid.Text = "Comida";
            this.btnComid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComid.UseVisualStyleBackColor = false;
            this.btnComid.Click += new System.EventHandler(this.btnComid_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 36);
            this.panel5.TabIndex = 2;
            // 
            // btnIngre
            // 
            this.btnIngre.BackColor = System.Drawing.Color.Maroon;
            this.btnIngre.FlatAppearance.BorderSize = 0;
            this.btnIngre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnIngre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngre.ForeColor = System.Drawing.Color.White;
            this.btnIngre.Image = ((System.Drawing.Image)(resources.GetObject("btnIngre.Image")));
            this.btnIngre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngre.Location = new System.Drawing.Point(0, 3);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(169, 36);
            this.btnIngre.TabIndex = 101;
            this.btnIngre.Text = "Ingredientes";
            this.btnIngre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngre.UseVisualStyleBackColor = false;
            this.btnIngre.Click += new System.EventHandler(this.btnIngre_Click);
            // 
            // lUsernombre
            // 
            this.lUsernombre.AutoSize = true;
            this.lUsernombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lUsernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsernombre.ForeColor = System.Drawing.Color.White;
            this.lUsernombre.Location = new System.Drawing.Point(0, 596);
            this.lUsernombre.Name = "lUsernombre";
            this.lUsernombre.Size = new System.Drawing.Size(76, 16);
            this.lUsernombre.TabIndex = 0;
            this.lUsernombre.Text = "USUARIO";
            this.lUsernombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnABM
            // 
            this.pnABM.BackColor = System.Drawing.Color.Red;
            this.pnABM.Location = new System.Drawing.Point(0, 177);
            this.pnABM.Name = "pnABM";
            this.pnABM.Size = new System.Drawing.Size(10, 38);
            this.pnABM.TabIndex = 1;
            this.pnABM.Visible = false;
            // 
            // pntomadepedido
            // 
            this.pntomadepedido.BackColor = System.Drawing.Color.Red;
            this.pntomadepedido.Location = new System.Drawing.Point(0, 221);
            this.pntomadepedido.Name = "pntomadepedido";
            this.pntomadepedido.Size = new System.Drawing.Size(10, 38);
            this.pntomadepedido.TabIndex = 1;
            // 
            // pnReporte
            // 
            this.pnReporte.BackColor = System.Drawing.Color.Red;
            this.pnReporte.Location = new System.Drawing.Point(0, 265);
            this.pnReporte.Name = "pnReporte";
            this.pnReporte.Size = new System.Drawing.Size(10, 38);
            this.pnReporte.TabIndex = 0;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelcontenedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(202, 38);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1098, 612);
            this.panelcontenedor.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.pnBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.pnBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.SubMenuABM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbm;
        private System.Windows.Forms.Button btnTomaDePedido;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel pnReporte;
        private System.Windows.Forms.Panel pnABM;
        private System.Windows.Forms.Panel pntomadepedido;
        private System.Windows.Forms.Panel SubMenuABM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnComid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lUsernombre;
        private System.Windows.Forms.Panel pnIngPrcomida;
        private System.Windows.Forms.Button btnIngPorComida;
    }
}

