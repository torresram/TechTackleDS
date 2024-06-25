namespace TechSeñuelos
{
    partial class frmInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumos));
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.lblCantTotal = new System.Windows.Forms.Label();
            this.tabPreparado = new System.Windows.Forms.TabControl();
            this.tabRemito = new System.Windows.Forms.TabPage();
            this.dgvRemito = new System.Windows.Forms.DataGridView();
            this.tabInsumos = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.tabPreparado.SuspendLayout();
            this.tabRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.tabInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInsumos.Location = new System.Drawing.Point(3, 3);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(397, 589);
            this.dgvInsumos.TabIndex = 0;
            // 
            // lblCantTotal
            // 
            this.lblCantTotal.AutoSize = true;
            this.lblCantTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotal.Location = new System.Drawing.Point(475, 272);
            this.lblCantTotal.Name = "lblCantTotal";
            this.lblCantTotal.Size = new System.Drawing.Size(55, 19);
            this.lblCantTotal.TabIndex = 1;
            this.lblCantTotal.Text = "TOTAL";
            // 
            // tabPreparado
            // 
            this.tabPreparado.Controls.Add(this.tabRemito);
            this.tabPreparado.Controls.Add(this.tabInsumos);
            this.tabPreparado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPreparado.Location = new System.Drawing.Point(12, 12);
            this.tabPreparado.Name = "tabPreparado";
            this.tabPreparado.SelectedIndex = 0;
            this.tabPreparado.Size = new System.Drawing.Size(409, 618);
            this.tabPreparado.TabIndex = 2;
            // 
            // tabRemito
            // 
            this.tabRemito.Controls.Add(this.dgvRemito);
            this.tabRemito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRemito.Location = new System.Drawing.Point(4, 25);
            this.tabRemito.Name = "tabRemito";
            this.tabRemito.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemito.Size = new System.Drawing.Size(401, 589);
            this.tabRemito.TabIndex = 1;
            this.tabRemito.Text = "Remito";
            this.tabRemito.UseVisualStyleBackColor = true;
            // 
            // dgvRemito
            // 
            this.dgvRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemito.Location = new System.Drawing.Point(0, 3);
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.ReadOnly = true;
            this.dgvRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemito.Size = new System.Drawing.Size(404, 592);
            this.dgvRemito.TabIndex = 0;
            // 
            // tabInsumos
            // 
            this.tabInsumos.Controls.Add(this.dgvInsumos);
            this.tabInsumos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInsumos.Location = new System.Drawing.Point(4, 25);
            this.tabInsumos.Name = "tabInsumos";
            this.tabInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsumos.Size = new System.Drawing.Size(401, 589);
            this.tabInsumos.TabIndex = 0;
            this.tabInsumos.Text = "Insumos";
            this.tabInsumos.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(466, 34);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 46);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(466, 583);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 46);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 645);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tabPreparado);
            this.Controls.Add(this.lblCantTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.frmInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.tabPreparado.ResumeLayout(false);
            this.tabRemito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).EndInit();
            this.tabInsumos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label lblCantTotal;
        private System.Windows.Forms.TabControl tabPreparado;
        private System.Windows.Forms.TabPage tabInsumos;
        private System.Windows.Forms.TabPage tabRemito;
        private System.Windows.Forms.DataGridView dgvRemito;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
    }
}