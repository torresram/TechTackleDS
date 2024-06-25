using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSeñuelos
{
    public partial class frmListaRemitos : Form
    {
        List<Remito> remitos = new List<Remito>();
        List<Armado> armado = new List<Armado>();
        private Remito seleccionado;
        bool vacio = true;

        public frmListaRemitos()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
        }
        private void frmListaRemitos_Load(object sender, EventArgs e)
        {
            RemitoNeg remitoNeg = new RemitoNeg();
            remitos = remitoNeg.listar();
            dgvListaRemitos.DataSource = remitos;

            if (remitos.Count > 0)
            {
                vacio = false;
                btnImprimir.Enabled = true;
            }

            formatoDgvs(vacio);
        }
        private void dgvListaRemitos_SelectionChanged(object sender, EventArgs e)
        {
            if (seleccionado == null)
            {
                seleccionado = (Remito)dgvListaRemitos.SelectedRows[0].DataBoundItem;
                obtenerRemito(seleccionado);
                dgvDetalleRemito.DataSource = armado;
                dgvDetalleRemito.Refresh();
            }
            else
            {
                seleccionado = (Remito)dgvListaRemitos.CurrentRow.DataBoundItem;
                obtenerRemito(seleccionado);
                dgvDetalleRemito.DataSource = armado;
                dgvDetalleRemito.Refresh();
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Remito> listaFiltrada;

            string filtro = txtBuscar.Text;

            if (filtro.Length >= 1)
            {
                listaFiltrada = remitos.FindAll(x => x.Destino.ToLower().Contains(filtro.ToLower()) || x.Numero.ToString().ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = remitos;
            }

            //dgvListaRemitos.DataSource = null;
            dgvListaRemitos.DataSource = listaFiltrada;

            if (listaFiltrada.Count > 0)
            {
                seleccionado = (Remito)dgvListaRemitos.SelectedRows[0].DataBoundItem;
                formatoDgvs(vacio);
            }
            else
            {
                dgvListaRemitos.DataSource = remitos;
            }
        }


        private void formatoDgvs(bool vacio)
        {
            dgvListaRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaRemitos.Columns["Id"].Visible = false;
            dgvListaRemitos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvListaRemitos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaRemitos.Columns["Fecha"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaRemitos.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaRemitos.Columns["Numero"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaRemitos.Columns["Destino"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaRemitos.Columns["Destino"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (!vacio)
            {
                dgvDetalleRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDetalleRemito.Columns["Id"].Visible = false;
                dgvDetalleRemito.Columns["Remito"].Visible = false;
                dgvDetalleRemito.Columns["Artificial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleRemito.Columns["Artificial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleRemito.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleRemito.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleRemito.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleRemito.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        private void obtenerRemito(Remito remito)
        {
            ArmadoNeg armadoNeg = new ArmadoNeg();
            int nroRemito = remito.Numero;

            armado = armadoNeg.detalleRemito(nroRemito);
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Armado armadoActual = (Armado)dgvDetalleRemito.SelectedRows[0].DataBoundItem;
            int remito = armadoActual.Remito.Numero;

            frmReporte imprimir = new frmReporte(armado, remito);
            imprimir.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
