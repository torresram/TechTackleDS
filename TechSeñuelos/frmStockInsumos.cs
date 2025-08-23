using dominio;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private List<string> columnas;
        private Type tipo = null;
        public event EventHandler btnColorUpdate;

        public frmStockInsumos()
        {
            InitializeComponent();
        }
        private void frmStockInsumos_Load(object sender, EventArgs e)
        {
            cargarDgvs();
            formatoDgvs();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            int indice = tbInsumos.SelectedIndex;

            switch (indice) //tengo que hacer esto por no haber hecho herencia con los insumos...
            {
                case 0:
                    filtroDgv<Anillas>(anillas, dgvAnillas, "Marca", "Tamaño");
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
        private void tbInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDgvs();
            formatoDgvs();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice = tbInsumos.SelectedIndex;

            string tabla = DiccionarioTablas.tablaInsumos[indice];
            columnas = obtenerColumnas(tabla);

            frmGestionInsumo agregar = new frmGestionInsumo(columnas, tabla, indice);
            agregar.actualizarDgv += frmStockInsumos_ActualizarDgv;
            agregar.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = tbInsumos.SelectedIndex;
                string tabla = DiccionarioTablas.tablaInsumos[indice];

                switch (indice)
                {
                    case 0:
                        modificarItem(tabla, dgvAnillas);
                        break;
                    case 1:
                        modificarItem(tabla, dgvAnzuelos);
                        break;
                    case 2:
                        modificarItem(tabla, dgvBlister);
                        break;
                    case 3:
                        modificarItem(tabla, dgvCarcasas);
                        break;
                    case 4:
                        modificarItem(tabla, dgvCarton);
                        break;
                    case 5:
                        modificarItem(tabla, dgvPitones);
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay datos para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAnillas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        int indice = tbInsumos.SelectedIndex;
                        int id;

                        switch (indice)
                        {
                            case 0:
                                Anillas anilla = (Anillas)dgvAnillas.CurrentRow.DataBoundItem;
                                id = anilla.Id;
                                eliminarItem(indice, id);
                                break;
                            case 1:
                                Anzuelos anzuelo = (Anzuelos)dgvAnzuelos.CurrentRow.DataBoundItem;
                                id = anzuelo.Id;
                                eliminarItem(indice, id);
                                break;
                            case 2:
                                Blister blister = (Blister)dgvBlister.CurrentRow.DataBoundItem;
                                id = blister.Id;
                                eliminarItem(indice, id);
                                break;
                            case 3:
                                Carcasa carcasa = (Carcasa)dgvCarcasas.CurrentRow.DataBoundItem;
                                id = carcasa.Id;
                                eliminarItem(indice, id);
                                break;
                            case 4:
                                Carton carton = (Carton)dgvCarton.CurrentRow.DataBoundItem;
                                id = carton.Id;
                                eliminarItem(indice, id);
                                break;
                            case 5:
                                Piton piton = (Piton)dgvPitones.CurrentRow.DataBoundItem;
                                id = piton.Id;
                                eliminarItem(indice, id);
                                break;
                        }
                        MessageBox.Show("Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Seleccione el registro que desea eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            cargarDgvs();
            formatoDgvs();
        }
        private List<string> obtenerColumnas(string tabla)
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> columnas = new List<string>();

            try
            {
                datos.setConsulta("SELECT COLUMN_NAME Columna FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tabla");
                datos.setParametro("@tabla", tabla);
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    string nombreColumna = datos.Lector["Columna"].ToString();
                    if (nombreColumna != "Id")
                    {
                        columnas.Add(nombreColumna);
                    }
                }

                return columnas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        private void filtroDgv<T>(List<T> lista, DataGridView dgv, params string[] columnas)
        {
            string filtro = txtFiltro.Text;

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
                        foreach (var col in columnas)
                        {
                            var propiedad = item.GetType().GetProperty(col);
                            if (propiedad != null)
                            {
                                var valor = propiedad.GetValue(item, null)?.ToString();
                                if (!string.IsNullOrEmpty(valor) && valor.ToUpper().Contains(filtro))
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
        private void cargarDgvs()
        {
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
        private void formatoDgvs()
        {
            Font rowFont = new Font("Century Gothic", 9, FontStyle.Regular);
            Font headerFont = new Font("Century Gothic", 9, FontStyle.Bold);

            dgvAnillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                string valorCelda = row.Cells[2].Value as string;

                if (!string.IsNullOrEmpty(valorCelda) && valorCelda.ToLower() == "no lleva")
                {
                    CurrencyManager currency = (CurrencyManager)BindingContext[dgvAnillas.DataSource];
                    currency.SuspendBinding();
                    row.Visible = false;
                    currency.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvAnzuelos.Font = rowFont;
            dgvAnzuelos.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgvAnzuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    CurrencyManager currency = (CurrencyManager)BindingContext[dgvAnzuelos.DataSource];
                    currency.SuspendBinding();
                    row.Visible = false;
                    currency.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvBlister.Font = rowFont;
            dgvBlister.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgvBlister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            for (int i = 0; i < dgvBlister.Rows.Count; i++)
            {
                DataGridViewRow row = dgvBlister.Rows[i];

                string valorCelda = row.Cells[2].Value as string;

                if (valorCelda.ToLower() == "no lleva")
                {
                    CurrencyManager currency = (CurrencyManager)BindingContext[dgvBlister.DataSource];
                    currency.SuspendBinding();
                    row.Visible = false;
                    currency.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvCarcasas.Font = rowFont;
            dgvCarcasas.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgvCarcasas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarcasas.Columns["Id"].Visible = false;
            dgvCarcasas.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarcasas.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarcasas.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";
            dgvCarcasas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarcasas.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCarton.Font = rowFont;
            dgvCarton.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgvCarton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            for (int i = 0; i < dgvCarton.Rows.Count; i++)
            {
                DataGridViewRow row = dgvCarton.Rows[i];

                string valorCelda = row.Cells[2].Value as string;

                if (valorCelda.ToLower() == "no lleva")
                {
                    CurrencyManager currency = (CurrencyManager)BindingContext[dgvCarton.DataSource];
                    currency.SuspendBinding();
                    row.Visible = false;
                    currency.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }

            dgvPitones.Font = rowFont;
            dgvPitones.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgvPitones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPitones.Columns["Id"].Visible = false;
            dgvPitones.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPitones.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPitones.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPitones.Columns["Peso"].DefaultCellStyle.Format = "0.00gr";

            for (int i = 0; i < dgvPitones.Rows.Count; i++)
            {
                DataGridViewRow row = dgvPitones.Rows[i];

                string valorCelda = row.Cells[2].Value as string;

                if (valorCelda.ToLower() == "no lleva")
                {
                    CurrencyManager currency = (CurrencyManager)BindingContext[dgvPitones.DataSource];
                    currency.SuspendBinding();
                    row.Visible = false;
                    currency.ResumeBinding();
                }
                else
                {
                    row.Visible = true;
                }
            }
        }
        private void modificarItem(string tabla, DataGridView dgv)
        {
            Dictionary<string, string> valoresTxtBoxs = new Dictionary<string, string>();
            Produccion prod = new Produccion();
            prod = null;
            //obtengo el tipo de objeto que componen el datagrid
            DataGridViewRow seleccionado = dgv.SelectedRows[0];
            object item = seleccionado.DataBoundItem;
            tipo = item.GetType();

            if(dgv.Name == "dgvCarcasas")
            {
                Carcasa carcasa = (Carcasa)dgv.CurrentRow.DataBoundItem;
                prod = new Produccion();
                prod.Carcasas = carcasa.Cantidad;
                prod.Modelo = carcasa.Modelo;
            }
            //MessageBox.Show("El tipo es " + tipo);

            //obtengo las propiedades del tipo de objeto y sus valores
            PropertyInfo[] propiedades = tipo.GetProperties();

            foreach (PropertyInfo prop in propiedades)
            {
                string campo = prop.Name.ToString();
                string valor = prop.GetValue(item).ToString();

                valoresTxtBoxs.Add(campo, valor);//almaceno en el diccionario los valores obtenidos
            }

            frmGestionInsumo modificar = new frmGestionInsumo(tabla, valoresTxtBoxs, tipo, prod);
            modificar.actualizarDgv += frmStockInsumos_ActualizarDgv;
            modificar.ShowDialog();
        }
        private void eliminarItem(int indice, int id)
        {
            switch (indice)
            {
                case 0:
                    AnillaNeg anilla = new AnillaNeg();
                    anilla.eliminarAnilla(id);
                    break;
                case 1:
                    AnzueloNeg anzuelo = new AnzueloNeg();
                    anzuelo.eliminarAnzuelo(id);
                    break;
                case 2:
                    BlisterNeg blister = new BlisterNeg();
                    blister.eliminarBlister(id);
                    break;
                case 3:
                    CarcasaNeg carcasa = new CarcasaNeg();
                    carcasa.eliminarCarcasa(id);
                    break;
                case 4:
                    CartonNeg carton = new CartonNeg();
                    carton.eliminarCarton(id);
                    break;
                case 5:
                    PitonNeg piton = new PitonNeg();
                    piton.eliminarPiton(id);
                    break;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnColorUpdate?.Invoke(this, EventArgs.Empty);
            Close();
        }
        private void frmStockInsumos_Shown(object sender, EventArgs e)
        {            
            tbInsumos.SelectTab(1);
            tbInsumos.SelectTab(0);
        }
        private void frmStockInsumos_ActualizarDgv (object sender, EventArgs e)
        {
            cargarDgvs();
            formatoDgvs();
            tbInsumos.Refresh();
        }
    }
}
