namespace TechSeñuelos
{
    partial class frmReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptFinal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.trabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptRemito = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptTrabajos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // insumosBindingSource
            // 
            this.insumosBindingSource.DataSource = typeof(dominio.Insumos);
            // 
            // armadoBindingSource
            // 
            this.armadoBindingSource.DataSource = typeof(dominio.Armado);
            // 
            // remitoBindingSource
            // 
            this.remitoBindingSource.DataSource = typeof(dominio.Remito);
            // 
            // rptFinal
            // 
            this.rptFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataInsumos";
            reportDataSource1.Value = this.insumosBindingSource;
            this.rptFinal.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFinal.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptInsumos.rdlc";
            this.rptFinal.Location = new System.Drawing.Point(0, 0);
            this.rptFinal.Name = "rptFinal";
            this.rptFinal.ServerReport.BearerToken = null;
            this.rptFinal.Size = new System.Drawing.Size(804, 620);
            this.rptFinal.TabIndex = 0;
            // 
            // trabajosBindingSource
            // 
            this.trabajosBindingSource.DataSource = typeof(dominio.TrabajosRemitos);
            // 
            // rptRemito
            // 
            this.rptRemito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptRemito.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptRemito.rdlc";
            this.rptRemito.Location = new System.Drawing.Point(0, 0);
            this.rptRemito.Name = "rptRemito";
            this.rptRemito.ServerReport.BearerToken = null;
            this.rptRemito.Size = new System.Drawing.Size(804, 620);
            this.rptRemito.TabIndex = 1;
            // 
            // rptTrabajos
            // 
            this.rptTrabajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptTrabajos.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptTrabajos.rdlc";
            this.rptTrabajos.Location = new System.Drawing.Point(0, 0);
            this.rptTrabajos.Name = "rptTrabajos";
            this.rptTrabajos.ServerReport.BearerToken = null;
            this.rptTrabajos.Size = new System.Drawing.Size(804, 620);
            this.rptTrabajos.TabIndex = 2;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 620);
            this.Controls.Add(this.rptTrabajos);
            this.Controls.Add(this.rptFinal);
            this.Controls.Add(this.rptRemito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IMPRIMIR";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFinal;
        private System.Windows.Forms.BindingSource insumosBindingSource;
        private System.Windows.Forms.BindingSource armadoBindingSource;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private System.Windows.Forms.BindingSource trabajosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptRemito;
        private Microsoft.Reporting.WinForms.ReportViewer rptTrabajos;
    }
}