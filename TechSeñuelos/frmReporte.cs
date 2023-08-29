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
        private List<Armado> armado;
        private List<Remito> remito;
        private RemitoNeg negocioRemito = new RemitoNeg();
        public frmReporte(List<Insumos> lista)
        {
            this.insumos = lista;
            InitializeComponent();
            rptRemito.Visible = false;

            rptFinal.Refresh();
            insumosBindingSource.DataSource = insumos;
            rptFinal.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptInsumos.rdlc";
            ReportDataSource data = new ReportDataSource("dataInsumos", insumos);
            rptFinal.LocalReport.DataSources.Add(data);

            this.rptFinal.RefreshReport();
        }

        public frmReporte(List<Armado> lista,int numero)
        {
            this.armado = lista;
            InitializeComponent();
            remito = negocioRemito.listar(numero);
            rptFinal.Visible = false;
            
            rptRemito.Refresh();
            armadoBindingSource.DataSource = armado;
            remitoBindingSource.DataSource = remito;
            rptRemito.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptRemito.rdlc";
            ReportDataSource data = new ReportDataSource("dataRemito", armado);
            ReportDataSource dataFd = new ReportDataSource("dtFechaDestino", remito);
            rptRemito.LocalReport.DataSources.Add(dataFd);
            rptRemito.LocalReport.DataSources.Add(data);

            this.rptRemito.RefreshReport();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            //this.rptRemito.RefreshReport();
        }
    }
}
