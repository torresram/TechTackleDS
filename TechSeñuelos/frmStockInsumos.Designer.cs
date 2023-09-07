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
            this.dgvAnillas = new System.Windows.Forms.DataGridView();
            this.tbAnzuelo = new System.Windows.Forms.TabPage();
            this.dgvAnzuelos = new System.Windows.Forms.DataGridView();
            this.tbBlisters = new System.Windows.Forms.TabPage();
            this.dgvBlister = new System.Windows.Forms.DataGridView();
            this.tbCarcasa = new System.Windows.Forms.TabPage();
            this.dgvCarcasas = new System.Windows.Forms.DataGridView();
            this.tbCarton = new System.Windows.Forms.TabPage();
            this.dgvCarton = new System.Windows.Forms.DataGridView();
            this.tbPitones = new System.Windows.Forms.TabPage();
            this.dgvPitones = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbInsumos.SuspendLayout();
            this.tbAnillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnillas)).BeginInit();
            this.tbAnzuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzuelos)).BeginInit();
            this.tbBlisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlister)).BeginInit();
            this.tbCarcasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarcasas)).BeginInit();
            this.tbCarton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).BeginInit();
            this.tbPitones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitones)).BeginInit();
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
            // dgvAnillas
            // 
            this.dgvAnillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnillas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnillas.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnillas.Name = "dgvAnillas";
            this.dgvAnillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnillas.Size = new System.Drawing.Size(630, 431);
            this.dgvAnillas.TabIndex = 1;
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
            // dgvAnzuelos
            // 
            this.dgvAnzuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzuelos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnzuelos.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnzuelos.Name = "dgvAnzuelos";
            this.dgvAnzuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnzuelos.Size = new System.Drawing.Size(630, 431);
            this.dgvAnzuelos.TabIndex = 1;
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
            // dgvBlister
            // 
            this.dgvBlister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBlister.Location = new System.Drawing.Point(-2, -1);
            this.dgvBlister.Name = "dgvBlister";
            this.dgvBlister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlister.Size = new System.Drawing.Size(630, 431);
            this.dgvBlister.TabIndex = 1;
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
            // dgvCarcasas
            // 
            this.dgvCarcasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarcasas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarcasas.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarcasas.Name = "dgvCarcasas";
            this.dgvCarcasas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarcasas.Size = new System.Drawing.Size(630, 431);
            this.dgvCarcasas.TabIndex = 1;
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
            // dgvCarton
            // 
            this.dgvCarton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarton.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarton.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarton.Name = "dgvCarton";
            this.dgvCarton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarton.Size = new System.Drawing.Size(630, 431);
            this.dgvCarton.TabIndex = 1;
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
            this.dgvPitones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPitones.Size = new System.Drawing.Size(630, 431);
            this.dgvPitones.TabIndex = 0;
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
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(669, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 56);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(669, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 56);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(669, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 56);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmStockInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 620);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbInsumos);
            this.Name = "frmStockInsumos";
            this.Text = "STOCK INSUMOS";
            this.Load += new System.EventHandler(this.frmStockInsumos_Load);
            this.Enter += new System.EventHandler(this.frmStockInsumos_Enter);
            this.tbInsumos.ResumeLayout(false);
            this.tbAnillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnillas)).EndInit();
            this.tbAnzuelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzuelos)).EndInit();
            this.tbBlisters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlister)).EndInit();
            this.tbCarcasa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarcasas)).EndInit();
            this.tbCarton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).EndInit();
            this.tbPitones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitones)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}