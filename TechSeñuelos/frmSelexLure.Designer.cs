namespace TechSeñuelos
{
    partial class frmSelexLure
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
            this.cboArtificialNR = new System.Windows.Forms.ComboBox();
            this.cboColorNR = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblArtificial = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gpbSelexAnz = new System.Windows.Forms.GroupBox();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbTriple = new System.Windows.Forms.RadioButton();
            this.gpbSelexAnz.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboArtificialNR
            // 
            this.cboArtificialNR.FormattingEnabled = true;
            this.cboArtificialNR.Location = new System.Drawing.Point(133, 41);
            this.cboArtificialNR.Name = "cboArtificialNR";
            this.cboArtificialNR.Size = new System.Drawing.Size(121, 21);
            this.cboArtificialNR.TabIndex = 0;
            // 
            // cboColorNR
            // 
            this.cboColorNR.FormattingEnabled = true;
            this.cboColorNR.Location = new System.Drawing.Point(133, 97);
            this.cboColorNR.Name = "cboColorNR";
            this.cboColorNR.Size = new System.Drawing.Size(121, 21);
            this.cboColorNR.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 157);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArtificial
            // 
            this.lblArtificial.AutoSize = true;
            this.lblArtificial.Location = new System.Drawing.Point(32, 44);
            this.lblArtificial.Name = "lblArtificial";
            this.lblArtificial.Size = new System.Drawing.Size(64, 13);
            this.lblArtificial.TabIndex = 3;
            this.lblArtificial.Text = "SEÑUELO :";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(46, 100);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "COLOR :";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(28, 164);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "CANTIDAD :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(287, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(287, 134);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Terminar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(49, 289);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(319, 30);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "&PERSONALIZAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gpbSelexAnz
            // 
            this.gpbSelexAnz.Controls.Add(this.rbTriple);
            this.gpbSelexAnz.Controls.Add(this.rbSimple);
            this.gpbSelexAnz.Location = new System.Drawing.Point(32, 202);
            this.gpbSelexAnz.Name = "gpbSelexAnz";
            this.gpbSelexAnz.Size = new System.Drawing.Size(356, 78);
            this.gpbSelexAnz.TabIndex = 9;
            this.gpbSelexAnz.TabStop = false;
            this.gpbSelexAnz.Text = "Configuración";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(45, 36);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(82, 17);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.Text = "con Simples";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.Checked = true;
            this.rbTriple.Location = new System.Drawing.Point(225, 36);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(77, 17);
            this.rbTriple.TabIndex = 1;
            this.rbTriple.TabStop = true;
            this.rbTriple.Text = "con Triples";
            this.rbTriple.UseVisualStyleBackColor = true;
            // 
            // frmSelexLure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 352);
            this.Controls.Add(this.gpbSelexAnz);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblArtificial);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboColorNR);
            this.Controls.Add(this.cboArtificialNR);
            this.Name = "frmSelexLure";
            this.Text = "SELECCION";
            this.Load += new System.EventHandler(this.frmSelexLure_Load);
            this.gpbSelexAnz.ResumeLayout(false);
            this.gpbSelexAnz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboArtificialNR;
        private System.Windows.Forms.ComboBox cboColorNR;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblArtificial;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gpbSelexAnz;
        private System.Windows.Forms.RadioButton rbTriple;
        private System.Windows.Forms.RadioButton rbSimple;
    }
}