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
    public partial class frmSetStandar : Form
    {
        public event EventHandler btnColorUpdate;
        public frmSetStandar()
        {
            InitializeComponent();
        }
        private void frmSetStandar_Load(object sender, EventArgs e)
        {
            checkStandar();
            StandarNeg standar = new StandarNeg();
            List<Standar> lista = standar.listarConId();
            dgvStandar.DataSource = lista;
            dgvStandarFormato();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnColorUpdate?.Invoke(this, EventArgs.Empty);
            Close();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvStandar.RowCount > 0)
            {
                Standar seleccion = (Standar)dgvStandar.CurrentRow.DataBoundItem;
                frmNuevoStandar modificar = new frmNuevoStandar(seleccion);
                modificar.ActualizarNuevo += FrmNuevoStandar_ActualizarNuevo;
                modificar.ShowDialog();
            }
        }
        private void FrmNuevoStandar_ActualizarNuevo(object sender, EventArgs e)
        {
            StandarNeg standar = new StandarNeg();
            List<Standar> lista = standar.listarConId();
            dgvStandar.DataSource = lista;
            dgvStandarFormato();
            dgvStandar.Refresh();
        }
        private void checkStandar()
        {
            StandarNeg negocio = new StandarNeg();
            Standar standar = new Standar();
            List<string> modelos = negocio.obtModelo();
            List<Standar> lista = negocio.listar();

            if (lista.Count != modelos.Count)
            {
                foreach (string modelo in modelos)
                {
                    bool existe = lista.Any(mod => mod.Modelo == modelo);
                    if (!existe)
                    {
                        negocio.agregarStandar(modelo);
                    }
                }
            }
        }
        private void dgvStandarFormato()
        {
            dgvStandar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStandar.Columns["Id"].Visible = false;
            dgvStandar.Columns["codigoArmado"].Visible = false;
            dgvStandar.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnillaAnz"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnillaAnz"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnillaPal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnillaPal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnzSimple"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnzSimple"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnzTriple"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["AnzTriple"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Carton"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Carton"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Blister"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Blister"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Piton"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Piton"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStandar.Columns["Cantidad"].Visible = false;
            dgvStandar.Columns["tipoAnzuelo"].Visible = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvStandar.RowCount > 0)
            {
                if (MessageBox.Show("¿Quiere eliminar el registro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Standar seleccion = new Standar();
                    seleccion = (Standar)dgvStandar.CurrentRow.DataBoundItem;
                    int id = seleccion.Id;

                    StandarNeg negocio = new StandarNeg();
                    negocio.eliminarStandar(id);
                }
            }
        }
        private void dgvStandar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Standar seleccion = (Standar)dgvStandar.CurrentRow.DataBoundItem;
            frmNuevoStandar modificar = new frmNuevoStandar(seleccion);
            modificar.ActualizarNuevo += FrmNuevoStandar_ActualizarNuevo;
            modificar.ShowDialog();
        }
    }
}
