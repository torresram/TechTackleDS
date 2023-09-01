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
    public partial class frmStockInsumos : Form
    {
        private List<Anillas> anillas;
        private List<Anzuelos> anzuelos;
        private List<Blister> blisters;
        private List<Carcasa> carcasas;
        private List<Carton> cartones;
        private List<Piton> pitones;

        public frmStockInsumos()
        {
            InitializeComponent();

            AnillaNeg anillaNeg = new AnillaNeg();
            anillas = anillaNeg.listar();
            dgvAnillas.DataSource = anillas;

            AnzueloNeg anzueloNeg = new AnzueloNeg();
            anzuelos = anzueloNeg.listar();
            dgvAnzuelos.DataSource = anzuelos;

            BlisterNeg blisterNeg = new BlisterNeg();
            blisters = blisterNeg.listar();
            dgvBlister.DataSource = blisters;

            CarcasaNeg carcasaNeg = new CarcasaNeg();
            carcasas = carcasaNeg.listar();
            dgvCarcasas.DataSource = carcasas;

            CartonNeg cartonNeg = new CartonNeg();
            cartones = cartonNeg.listar();
            dgvCarton.DataSource = cartones;

            PitonNeg pitonNeg = new PitonNeg();
            pitones = pitonNeg.listar();
            dgvPitones.DataSource = pitones;
        }

        private void frmStockInsumos_Load(object sender, EventArgs e)
        {
            formatoDgvs();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            int indice = tbInsumos.SelectedIndex;

            switch (indice)//tengo que hacer esto por no haber hecho herencia con los insumos...
            {
                case 0:
                    filtroDgv<Anillas>(anillas,dgvAnillas,"Marca","Tamaño");
                    break;
                case 1:
                    filtroDgv<Anzuelos>(anzuelos, dgvAnzuelos, "Numero", "Descripcion");
                    break;
                case 2:
                    filtroDgv<Blister>(blisters, dgvBlister, "Modelo", "Descripcion");
                    break;
                case 3:
                    filtroDgv<Carcasa>(carcasas, dgvCarcasas, "Modelo", "PesoArmado");
                    break;
                case 4:
                    filtroDgv<Carton>(cartones, dgvCarton, "Modelo", "Descripcion");
                    break;
                case 5:
                    filtroDgv<Piton>(pitones, dgvPitones, "Modelo");
                    break;
            }
        }

        private void formatoDgvs()
        {
            dgvAnillas.Columns["Id"].Visible = false;
            dgvAnillas.Columns["Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Marca"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Tamaño"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Tamaño"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAnillas.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAnillas.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnillas.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";

            for (int i = 0; i < dgvAnillas.Rows.Count; i++)
            {
                DataGridViewRow row = dgvAnillas.Rows[i];

                string valorCelda = row.Cells[1].Value as string;

                if (!string.IsNullOrEmpty(valorCelda) && valorCelda.ToLower() == "vacio")
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvAnzuelos.Columns["Id"].Visible = false;
            dgvAnzuelos.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Numero"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAnzuelos.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAnzuelos.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAnzuelos.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";

            for (int i = 0; i < dgvAnzuelos.Rows.Count; i++)
            {
                DataGridViewRow row = dgvAnzuelos.Rows[i];

                string valorCelda = row.Cells[2].Value as string;

                if (valorCelda.ToLower() == "no lleva")
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvBlister.Columns["Id"].Visible = false;
            dgvBlister.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBlister.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBlister.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBlister.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";

            dgvCarcasas.Columns["Id"].Visible = false;
            dgvCarcasas.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarcasas.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";
            dgvCarcasas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarcasas.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCarton.Columns["Id"].Visible = false;
            dgvCarton.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarton.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarton.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarton.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";

            dgvPitones.Columns["Id"].Visible = false;
            dgvPitones.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPitones.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPitones.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";
        }

        private void tbInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatoDgvs();
        }
        
        private void filtroDgv<T>(List<T> lista, DataGridView dgv, params string[] columnas)
        {
          string filtro = txtFiltro.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                dgv.DataSource = lista;
            }
            else
            {
                filtro = filtro.ToUpper();

                var listaFiltrada = lista
                    .Where(item =>
                    {
                        foreach(var col in columnas)
                        {
                            var propiedad = item.GetType().GetProperty(col);
                            if(propiedad != null)
                            {
                                var valor = propiedad.GetValue(item,null)?.ToString();
                                if(!string.IsNullOrEmpty(valor) && valor.ToUpper().Contains(filtro))
                                {
                                    return true;
                                }
                            }
                        }
                        return false;
                    }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaFiltrada;
            }

            formatoDgvs();
        }               
    }
}
