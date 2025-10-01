namespace TechSeñuelos
{
    partial class frmStockUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockUpdate));
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.lblExito = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.prbBarra = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(12, 16);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(132, 16);
            this.lblDisclaimer.TabIndex = 0;
            this.lblDisclaimer.Text = "Seleccione el archivo...";
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.lblPorcentaje);
            this.gpBox.Controls.Add(this.lblExito);
            this.gpBox.Controls.Add(this.txtRuta);
            this.gpBox.Controls.Add(this.lblRuta);
            this.gpBox.Controls.Add(this.btnAceptar);
            this.gpBox.Controls.Add(this.btnArchivo);
            this.gpBox.Controls.Add(this.lblDisclaimer);
            this.gpBox.Controls.Add(this.prbBarra);
            this.gpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBox.Location = new System.Drawing.Point(12, 12);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(370, 139);
            this.gpBox.TabIndex = 1;
            this.gpBox.TabStop = false;
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExito.Location = new System.Drawing.Point(112, 111);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(152, 16);
            this.lblExito.TabIndex = 6;
            this.lblExito.Text = "¡STOCK ACTUALIZADO!";
            this.lblExito.Visible = false;
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(115, 46);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(243, 21);
            this.txtRuta.TabIndex = 4;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(73, 48);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(36, 16);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(278, 106);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 27);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.SystemColors.Control;
            this.btnArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArchivo.BackgroundImage")));
            this.btnArchivo.Location = new System.Drawing.Point(15, 46);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(52, 52);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // prbBarra
            // 
            this.prbBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prbBarra.Location = new System.Drawing.Point(115, 73);
            this.prbBarra.Name = "prbBarra";
            this.prbBarra.Size = new System.Drawing.Size(243, 15);
            this.prbBarra.TabIndex = 2;
            this.prbBarra.Visible = false;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(218, 91);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 15);
            this.lblPorcentaje.TabIndex = 7;
            // 
            // frmStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.gpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ACTUALIZACION STOCK";
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ProgressBar prbBarra;
        private System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}