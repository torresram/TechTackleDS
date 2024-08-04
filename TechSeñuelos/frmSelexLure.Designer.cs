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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelexLure));
            this.cboArtificialNR = new System.Windows.Forms.ComboBox();
            this.cboColorNR = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblArtificial = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gpbSelexAnz = new System.Windows.Forms.GroupBox();
            this.rbTriple = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.gpbSelexAnz.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboArtificialNR
            // 
            this.cboArtificialNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArtificialNR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArtificialNR.FormattingEnabled = true;
            this.cboArtificialNR.Location = new System.Drawing.Point(139, 41);
            this.cboArtificialNR.Name = "cboArtificialNR";
            this.cboArtificialNR.Size = new System.Drawing.Size(121, 25);
            this.cboArtificialNR.TabIndex = 0;
            this.cboArtificialNR.SelectedValueChanged += new System.EventHandler(this.cboArtificialNR_SelectedValueChanged);
            // 
            // cboColorNR
            // 
            this.cboColorNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorNR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColorNR.FormattingEnabled = true;
            this.cboColorNR.Location = new System.Drawing.Point(139, 83);
            this.cboColorNR.Name = "cboColorNR";
            this.cboColorNR.Size = new System.Drawing.Size(121, 25);
            this.cboColorNR.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(139, 127);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 23);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArtificial
            // 
            this.lblArtificial.AutoSize = true;
            this.lblArtificial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtificial.Location = new System.Drawing.Point(42, 41);
            this.lblArtificial.Name = "lblArtificial";
            this.lblArtificial.Size = new System.Drawing.Size(82, 20);
            this.lblArtificial.TabIndex = 0;
            this.lblArtificial.Text = "SEÑUELO :";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(53, 83);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(71, 20);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "COLOR :";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(30, 127);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(94, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "CANTIDAD :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(287, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 43);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTerminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(286, 107);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(102, 43);
            this.btnTerminar.TabIndex = 6;
            this.btnTerminar.Text = "&Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(32, 270);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(357, 30);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "&PERSONALIZAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gpbSelexAnz
            // 
            this.gpbSelexAnz.Controls.Add(this.rbTriple);
            this.gpbSelexAnz.Controls.Add(this.rbSimple);
            this.gpbSelexAnz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSelexAnz.Location = new System.Drawing.Point(32, 183);
            this.gpbSelexAnz.Name = "gpbSelexAnz";
            this.gpbSelexAnz.Size = new System.Drawing.Size(356, 78);
            this.gpbSelexAnz.TabIndex = 3;
            this.gpbSelexAnz.TabStop = false;
            this.gpbSelexAnz.Text = "Anzuelos";
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.Checked = true;
            this.rbTriple.Location = new System.Drawing.Point(225, 36);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(63, 21);
            this.rbTriple.TabIndex = 1;
            this.rbTriple.TabStop = true;
            this.rbTriple.Text = "Triples";
            this.rbTriple.UseVisualStyleBackColor = true;
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(45, 36);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(73, 21);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.Text = "Simples";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // frmSelexLure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnTerminar;
            this.ClientSize = new System.Drawing.Size(407, 318);
            this.Controls.Add(this.gpbSelexAnz);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblArtificial);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboColorNR);
            this.Controls.Add(this.cboArtificialNR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelexLure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCIONAR";
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
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gpbSelexAnz;
        private System.Windows.Forms.RadioButton rbTriple;
        private System.Windows.Forms.RadioButton rbSimple;
    }
}