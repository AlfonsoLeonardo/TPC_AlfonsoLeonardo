namespace Principal
{
    partial class IngredientePorComida
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
            this.cboComida = new System.Windows.Forms.ComboBox();
            this.chkingrediente = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cboComida
            // 
            this.cboComida.FormattingEnabled = true;
            this.cboComida.Location = new System.Drawing.Point(210, 131);
            this.cboComida.Name = "cboComida";
            this.cboComida.Size = new System.Drawing.Size(121, 21);
            this.cboComida.TabIndex = 0;
            // 
            // chkingrediente
            // 
            this.chkingrediente.CheckOnClick = true;
            this.chkingrediente.FormattingEnabled = true;
            this.chkingrediente.Location = new System.Drawing.Point(211, 173);
            this.chkingrediente.Name = "chkingrediente";
            this.chkingrediente.Size = new System.Drawing.Size(120, 94);
            this.chkingrediente.TabIndex = 1;
            // 
            // IngredientePorComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1084, 613);
            this.Controls.Add(this.chkingrediente);
            this.Controls.Add(this.cboComida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientePorComida";
            this.Text = "IngredientePorComida";
            this.Load += new System.EventHandler(this.IngredientePorComida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboComida;
        private System.Windows.Forms.CheckedListBox chkingrediente;
    }
}