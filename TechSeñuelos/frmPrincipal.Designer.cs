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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnArtificiales = new System.Windows.Forms.Button();
            this.btnSetStandar = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRemitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeRemitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnListaRemitos = new System.Windows.Forms.Button();
            this.msMainMenu.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(148, 11);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(131, 50);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "INSUMOS";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnColores
            // 
            this.btnColores.BackColor = System.Drawing.Color.White;
            this.btnColores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.Location = new System.Drawing.Point(285, 11);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(131, 50);
            this.btnColores.TabIndex = 3;
            this.btnColores.Text = "COLORES";
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnArtificiales
            // 
            this.btnArtificiales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtificiales.Location = new System.Drawing.Point(422, 11);
            this.btnArtificiales.Name = "btnArtificiales";
            this.btnArtificiales.Size = new System.Drawing.Size(131, 50);
            this.btnArtificiales.TabIndex = 4;
            this.btnArtificiales.Text = "ARTIFICIALES";
            this.btnArtificiales.UseVisualStyleBackColor = true;
            this.btnArtificiales.Click += new System.EventHandler(this.btnArtificiales_Click);
            // 
            // btnSetStandar
            // 
            this.btnSetStandar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetStandar.Location = new System.Drawing.Point(559, 11);
            this.btnSetStandar.Name = "btnSetStandar";
            this.btnSetStandar.Size = new System.Drawing.Size(131, 50);
            this.btnSetStandar.TabIndex = 5;
            this.btnSetStandar.Text = "PREDEFINIDOS";
            this.btnSetStandar.UseVisualStyleBackColor = true;
            this.btnSetStandar.Click += new System.EventHandler(this.btnSetStandar_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.insertarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(1284, 24);
            this.msMainMenu.TabIndex = 6;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRemitoToolStripMenuItem,
            this.listaDeRemitosToolStripMenuItem,
            this.toolStripSeparator1,
            this.tlmiSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoRemitoToolStripMenuItem
            // 
            this.nuevoRemitoToolStripMenuItem.Name = "nuevoRemitoToolStripMenuItem";
            this.nuevoRemitoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoRemitoToolStripMenuItem.Text = "&Nuevo remito";
            // 
            // listaDeRemitosToolStripMenuItem
            // 
            this.listaDeRemitosToolStripMenuItem.Name = "listaDeRemitosToolStripMenuItem";
            this.listaDeRemitosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeRemitosToolStripMenuItem.Text = "&Lista de remitos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // tlmiSalir
            // 
            this.tlmiSalir.Name = "tlmiSalir";
            this.tlmiSalir.Size = new System.Drawing.Size(157, 22);
            this.tlmiSalir.Text = "&Salir";
            this.tlmiSalir.Click += new System.EventHandler(this.tlmiSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "&Edición";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insertarToolStripMenuItem.Text = "&Insertar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Ve&ntana";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // pMain
            // 
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.btnColores);
            this.pMain.Controls.Add(this.btnListaRemitos);
            this.pMain.Controls.Add(this.btnStock);
            this.pMain.Controls.Add(this.btnSetStandar);
            this.pMain.Controls.Add(this.btnArtificiales);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMain.Location = new System.Drawing.Point(0, 24);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1284, 74);
            this.pMain.TabIndex = 1;
            // 
            // btnListaRemitos
            // 
            this.btnListaRemitos.BackColor = System.Drawing.Color.White;
            this.btnListaRemitos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaRemitos.Location = new System.Drawing.Point(11, 11);
            this.btnListaRemitos.Name = "btnListaRemitos";
            this.btnListaRemitos.Size = new System.Drawing.Size(131, 50);
            this.btnListaRemitos.TabIndex = 0;
            this.btnListaRemitos.Text = "REMITOS";
            this.btnListaRemitos.UseVisualStyleBackColor = false;
            this.btnListaRemitos.Click += new System.EventHandler(this.btnListaRemitos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TechSeñuelos.Properties.Resources.techLogo1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECH TACKLE DIVISION SEÑUELOS ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnArtificiales;
        private System.Windows.Forms.Button btnSetStandar;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRemitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeRemitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnListaRemitos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tlmiSalir;
    }
}

