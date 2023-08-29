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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRemito
            // 
            this.dgvRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvRemito.Location = new System.Drawing.Point(29, 90);
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemito.Size = new System.Drawing.Size(434, 328);
            this.dgvRemito.TabIndex = 0;
            this.dgvRemito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemito_CellValueChanged);
            // 
            // lblNumeroRemito
            // 
            this.lblNumeroRemito.AutoSize = true;
            this.lblNumeroRemito.Location = new System.Drawing.Point(26, 17);
            this.lblNumeroRemito.Name = "lblNumeroRemito";
            this.lblNumeroRemito.Size = new System.Drawing.Size(70, 13);
            this.lblNumeroRemito.TabIndex = 1;
            this.lblNumeroRemito.Text = "REMITO N° :";
            // 
            // lblNroRem
            // 
            this.lblNroRem.AutoSize = true;
            this.lblNroRem.Location = new System.Drawing.Point(430, 17);
            this.lblNroRem.Name = "lblNroRem";
            this.lblNroRem.Size = new System.Drawing.Size(10, 13);
            this.lblNroRem.TabIndex = 2;
            this.lblNroRem.Text = " ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 46);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(494, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 49);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar artículo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(494, 210);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(105, 49);
            this.btnEliminarTodo.TabIndex = 5;
            this.btnEliminarTodo.Text = "&Reutilizar";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(494, 360);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(105, 58);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblDestinoRem
            // 
            this.lblDestinoRem.AutoSize = true;
            this.lblDestinoRem.Location = new System.Drawing.Point(26, 63);
            this.lblDestinoRem.Name = "lblDestinoRem";
            this.lblDestinoRem.Size = new System.Drawing.Size(61, 13);
            this.lblDestinoRem.TabIndex = 7;
            this.lblDestinoRem.Text = "DESTINO :";
            // 
            // lblDestRem
            // 
            this.lblDestRem.AutoSize = true;
            this.lblDestRem.Location = new System.Drawing.Point(385, 63);
            this.lblDestRem.Name = "lblDestRem";
            this.lblDestRem.Size = new System.Drawing.Size(0, 13);
            this.lblDestRem.TabIndex = 8;
            // 
            // btnAddDest
            // 
            this.btnAddDest.Location = new System.Drawing.Point(433, 57);
            this.btnAddDest.Name = "btnAddDest";
            this.btnAddDest.Size = new System.Drawing.Size(30, 30);
            this.btnAddDest.TabIndex = 10;
            this.btnAddDest.Text = "+";
            this.btnAddDest.UseVisualStyleBackColor = true;
            this.btnAddDest.Click += new System.EventHandler(this.btnAddDest_Click);
            // 
            // cboDestinoRem
            // 
            this.cboDestinoRem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDestinoRem.FormattingEnabled = true;
            this.cboDestinoRem.Location = new System.Drawing.Point(280, 63);
            this.cboDestinoRem.Name = "cboDestinoRem";
            this.cboDestinoRem.Size = new System.Drawing.Size(144, 21);
            this.cboDestinoRem.TabIndex = 11;
            // 
            // frmRemitoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 453);
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
            this.Name = "frmRemitoNuevo";
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
    }
}