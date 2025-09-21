namespace TechSeñuelos
{
    partial class frmRemitoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemitoNuevo));
            this.dgvRemito = new System.Windows.Forms.DataGridView();
            this.lblNumeroRemito = new System.Windows.Forms.Label();
            this.lblNroRem = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblDestinoRem = new System.Windows.Forms.Label();
            this.lblDestRem = new System.Windows.Forms.Label();
            this.btnAddDest = new System.Windows.Forms.Button();
            this.cboDestinoRem = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.SuspendLayout();
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
            this.dgvRemito.Location = new System.Drawing.Point(12, 102);
            this.dgvRemito.MultiSelect = false;
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemito.Size = new System.Drawing.Size(434, 328);
            this.dgvRemito.TabIndex = 0;
            this.dgvRemito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemito_CellValueChanged);
            // 
            // lblNumeroRemito
            // 
            this.lblNumeroRemito.AutoSize = true;
            this.lblNumeroRemito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRemito.Location = new System.Drawing.Point(9, 29);
            this.lblNumeroRemito.Name = "lblNumeroRemito";
            this.lblNumeroRemito.Size = new System.Drawing.Size(80, 17);
            this.lblNumeroRemito.TabIndex = 1;
            this.lblNumeroRemito.Text = "REMITO N° :";
            // 
            // lblNroRem
            // 
            this.lblNroRem.AutoSize = true;
            this.lblNroRem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRem.Location = new System.Drawing.Point(413, 29);
            this.lblNroRem.Name = "lblNroRem";
            this.lblNroRem.Size = new System.Drawing.Size(11, 17);
            this.lblNroRem.TabIndex = 2;
            this.lblNroRem.Text = " ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(477, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(477, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.White;
            this.btnEliminarTodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.Location = new System.Drawing.Point(477, 185);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(105, 37);
            this.btnEliminarTodo.TabIndex = 5;
            this.btnEliminarTodo.Text = "&Reutilizar";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.White;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(477, 265);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(105, 53);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblDestinoRem
            // 
            this.lblDestinoRem.AutoSize = true;
            this.lblDestinoRem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoRem.Location = new System.Drawing.Point(9, 75);
            this.lblDestinoRem.Name = "lblDestinoRem";
            this.lblDestinoRem.Size = new System.Drawing.Size(68, 17);
            this.lblDestinoRem.TabIndex = 7;
            this.lblDestinoRem.Text = "DESTINO :";
            // 
            // lblDestRem
            // 
            this.lblDestRem.AutoSize = true;
            this.lblDestRem.Location = new System.Drawing.Point(368, 75);
            this.lblDestRem.Name = "lblDestRem";
            this.lblDestRem.Size = new System.Drawing.Size(0, 13);
            this.lblDestRem.TabIndex = 2;
            // 
            // btnAddDest
            // 
            this.btnAddDest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDest.Location = new System.Drawing.Point(233, 71);
            this.btnAddDest.Name = "btnAddDest";
            this.btnAddDest.Size = new System.Drawing.Size(129, 24);
            this.btnAddDest.TabIndex = 3;
            this.btnAddDest.Text = " Seleccionar";
            this.btnAddDest.UseVisualStyleBackColor = false;
            this.btnAddDest.Click += new System.EventHandler(this.btnAddDest_Click);
            // 
            // cboDestinoRem
            // 
            this.cboDestinoRem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDestinoRem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestinoRem.FormattingEnabled = true;
            this.cboDestinoRem.Location = new System.Drawing.Point(83, 71);
            this.cboDestinoRem.Name = "cboDestinoRem";
            this.cboDestinoRem.Size = new System.Drawing.Size(144, 24);
            this.cboDestinoRem.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(477, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 53);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRemitoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 442);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemitoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " NUEVO REMITO";
            this.Load += new System.EventHandler(this.frmRemitoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRemito;
        private System.Windows.Forms.Label lblNumeroRemito;
        private System.Windows.Forms.Label lblNroRem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblDestinoRem;
        private System.Windows.Forms.Label lblDestRem;
        private System.Windows.Forms.Button btnAddDest;
        private System.Windows.Forms.ComboBox cboDestinoRem;
        private System.Windows.Forms.Button btnSalir;
    }
}