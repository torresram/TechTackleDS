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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptFinal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptRemito = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
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
            // rptRemito
            // 
            this.rptRemito.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dataRemito";
            reportDataSource2.Value = this.armadoBindingSource;
            reportDataSource3.Name = "dtFechaDestino";
            reportDataSource3.Value = this.remitoBindingSource;
            this.rptRemito.LocalReport.DataSources.Add(reportDataSource2);
            this.rptRemito.LocalReport.DataSources.Add(reportDataSource3);
            this.rptRemito.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptRemito.rdlc";
            this.rptRemito.Location = new System.Drawing.Point(0, 0);
            this.rptRemito.Name = "rptRemito";
            this.rptRemito.ServerReport.BearerToken = null;
            this.rptRemito.Size = new System.Drawing.Size(804, 620);
            this.rptRemito.TabIndex = 1;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 620);
            this.Controls.Add(this.rptRemito);
            this.Controls.Add(this.rptFinal);
            this.Name = "frmReporte";
            this.Text = "IMPRIMIR";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFinal;
        private System.Windows.Forms.BindingSource insumosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptRemito;
        private System.Windows.Forms.BindingSource armadoBindingSource;
        private System.Windows.Forms.BindingSource remitoBindingSource;
    }
}