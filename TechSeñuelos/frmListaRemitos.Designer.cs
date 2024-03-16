namespace TechSeñuelos
{
    partial class frmListaRemitos
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
            this.dgvListaRemitos = new System.Windows.Forms.DataGridView();
            this.dgvDetalleRemito = new System.Windows.Forms.DataGridView();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRemitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRemito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaRemitos
            // 
            this.dgvListaRemitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRemitos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaRemitos.Location = new System.Drawing.Point(18, 84);
            this.dgvListaRemitos.MultiSelect = false;
            this.dgvListaRemitos.Name = "dgvListaRemitos";
            this.dgvListaRemitos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaRemitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRemitos.Size = new System.Drawing.Size(397, 537);
            this.dgvListaRemitos.TabIndex = 0;
            this.dgvListaRemitos.SelectionChanged += new System.EventHandler(this.dgvListaRemitos_SelectionChanged);
            // 
            // dgvDetalleRemito
            // 
            this.dgvDetalleRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleRemito.Location = new System.Drawing.Point(457, 84);
            this.dgvDetalleRemito.MultiSelect = false;
            this.dgvDetalleRemito.Name = "dgvDetalleRemito";
            this.dgvDetalleRemito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetalleRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleRemito.Size = new System.Drawing.Size(428, 536);
            this.dgvDetalleRemito.TabIndex = 1;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(15, 35);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(73, 16);
            this.lblBuscador.TabIndex = 2;
            this.lblBuscador.Text = "BUSCAR:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(94, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(321, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(918, 84);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 53);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmListaRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 663);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.dgvDetalleRemito);
            this.Controls.Add(this.dgvListaRemitos);
            this.Name = "frmListaRemitos";
            this.Text = "LISTADO REMITOS";
            this.Load += new System.EventHandler(this.frmListaRemitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRemitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRemitos;
        private System.Windows.Forms.DataGridView dgvDetalleRemito;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnImprimir;
    }
}