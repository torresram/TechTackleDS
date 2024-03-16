using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSeñuelos
{
    public partial class frmArtificiales : Form
    {
        public frmArtificiales()
        {
            InitializeComponent();
        }
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
                pbImagenArtificial.Load("~/imgs/noImageIcon.png");
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
            Close();
        }
        private void cargarDGV()
        {
            List<Artificial> lista;
            ArtificialNeg negocio = new ArtificialNeg();
            lista = negocio.listar();
            dgvArtificiales.DataSource = lista;
        }
        private void formatoDGV()
        {
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
    }
}
