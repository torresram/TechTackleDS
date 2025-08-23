using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSeñuelos.Properties;
using dominio;
using negocio;
using System.Configuration;

namespace TechSeñuelos
{
    public partial class frmArtificiales : Form
    {
        private List<Artificial> artificiales;
        public event EventHandler ActualizarMain;
        public event EventHandler btnColorUpdate;
        public frmArtificiales()
        {
            InitializeComponent();
        }
        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    WindowState = FormWindowState.Maximized;
        //}
        private void frmArtificiales_Load(object sender, EventArgs e)
        {
            cargarDGV();
            formatoDGV();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArtificialNuevo nuevo = new frmArtificialNuevo();
            nuevo.Actualizar += frmArtificialNuevo_Actualizar;
            nuevo.ShowDialog();
        }
        private void dgvArtificiales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtificiales.CurrentRow != null)
            {
                Artificial seleccion = (Artificial)dgvArtificiales.CurrentRow.DataBoundItem;
                cargarImg(seleccion.Imagen);
            }
        }
        private void cargarImg(string imagen)
        {
            try
            {
                pbImagenArtificial.Load(imagen);
            }
            catch (Exception)
            {
                pbImagenArtificial.Image = Resources.noImageIcon;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Artificial seleccion = (Artificial)dgvArtificiales.CurrentRow.DataBoundItem;

            frmArtificialNuevo modificar = new frmArtificialNuevo(seleccion);
            modificar.ShowDialog();
        }
        public void frmArtificialNuevo_Actualizar(object sender, EventArgs e)
        {
            cargarDGV();
            formatoDGV();
            dgvArtificiales.Refresh();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArtificialNeg negocio = new ArtificialNeg();

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Artificial seleccion = (Artificial)dgvArtificiales.CurrentRow.DataBoundItem;
                negocio.eliminarArtificial(seleccion);
                cargarDGV();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActualizarMain?.Invoke(this, EventArgs.Empty);
            btnColorUpdate?.Invoke(this, EventArgs.Empty);
            Close();
        }
        private void cargarDGV()
        {
            //List<Artificial> lista;
            ArtificialNeg negocio = new ArtificialNeg();
            artificiales = negocio.listar();
            dgvArtificiales.DataSource = artificiales;
        }
        private void formatoDGV()
        {
            //dgvArtificiales.Sort(dgvArtificiales.Columns["Modelo"],ListSortDirection.Ascending);
            dgvArtificiales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtificiales.Columns["id"].Visible = false;
            dgvArtificiales.Columns["Imagen"].Visible = false;
            dgvArtificiales.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArtificiales.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Artificial> listaFiltrada;

            string filtro = txtBuscar.Text;

            if (filtro.Length >= 1)
            {
                listaFiltrada = artificiales.FindAll(x => x.Codigo.ToLower().Contains(filtro.ToLower()) || x.Modelo.ToString().ToLower().Contains(filtro.ToLower()) || x.Color.ToString().ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = artificiales;
            }

            //dgvListaRemitos.DataSource = null;
            dgvArtificiales.DataSource = listaFiltrada;

            if (listaFiltrada.Count > 0)
            {
                Artificial seleccionado = new Artificial();
                seleccionado = (Artificial)dgvArtificiales.SelectedRows[0].DataBoundItem;
                formatoDGV();
            }
            else
            {
                dgvArtificiales.DataSource = artificiales;
            }
        }
        private void dgvArtificiales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Artificial seleccionado = (Artificial)dgvArtificiales.CurrentRow.DataBoundItem;

            frmArtificialNuevo modificar = new frmArtificialNuevo(seleccionado);
            modificar.ShowDialog();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            frmProduccion produccion = new frmProduccion();
            produccion.ShowDialog();
        }
    }
}
