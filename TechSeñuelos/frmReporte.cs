using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmReporte : Form
    {
        private List<Insumos> insumos;
        public frmReporte(List<Insumos> lista)
        {
            this.insumos = lista;
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            rptFinal.Refresh();
            insumosBindingSource.DataSource = insumos;
            rptFinal.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptInsumos.rdlc";
            ReportDataSource data = new ReportDataSource("dataInsumos",insumos);
            rptFinal.LocalReport.DataSources.Add(data);
            
            this.rptFinal.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }        
    }
}
