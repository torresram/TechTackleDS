namespace TechSeñuelos
{
    partial class frmStockInsumos
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
            this.tbInsumos = new System.Windows.Forms.TabControl();
            this.tbAnillas = new System.Windows.Forms.TabPage();
            this.tbAnzuelo = new System.Windows.Forms.TabPage();
            this.tbBlisters = new System.Windows.Forms.TabPage();
            this.tbCarton = new System.Windows.Forms.TabPage();
            this.tbCarcasa = new System.Windows.Forms.TabPage();
            this.tbPitones = new System.Windows.Forms.TabPage();
            this.dgvPitones = new System.Windows.Forms.DataGridView();
            this.dgvAnillas = new System.Windows.Forms.DataGridView();
            this.dgvAnzuelos = new System.Windows.Forms.DataGridView();
            this.dgvBlister = new System.Windows.Forms.DataGridView();
            this.dgvCarcasas = new System.Windows.Forms.DataGridView();
            this.dgvCarton = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tbInsumos.SuspendLayout();
            this.tbAnillas.SuspendLayout();
            this.tbAnzuelo.SuspendLayout();
            this.tbBlisters.SuspendLayout();
            this.tbCarton.SuspendLayout();
            this.tbCarcasa.SuspendLayout();
            this.tbPitones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarcasas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInsumos
            // 
            this.tbInsumos.Controls.Add(this.tbAnillas);
            this.tbInsumos.Controls.Add(this.tbAnzuelo);
            this.tbInsumos.Controls.Add(this.tbBlisters);
            this.tbInsumos.Controls.Add(this.tbCarcasa);
            this.tbInsumos.Controls.Add(this.tbCarton);
            this.tbInsumos.Controls.Add(this.tbPitones);
            this.tbInsumos.Location = new System.Drawing.Point(0, 114);
            this.tbInsumos.Name = "tbInsumos";
            this.tbInsumos.SelectedIndex = 0;
            this.tbInsumos.Size = new System.Drawing.Size(635, 454);
            this.tbInsumos.TabIndex = 0;
            this.tbInsumos.SelectedIndexChanged += new System.EventHandler(this.tbInsumos_SelectedIndexChanged);
            // 
            // tbAnillas
            // 
            this.tbAnillas.Controls.Add(this.dgvAnillas);
            this.tbAnillas.Location = new System.Drawing.Point(4, 22);
            this.tbAnillas.Name = "tbAnillas";
            this.tbAnillas.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnillas.Size = new System.Drawing.Size(627, 428);
            this.tbAnillas.TabIndex = 0;
            this.tbAnillas.Text = "Anillas";
            this.tbAnillas.UseVisualStyleBackColor = true;
            // 
            // tbAnzuelo
            // 
            this.tbAnzuelo.Controls.Add(this.dgvAnzuelos);
            this.tbAnzuelo.Location = new System.Drawing.Point(4, 22);
            this.tbAnzuelo.Name = "tbAnzuelo";
            this.tbAnzuelo.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnzuelo.Size = new System.Drawing.Size(627, 428);
            this.tbAnzuelo.TabIndex = 1;
            this.tbAnzuelo.Text = "Anzuelos";
            this.tbAnzuelo.UseVisualStyleBackColor = true;
            // 
            // tbBlisters
            // 
            this.tbBlisters.Controls.Add(this.dgvBlister);
            this.tbBlisters.Location = new System.Drawing.Point(4, 22);
            this.tbBlisters.Name = "tbBlisters";
            this.tbBlisters.Size = new System.Drawing.Size(627, 428);
            this.tbBlisters.TabIndex = 2;
            this.tbBlisters.Text = "Blisters";
            this.tbBlisters.UseVisualStyleBackColor = true;
            // 
            // tbCarton
            // 
            this.tbCarton.Controls.Add(this.dgvCarton);
            this.tbCarton.Location = new System.Drawing.Point(4, 22);
            this.tbCarton.Name = "tbCarton";
            this.tbCarton.Size = new System.Drawing.Size(627, 428);
            this.tbCarton.TabIndex = 3;
            this.tbCarton.Text = "Cartones";
            this.tbCarton.UseVisualStyleBackColor = true;
            // 
            // tbCarcasa
            // 
            this.tbCarcasa.Controls.Add(this.dgvCarcasas);
            this.tbCarcasa.Location = new System.Drawing.Point(4, 22);
            this.tbCarcasa.Name = "tbCarcasa";
            this.tbCarcasa.Size = new System.Drawing.Size(627, 428);
            this.tbCarcasa.TabIndex = 4;
            this.tbCarcasa.Text = "Carcasas";
            this.tbCarcasa.UseVisualStyleBackColor = true;
            // 
            // tbPitones
            // 
            this.tbPitones.Controls.Add(this.dgvPitones);
            this.tbPitones.Location = new System.Drawing.Point(4, 22);
            this.tbPitones.Name = "tbPitones";
            this.tbPitones.Size = new System.Drawing.Size(627, 428);
            this.tbPitones.TabIndex = 5;
            this.tbPitones.Text = "Pitones";
            this.tbPitones.UseVisualStyleBackColor = true;
            // 
            // dgvPitones
            // 
            this.dgvPitones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPitones.Location = new System.Drawing.Point(0, 0);
            this.dgvPitones.Name = "dgvPitones";
            this.dgvPitones.Size = new System.Drawing.Size(630, 431);
            this.dgvPitones.TabIndex = 0;
            // 
            // dgvAnillas
            // 
            this.dgvAnillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnillas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnillas.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnillas.Name = "dgvAnillas";
            this.dgvAnillas.Size = new System.Drawing.Size(630, 431);
            this.dgvAnillas.TabIndex = 1;
            // 
            // dgvAnzuelos
            // 
            this.dgvAnzuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzuelos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnzuelos.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnzuelos.Name = "dgvAnzuelos";
            this.dgvAnzuelos.Size = new System.Drawing.Size(630, 431);
            this.dgvAnzuelos.TabIndex = 1;
            // 
            // dgvBlister
            // 
            this.dgvBlister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBlister.Location = new System.Drawing.Point(-2, -1);
            this.dgvBlister.Name = "dgvBlister";
            this.dgvBlister.Size = new System.Drawing.Size(630, 431);
            this.dgvBlister.TabIndex = 1;
            // 
            // dgvCarcasas
            // 
            this.dgvCarcasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarcasas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarcasas.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarcasas.Name = "dgvCarcasas";
            this.dgvCarcasas.Size = new System.Drawing.Size(630, 431);
            this.dgvCarcasas.TabIndex = 1;
            // 
            // dgvCarton
            // 
            this.dgvCarton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarton.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarton.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarton.Name = "dgvCarton";
            this.dgvCarton.Size = new System.Drawing.Size(630, 431);
            this.dgvCarton.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(1, 73);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(68, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(75, 72);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(181, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // frmStockInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 627);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbInsumos);
            this.Name = "frmStockInsumos";
            this.Text = "STOCK INSUMOS";
            this.Load += new System.EventHandler(this.frmStockInsumos_Load);
            this.tbInsumos.ResumeLayout(false);
            this.tbAnillas.ResumeLayout(false);
            this.tbAnzuelo.ResumeLayout(false);
            this.tbBlisters.ResumeLayout(false);
            this.tbCarton.ResumeLayout(false);
            this.tbCarcasa.ResumeLayout(false);
            this.tbPitones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarcasas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbInsumos;
        private System.Windows.Forms.TabPage tbAnillas;
        private System.Windows.Forms.TabPage tbAnzuelo;
        private System.Windows.Forms.TabPage tbBlisters;
        private System.Windows.Forms.TabPage tbCarcasa;
        private System.Windows.Forms.TabPage tbCarton;
        private System.Windows.Forms.TabPage tbPitones;
        private System.Windows.Forms.DataGridView dgvAnillas;
        private System.Windows.Forms.DataGridView dgvAnzuelos;
        private System.Windows.Forms.DataGridView dgvBlister;
        private System.Windows.Forms.DataGridView dgvCarcasas;
        private System.Windows.Forms.DataGridView dgvCarton;
        private System.Windows.Forms.DataGridView dgvPitones;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}