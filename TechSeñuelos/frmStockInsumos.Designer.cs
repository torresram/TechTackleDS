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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInsumos));
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
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.tbInsumos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbAnillas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnillas.Location = new System.Drawing.Point(4, 25);
            this.tbAnillas.Name = "tbAnillas";
            this.tbAnillas.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnillas.Size = new System.Drawing.Size(627, 425);
            this.tbAnillas.TabIndex = 0;
            this.tbAnillas.Text = "Anillas";
            this.tbAnillas.UseVisualStyleBackColor = true;
            // 
            // dgvAnillas
            // 
            this.dgvAnillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAnillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnillas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnillas.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnillas.Name = "dgvAnillas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnillas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnillas.Size = new System.Drawing.Size(630, 431);
            this.dgvAnillas.TabIndex = 1;
            // 
            // tbAnzuelo
            // 
            this.tbAnzuelo.Controls.Add(this.dgvAnzuelos);
            this.tbAnzuelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnzuelo.Location = new System.Drawing.Point(4, 25);
            this.tbAnzuelo.Name = "tbAnzuelo";
            this.tbAnzuelo.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnzuelo.Size = new System.Drawing.Size(627, 425);
            this.tbAnzuelo.TabIndex = 1;
            this.tbAnzuelo.Text = "Anzuelos";
            this.tbAnzuelo.UseVisualStyleBackColor = true;
            // 
            // dgvAnzuelos
            // 
            this.dgvAnzuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAnzuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzuelos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnzuelos.Location = new System.Drawing.Point(-2, -1);
            this.dgvAnzuelos.Name = "dgvAnzuelos";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnzuelos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnzuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnzuelos.Size = new System.Drawing.Size(630, 431);
            this.dgvAnzuelos.TabIndex = 1;
            // 
            // tbBlisters
            // 
            this.tbBlisters.Controls.Add(this.dgvBlister);
            this.tbBlisters.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlisters.Location = new System.Drawing.Point(4, 25);
            this.tbBlisters.Name = "tbBlisters";
            this.tbBlisters.Size = new System.Drawing.Size(627, 425);
            this.tbBlisters.TabIndex = 2;
            this.tbBlisters.Text = "Blisters";
            this.tbBlisters.UseVisualStyleBackColor = true;
            // 
            // dgvBlister
            // 
            this.dgvBlister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBlister.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvBlister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBlister.Location = new System.Drawing.Point(-2, -1);
            this.dgvBlister.Name = "dgvBlister";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBlister.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBlister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlister.Size = new System.Drawing.Size(630, 431);
            this.dgvBlister.TabIndex = 1;
            // 
            // tbCarcasa
            // 
            this.tbCarcasa.Controls.Add(this.dgvCarcasas);
            this.tbCarcasa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarcasa.Location = new System.Drawing.Point(4, 25);
            this.tbCarcasa.Name = "tbCarcasa";
            this.tbCarcasa.Size = new System.Drawing.Size(627, 425);
            this.tbCarcasa.TabIndex = 4;
            this.tbCarcasa.Text = "Carcasas";
            this.tbCarcasa.UseVisualStyleBackColor = true;
            // 
            // dgvCarcasas
            // 
            this.dgvCarcasas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCarcasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarcasas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarcasas.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarcasas.Name = "dgvCarcasas";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarcasas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarcasas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarcasas.Size = new System.Drawing.Size(630, 431);
            this.dgvCarcasas.TabIndex = 1;
            // 
            // tbCarton
            // 
            this.tbCarton.Controls.Add(this.dgvCarton);
            this.tbCarton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarton.Location = new System.Drawing.Point(4, 25);
            this.tbCarton.Name = "tbCarton";
            this.tbCarton.Size = new System.Drawing.Size(627, 425);
            this.tbCarton.TabIndex = 3;
            this.tbCarton.Text = "Cartones";
            this.tbCarton.UseVisualStyleBackColor = true;
            // 
            // dgvCarton
            // 
            this.dgvCarton.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCarton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarton.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarton.Location = new System.Drawing.Point(-2, -1);
            this.dgvCarton.Name = "dgvCarton";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarton.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarton.Size = new System.Drawing.Size(630, 431);
            this.dgvCarton.TabIndex = 1;
            // 
            // tbPitones
            // 
            this.tbPitones.Controls.Add(this.dgvPitones);
            this.tbPitones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPitones.Location = new System.Drawing.Point(4, 25);
            this.tbPitones.Name = "tbPitones";
            this.tbPitones.Size = new System.Drawing.Size(627, 425);
            this.tbPitones.TabIndex = 5;
            this.tbPitones.Text = "Pitones";
            this.tbPitones.UseVisualStyleBackColor = true;
            // 
            // dgvPitones
            // 
            this.dgvPitones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPitones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPitones.Location = new System.Drawing.Point(0, 0);
            this.dgvPitones.Name = "dgvPitones";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPitones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPitones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPitones.Size = new System.Drawing.Size(630, 431);
            this.dgvPitones.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 73);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 20);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(90, 71);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(181, 22);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(641, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 56);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(641, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 56);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(641, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 56);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(641, 508);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 56);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmStockInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(762, 573);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STOCK INSUMOS";
            this.Load += new System.EventHandler(this.frmStockInsumos_Load);
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
        private System.Windows.Forms.Button btnSalir;
    }
}