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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnRemitir = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnListaRemitos = new System.Windows.Forms.Button();
            this.btnSetStandar = new System.Windows.Forms.Button();
            this.btnArtificiales = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemitir
            // 
            this.btnRemitir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(234, 30);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(129, 45);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "INSUMOS";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnListaRemitos
            // 
            this.btnListaRemitos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaRemitos.Location = new System.Drawing.Point(33, 101);
            this.btnListaRemitos.Name = "btnListaRemitos";
            this.btnListaRemitos.Size = new System.Drawing.Size(131, 50);
            this.btnListaRemitos.TabIndex = 2;
            this.btnListaRemitos.Text = "REMITOS";
            this.btnListaRemitos.UseVisualStyleBackColor = true;
            this.btnListaRemitos.Click += new System.EventHandler(this.btnListaRemitos_Click);
            // 
            // btnSetStandar
            // 
            this.btnSetStandar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetStandar.Location = new System.Drawing.Point(234, 101);
            this.btnSetStandar.Name = "btnSetStandar";
            this.btnSetStandar.Size = new System.Drawing.Size(129, 50);
            this.btnSetStandar.TabIndex = 3;
            this.btnSetStandar.Text = "PREDEFINIDOS";
            this.btnSetStandar.UseVisualStyleBackColor = true;
            this.btnSetStandar.Click += new System.EventHandler(this.btnSetStandar_Click);
            // 
            // btnArtificiales
            // 
            this.btnArtificiales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtificiales.Location = new System.Drawing.Point(35, 180);
            this.btnArtificiales.Name = "btnArtificiales";
            this.btnArtificiales.Size = new System.Drawing.Size(129, 50);
            this.btnArtificiales.TabIndex = 4;
            this.btnArtificiales.Text = "ARTIFICIALES";
            this.btnArtificiales.UseVisualStyleBackColor = true;
            this.btnArtificiales.Click += new System.EventHandler(this.btnArtificiales_Click);
            // 
            // btnColores
            // 
            this.btnColores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.Location = new System.Drawing.Point(234, 180);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(129, 50);
            this.btnColores.TabIndex = 5;
            this.btnColores.Text = "COLORES";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 478);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnArtificiales);
            this.Controls.Add(this.btnSetStandar);
            this.Controls.Add(this.btnListaRemitos);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnRemitir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECH TACKLE Señuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemitir;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnListaRemitos;
        private System.Windows.Forms.Button btnSetStandar;
        private System.Windows.Forms.Button btnArtificiales;
        private System.Windows.Forms.Button btnColores;
    }
}

