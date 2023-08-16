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
            this.rptFinal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.rptFinal.Size = new System.Drawing.Size(634, 620);
            this.rptFinal.TabIndex = 0;
            this.rptFinal.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // insumosBindingSource
            // 
            this.insumosBindingSource.DataSource = typeof(dominio.Insumos);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 620);
            this.Controls.Add(this.rptFinal);
            this.Name = "frmReporte";
            this.Text = "IMPRIMIR";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFinal;
        private System.Windows.Forms.BindingSource insumosBindingSource;
    }
}