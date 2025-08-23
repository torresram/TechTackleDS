using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmReporte : Form
    {
        private List<Insumos> insumos;
        private List<Armado> armado;
        private List<Remito> remito;
        private List<TrabajosRemitos> trabajos;
        private RemitoNeg negocioRemito = new RemitoNeg();
        private TrabajosNeg trabajoNegocio = new TrabajosNeg();

        public frmReporte(List<Insumos> lista)
        {
            insumos = lista;
            InitializeComponent();
            rptRemito.Visible = false;
            rptTrabajos.Visible = false;

            rptFinal.Refresh();
            insumosBindingSource.DataSource = insumos;
            rptFinal.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptInsumos.rdlc";
            ReportDataSource data = new ReportDataSource("dataInsumos", insumos);
            rptFinal.LocalReport.DataSources.Add(data);

            rptFinal.RefreshReport();
        }

        public frmReporte(List<Armado> lista, int numero)
        {
            armado = lista;
            InitializeComponent();
            remito = negocioRemito.listar(numero);
            rptFinal.Visible = false;
            rptTrabajos.Visible = false;

            rptRemito.Refresh();
            armadoBindingSource.DataSource = armado;
            remitoBindingSource.DataSource = remito;
            rptRemito.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptRemito.rdlc";
            ReportDataSource data = new ReportDataSource("dataRemito", armado);
            ReportDataSource dataFd = new ReportDataSource("dtFechaDestino", remito);
            rptRemito.LocalReport.DataSources.Clear();
            rptRemito.LocalReport.DataSources.Add(dataFd);
            rptRemito.LocalReport.DataSources.Add(data);

            //string fecha = dataFd.Value;

            rptRemito.RefreshReport();
        }

        public frmReporte(string numero, string talonario)
        {
            trabajos = trabajoNegocio.detalleTrabajo(numero, talonario);
            InitializeComponent();
            rptFinal.Visible = false;
            rptRemito.Visible = false;

            rptTrabajos.Refresh();
            trabajosBindingSource.DataSource = trabajos;
            rptTrabajos.LocalReport.ReportEmbeddedResource = "TechSeñuelos.rptTrabajos.rdlc";
            ReportDataSource data = new ReportDataSource("dataTrabajos", trabajos);
            rptTrabajos.LocalReport.DataSources.Clear();
            rptTrabajos.LocalReport.DataSources.Add(data);
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            //this.rptRemito.RefreshReport();
            this.rptTrabajos.RefreshReport();
        }
    }
}
