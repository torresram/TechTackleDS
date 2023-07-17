namespace TechSeñuelos
{
    partial class frmPersonalizar
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblArtificial = new System.Windows.Forms.Label();
            this.lblAnzuelo = new System.Windows.Forms.Label();
            this.lblAnillasAn = new System.Windows.Forms.Label();
            this.lblAnillasP = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboAnzuelo = new System.Windows.Forms.ComboBox();
            this.cboAnillasA = new System.Windows.Forms.ComboBox();
            this.cboAnillasP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(428, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(310, 237);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // lblArtificial
            // 
            this.lblArtificial.AutoSize = true;
            this.lblArtificial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtificial.Location = new System.Drawing.Point(12, 9);
            this.lblArtificial.Name = "lblArtificial";
            this.lblArtificial.Size = new System.Drawing.Size(0, 31);
            this.lblArtificial.TabIndex = 1;
            // 
            // lblAnzuelo
            // 
            this.lblAnzuelo.AutoSize = true;
            this.lblAnzuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzuelo.Location = new System.Drawing.Point(25, 82);
            this.lblAnzuelo.Name = "lblAnzuelo";
            this.lblAnzuelo.Size = new System.Drawing.Size(82, 17);
            this.lblAnzuelo.TabIndex = 2;
            this.lblAnzuelo.Text = "ANZUELO: ";
            // 
            // lblAnillasAn
            // 
            this.lblAnillasAn.AutoSize = true;
            this.lblAnillasAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnillasAn.Location = new System.Drawing.Point(25, 134);
            this.lblAnillasAn.Name = "lblAnillasAn";
            this.lblAnillasAn.Size = new System.Drawing.Size(142, 17);
            this.lblAnillasAn.TabIndex = 3;
            this.lblAnillasAn.Text = "ANILLAS ANZUELO: ";
            // 
            // lblAnillasP
            // 
            this.lblAnillasP.AutoSize = true;
            this.lblAnillasP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnillasP.Location = new System.Drawing.Point(25, 188);
            this.lblAnillasP.Name = "lblAnillasP";
            this.lblAnillasP.Size = new System.Drawing.Size(129, 17);
            this.lblAnillasP.TabIndex = 4;
            this.lblAnillasP.Text = "ANILLAS PALETA: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(428, 285);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 46);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(642, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboAnzuelo
            // 
            this.cboAnzuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnzuelo.FormattingEnabled = true;
            this.cboAnzuelo.Location = new System.Drawing.Point(267, 78);
            this.cboAnzuelo.Name = "cboAnzuelo";
            this.cboAnzuelo.Size = new System.Drawing.Size(155, 21);
            this.cboAnzuelo.TabIndex = 9;
            // 
            // cboAnillasA
            // 
            this.cboAnillasA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnillasA.FormattingEnabled = true;
            this.cboAnillasA.Location = new System.Drawing.Point(267, 133);
            this.cboAnillasA.Name = "cboAnillasA";
            this.cboAnillasA.Size = new System.Drawing.Size(155, 21);
            this.cboAnillasA.TabIndex = 10;
            // 
            // cboAnillasP
            // 
            this.cboAnillasP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnillasP.FormattingEnabled = true;
            this.cboAnillasP.Location = new System.Drawing.Point(267, 184);
            this.cboAnillasP.Name = "cboAnillasP";
            this.cboAnillasP.Size = new System.Drawing.Size(155, 21);
            this.cboAnillasP.TabIndex = 11;
            // 
            // frmPersonalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 364);
            this.Controls.Add(this.cboAnillasP);
            this.Controls.Add(this.cboAnillasA);
            this.Controls.Add(this.cboAnzuelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAnillasP);
            this.Controls.Add(this.lblAnillasAn);
            this.Controls.Add(this.lblAnzuelo);
            this.Controls.Add(this.lblArtificial);
            this.Controls.Add(this.pbImagen);
            this.Name = "frmPersonalizar";
            this.Text = "PERSONALIZAR(?)";
            this.Load += new System.EventHandler(this.frmPersonalizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblArtificial;
        private System.Windows.Forms.Label lblAnzuelo;
        private System.Windows.Forms.Label lblAnillasAn;
        private System.Windows.Forms.Label lblAnillasP;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboAnzuelo;
        private System.Windows.Forms.ComboBox cboAnillasA;
        private System.Windows.Forms.ComboBox cboAnillasP;
    }
}