using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Microsoft.ReportingServices.Diagnostics.Internal;
using negocio;

namespace TechSeñuelos
{
    public partial class frmProduccion : Form
    {
        private List<Produccion> lista;
        bool habilitarFlag = false;
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            checkModelos();
            cargarDgv();
            formatoDgv();
            cargaCboModeloTarea();
        }

        private void cargarDgv()
        {
            try
            {
                ProduccionNeg negocio = new ProduccionNeg();
                lista = negocio.listar();
                dgvProduccion.DataSource = lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void formatoDgv()
        {
            dgvProduccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduccion.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvProduccion.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            dgvProduccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduccion.Columns["Id"].Visible = false;
            dgvProduccion.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Modelo"].ReadOnly = true;
            dgvProduccion.Columns["Carcasas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Carcasas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Carcasas"].ReadOnly = true;
            dgvProduccion.Columns["Armados"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Armados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Armados"].ReadOnly = true;
            dgvProduccion.Columns["Soldados"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Soldados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Soldados"].ReadOnly = true;
            dgvProduccion.Columns["Lijados"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Lijados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduccion.Columns["Lijados"].ReadOnly = true;
        }
        
        private void checkModelos()
        {
            ProduccionNeg negocio = new ProduccionNeg();
            Produccion producccion= new Produccion();
            List<Produccion> modelos = negocio.obtModelo();
            List<Produccion> lista = negocio.listar();

            if (lista.Count != modelos.Count)
            {
                foreach (Produccion modelo in modelos)
                {
                    bool existe = lista.Any(mod => mod.Modelo == modelo.Modelo);
                    if (!existe)
                    {
                        negocio.agregarModelo(modelo);
                    }
                }
            }
        }
        private void dgvProduccion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Produccion produccion = (Produccion)dgvProduccion.CurrentRow.DataBoundItem;

            int fila = e.RowIndex;
            int celda = e.ColumnIndex;
            DataGridViewCell valorCelda = dgvProduccion.Rows[fila].Cells[celda];
            string columna = dgvProduccion.Columns[e.ColumnIndex].Name;
            int cantUpd;

            if (columna.ToLower() == "carcasas")
            {
                CarcasaNeg negocio = new CarcasaNeg();
                Carcasa carcasa = new Carcasa();
                carcasa.Modelo = produccion.Modelo;
                carcasa.Cantidad = produccion.Carcasas;
                negocio.modificarCarcasaProd(carcasa);
            }

            if (valorCelda.Value != null && int.TryParse(valorCelda.Value.ToString(), out cantUpd))
            {
                ProduccionNeg negocio = new ProduccionNeg();
                negocio.actualizarValor(produccion);
            }
        }
        private void dgvProduccion_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!(dgvProduccion.Columns[e.ColumnIndex].Name == "Modelo") && e.FormattedValue.ToString() != "")
            {
                int cantidad;
                if (!int.TryParse(e.FormattedValue.ToString(), out cantidad))
                {
                    dgvProduccion.Rows[e.RowIndex].ErrorText = "Sólo números";
                    e.Cancel = true;
                    MessageBox.Show("El valor debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvProduccion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduccion.Rows[e.RowIndex].ErrorText = string.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (!habilitarFlag)
            {
                dgvProduccion.Columns["Carcasas"].ReadOnly = false;
                dgvProduccion.Columns["Armados"].ReadOnly = false;
                dgvProduccion.Columns["Soldados"].ReadOnly = false;
                dgvProduccion.Columns["Lijados"].ReadOnly = false;
                habilitarFlag = true;
                btnHabilitar.Text = "DES&HABILITAR";
            }
            else
            {
                dgvProduccion.Columns["Carcasas"].ReadOnly = true;
                dgvProduccion.Columns["Armados"].ReadOnly = true;
                dgvProduccion.Columns["Soldados"].ReadOnly = true;
                dgvProduccion.Columns["Lijados"].ReadOnly = true;
                habilitarFlag = false;
                btnHabilitar.Text = "&HABILITAR";
            }
        }
        private void dgvProduccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Índices de las columnas que contienen enteros
            var columnasEnteras = new List<int> {2, 3, 4, 5 };

            // Verificamos si la celda pertenece a una de esas columnas
            if (columnasEnteras.Contains(e.ColumnIndex))
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int valor))
                {
                    if (valor < 15)
                    {
                        dgvProduccion.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.MistyRose;
                    }
                    else if (valor < 25)
                    {
                        dgvProduccion.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.LemonChiffon;
                    }
                    else
                    {
                        dgvProduccion.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.PaleGreen;
                    }
                }
            }
        }
        private void cargaCboModeloTarea()
        {
            try
            {
                TalonariosNeg tarea = new TalonariosNeg();
                cboTareas.DataSource = tarea.listar();
                cboTareas.ValueMember = "id";
                cboTareas.DisplayMember = "nombre";
                cboTareas.SelectedIndex = -1;
                cboTareas.Text = "Enviar a...";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {               
            Talonarios talonario = (Talonarios)cboTareas.SelectedItem;
            frmTrabajosRemitos trabajos = new frmTrabajosRemitos(talonario.Nombre);
            trabajos.ShowDialog();
        }
    }
}
