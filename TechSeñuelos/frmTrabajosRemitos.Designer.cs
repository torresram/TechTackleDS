namespace TechSeñuelos
{
    partial class frmTrabajosRemitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajosRemitos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboDestinoRem = new System.Windows.Forms.ComboBox();
            this.btnAddDest = new System.Windows.Forms.Button();
            this.lblDestRem = new System.Windows.Forms.Label();
            this.lblDestinoRem = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNroRem = new System.Windows.Forms.Label();
            this.lblNumeroRemito = new System.Windows.Forms.Label();
            this.dgvRemito = new System.Windows.Forms.DataGridView();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.gbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(477, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 53);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboDestinoRem
            // 
            this.cboDestinoRem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDestinoRem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestinoRem.FormattingEnabled = true;
            this.cboDestinoRem.Location = new System.Drawing.Point(83, 59);
            this.cboDestinoRem.Name = "cboDestinoRem";
            this.cboDestinoRem.Size = new System.Drawing.Size(144, 24);
            this.cboDestinoRem.TabIndex = 10;
            // 
            // btnAddDest
            // 
            this.btnAddDest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDest.Location = new System.Drawing.Point(233, 59);
            this.btnAddDest.Name = "btnAddDest";
            this.btnAddDest.Size = new System.Drawing.Size(129, 24);
            this.btnAddDest.TabIndex = 14;
            this.btnAddDest.Text = " Seleccionar";
            this.btnAddDest.UseVisualStyleBackColor = false;
            this.btnAddDest.Click += new System.EventHandler(this.btnAddDest_Click);
            // 
            // lblDestRem
            // 
            this.lblDestRem.AutoSize = true;
            this.lblDestRem.Location = new System.Drawing.Point(368, 63);
            this.lblDestRem.Name = "lblDestRem";
            this.lblDestRem.Size = new System.Drawing.Size(0, 13);
            this.lblDestRem.TabIndex = 12;
            // 
            // lblDestinoRem
            // 
            this.lblDestinoRem.AutoSize = true;
            this.lblDestinoRem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoRem.Location = new System.Drawing.Point(9, 63);
            this.lblDestinoRem.Name = "lblDestinoRem";
            this.lblDestinoRem.Size = new System.Drawing.Size(68, 17);
            this.lblDestinoRem.TabIndex = 19;
            this.lblDestinoRem.Text = "DESTINO :";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.White;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(477, 253);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(105, 53);
            this.btnContinuar.TabIndex = 18;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.White;
            this.btnEliminarTodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.Location = new System.Drawing.Point(477, 173);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(105, 37);
            this.btnEliminarTodo.TabIndex = 17;
            this.btnEliminarTodo.Text = "&Reutilizar";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(477, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 37);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(477, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 34);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNroRem
            // 
            this.lblNroRem.AutoSize = true;
            this.lblNroRem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRem.Location = new System.Drawing.Point(387, 17);
            this.lblNroRem.Name = "lblNroRem";
            this.lblNroRem.Size = new System.Drawing.Size(11, 17);
            this.lblNroRem.TabIndex = 13;
            this.lblNroRem.Text = " ";
            this.lblNroRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroRemito
            // 
            this.lblNumeroRemito.AutoSize = true;
            this.lblNumeroRemito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRemito.Location = new System.Drawing.Point(9, 17);
            this.lblNumeroRemito.Name = "lblNumeroRemito";
            this.lblNumeroRemito.Size = new System.Drawing.Size(80, 17);
            this.lblNumeroRemito.TabIndex = 11;
            this.lblNumeroRemito.Text = "REMITO N° :";
            // 
            // dgvRemito
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRemito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvRemito.Location = new System.Drawing.Point(12, 90);
            this.dgvRemito.MultiSelect = false;
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemito.Size = new System.Drawing.Size(434, 328);
            this.dgvRemito.TabIndex = 9;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.btnAceptar);
            this.gbAgregar.Controls.Add(this.btnTerminar);
            this.gbAgregar.Controls.Add(this.txtCantidad);
            this.gbAgregar.Controls.Add(this.cboModelo);
            this.gbAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregar.Location = new System.Drawing.Point(602, 86);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(245, 133);
            this.gbAgregar.TabIndex = 21;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(156, 49);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Ace&ptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.White;
            this.btnTerminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(70, 88);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(105, 34);
            this.btnTerminar.TabIndex = 22;
            this.btnTerminar.Text = "&Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(6, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 22);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.Text = "Cantidad...";
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // cboModelo
            // 
            this.cboModelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(6, 19);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(232, 25);
            this.cboModelo.TabIndex = 22;
            this.cboModelo.Text = "Modelo...";
            // 
            // frmTrabajosRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 442);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboDestinoRem);
            this.Controls.Add(this.btnAddDest);
            this.Controls.Add(this.lblDestRem);
            this.Controls.Add(this.lblDestinoRem);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNroRem);
            this.Controls.Add(this.lblNumeroRemito);
            this.Controls.Add(this.dgvRemito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrabajosRemitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRABAJOS";
            this.Load += new System.EventHandler(this.frmTrabajosRemitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).EndInit();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboDestinoRem;
        private System.Windows.Forms.Button btnAddDest;
        private System.Windows.Forms.Label lblDestRem;
        private System.Windows.Forms.Label lblDestinoRem;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNroRem;
        private System.Windows.Forms.Label lblNumeroRemito;
        private System.Windows.Forms.DataGridView dgvRemito;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAceptar;
    }
}