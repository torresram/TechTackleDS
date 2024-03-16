using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmColores : Form
    {
        private List<dominio.Color> colores;
        public frmColores()
        {
            InitializeComponent();
        }
        private void frmColores_Load(object sender, EventArgs e)
        {
            cargarDgv();
            formatoDgv();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmColorNuevo color = new frmColorNuevo();
            color.Actualizar += frmColorNuevo_Actualizar;
            color.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            dominio.Color seleccion;
            seleccion = (dominio.Color)dgvColores.CurrentRow.DataBoundItem;

            frmColorNuevo modificar = new frmColorNuevo(seleccion);
            modificar.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ColorNeg negocio = new ColorNeg();
            dominio.Color seleccion;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccion = (dominio.Color)dgvColores.CurrentRow.DataBoundItem;
                    negocio.eliminarColor(seleccion);
                    cargarDgv();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void cargarDgv()
        {
            ColorNeg negocio = new ColorNeg();
            colores = negocio.listar();
            dgvColores.DataSource = colores;
        }
        private void formatoDgv()
        {
            dgvColores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgvColores.Columns["Id"].Visible = false;
            dgvColores.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColores.Columns["Modelo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColores.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColores.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColores.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmColorNuevo_Actualizar (object sender, EventArgs e)
        {
            cargarDgv();
            dgvColores.Refresh();
        }
    }
}
