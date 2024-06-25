using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmInsumos : Form
    {
        private int cantidadSeñuelos { get; set; }
        private List<Insumos> insumos;
        private List<Armado> remito;
        private int remitoNro;

        public frmInsumos(int remitoNro)
        {
            InitializeComponent();
            this.remitoNro = remitoNro;
            cargaRemito();
        }
        private void frmInsumos_Load(object sender, EventArgs e)
        {
            insumos = preparadoInsumos();
            //insumos = buscarPeso(insumos);
            lblCantTotal.Text = "TOTAL: " + cantidadSeñuelos.ToString();
            formatoDgvInsumos();
        }
        private List<Insumos> preparadoInsumos()
        {
            List<Insumos> items = new List<Insumos>();
            List<Standar> lista;
            lista = StandarSuplente.suplentes;

            int contadorId = 1; // Variable contador para asignar el Id único

            foreach (Standar supl in lista)
            {
                int cantidad = supl.Cantidad;
                foreach (var prop in typeof(Standar).GetProperties())
                {
                    string[] propFiltradas = { "AnillaAnz", "AnillaPal", "AnzSimple", "AnzTriple", "Blister", "Carton", "Cantidad" };
                    string propiedad = prop.Name;
                    int cantFinal = cantidad;
                    if (propFiltradas.Contains(propiedad))
                    {
                        object valorProp = prop.GetValue(supl).ToString();
                        Insumos insumos = new Insumos();
                        insumos.Id = contadorId; //Asignamos el Id único
                        insumos.Familia = propiedad;
                        string[] dobleCantidad = { "AnillaAnz", "AnzSimple", "AnzTriple" };

                        if (dobleCantidad.Contains(propiedad))
                        {
                            cantFinal = cantidad * 2;
                        }

                        if (propiedad == "Cantidad")
                        {
                            //insumos.Item = prop.Name;
                            insumos.Cantidad = int.Parse((string)valorProp);
                            cantidadSeñuelos += insumos.Cantidad;
                        }
                        else
                        {
                            insumos.Item = valorProp == null || valorProp.ToString().ToUpper() == "NO LLEVA" ? "VACIO" : valorProp.ToString();
                            insumos.Cantidad = cantFinal;
                        }

                        if (items.Any(i => i.Item == insumos.Item))
                        {
                            // Si el insumo ya existe, sumamos la cantidad
                            var insumoExistente = items.First(i => i.Item == insumos.Item);
                            insumoExistente.Cantidad += cantFinal;
                        }
                        else
                        {
                            // Si el insumo no existe, lo agregamos a la lista
                            if (!(insumos.Item == "VACIO"))
                            {
                                if (!(insumos.Familia == "Cantidad"))
                                {
                                    items.Add(insumos);
                                }
                            }
                        }
                        contadorId++; // Incrementamos el contador del Id
                    }
                }
            }
            items.Sort((item1, item2) => item1.Familia.CompareTo(item2.Familia));
            items = buscarPeso(items);
            items = cambioFamilia(items);
            return items;
        }
        private List<Insumos> buscarPeso(List<Insumos> lista)
        {
            double peso;
            for (int x = 0; x < lista.Count; x++)
            {
                string familia = lista[x].Familia;
                string item = lista[x].Item;
                int cantidad = lista[x].Cantidad;
                string tabla;
                string columna;
                string arroba;

                if (familia == "AnzSimple" || familia == "AnzTriple")
                {
                    tabla = "Anzuelo";
                    columna = "Numero";
                    arroba = "@numero";
                    peso = cargarPeso(tabla, columna, arroba, item);

                    lista[x].Peso = peso * cantidad;
                }

                if (familia == "AnillaAnz" || familia == "AnillaPal")
                {
                    tabla = "Anilla";
                    columna = "Tamaño";
                    arroba = "@tamaño";
                    peso = cargarPeso(tabla, columna, arroba, item);

                    lista[x].Peso = peso * cantidad;
                }

                if (familia == "Blister")
                {
                    tabla = familia;
                    columna = "Modelo";
                    arroba = "@modelo";
                    peso = cargarPeso(tabla, columna, arroba, item);

                    lista[x].Peso = peso * cantidad;
                }

                if (familia == "Carton")
                {
                    tabla = familia;
                    columna = "Modelo";
                    arroba = "@modelo";
                    peso = cargarPeso(tabla, columna, arroba, item);

                    lista[x].Peso = peso * cantidad;
                }
            }
            return lista;
        }
        private List<Insumos> cambioFamilia(List<Insumos> lista)
        {
            for (int x = 0; x < lista.Count; x++)
            {
                if (lista[x].Familia == "AnillaAnz" || lista[x].Familia == "AnillaPal")
                {
                    lista[x].Familia = "Anillas";
                }

                if (lista[x].Familia == "AnzSimple")
                {
                    lista[x].Familia = "Simples";
                }

                if (lista[x].Familia == "AnzTriple")
                {
                    lista[x].Familia = "Triples";
                }
            }
            return lista;
        }
        private double cargarPeso(string tabla, string columna, string arroba, string item)
        {
            AccesoDatos datos = new AccesoDatos();
            double peso;
            string consulta = "SELECT Peso FROM " + tabla + " WHERE " + columna + " = " + arroba + "";
            try
            {
                datos.setConsulta(consulta);
                datos.setParametro(arroba, item);
                datos.ejecLectura();
                datos.Lector.Read();

                peso = (double)datos.Lector["Peso"];

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

            return peso;
        }
        private void cargaRemito()
        {
            ArmadoNeg negocio = new ArmadoNeg();
            //int rtoActual = remito;
            try
            {
                remito = negocio.detalleRemito(remitoNro);
                dgvRemito.DataSource = remito;
                dgvRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRemito.Columns["Id"].Visible = false;
                dgvRemito.Columns["Remito"].Visible = false;
                dgvRemito.Columns["Cantidad"].ReadOnly = false;
                dgvRemito.Columns["Color"].ReadOnly = true;
                dgvRemito.Columns["Artificial"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void formatoDgvInsumos()
        {
            dgvInsumos.DataSource = insumos;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.Columns["Id"].Visible = false;
            dgvInsumos.Columns["Item"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInsumos.Columns["Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInsumos.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInsumos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInsumos.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInsumos.Columns["Peso"].DefaultCellStyle.Format = "0gr";
            dgvInsumos.Columns["Peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (tabPreparado.SelectedTab == tabInsumos)
            {
                frmReporte reporte = new frmReporte(insumos);
                reporte.ShowDialog();
            }
            else
            {
                frmReporte reporte = new frmReporte(remito, remitoNro);
                reporte.ShowDialog();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
