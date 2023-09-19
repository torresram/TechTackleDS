namespace TechSeñuelos
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
            this.btnRemitir = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnListaRemitos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemitir
            // 
            this.btnRemitir.Location = new System.Drawing.Point(35, 30);
            this.btnRemitir.Name = "btnRemitir";
            this.btnRemitir.Size = new System.Drawing.Size(129, 45);
            this.btnRemitir.TabIndex = 0;
            this.btnRemitir.Text = "REMITO NUEVO";
            this.btnRemitir.UseVisualStyleBackColor = true;
            this.btnRemitir.Click += new System.EventHandler(this.btnRemitir_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(234, 30);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(95, 45);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "INSUMOS";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnListaRemitos
            // 
            this.btnListaRemitos.Location = new System.Drawing.Point(33, 101);
            this.btnListaRemitos.Name = "btnListaRemitos";
            this.btnListaRemitos.Size = new System.Drawing.Size(131, 50);
            this.btnListaRemitos.TabIndex = 2;
            this.btnListaRemitos.Text = "REMITOS";
            this.btnListaRemitos.UseVisualStyleBackColor = true;
            this.btnListaRemitos.Click += new System.EventHandler(this.btnListaRemitos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 468);
            this.Controls.Add(this.btnListaRemitos);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnRemitir);
            this.Name = "frmPrincipal";
            this.Text = "TECH TACKLE Señuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemitir;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnListaRemitos;
    }
}

