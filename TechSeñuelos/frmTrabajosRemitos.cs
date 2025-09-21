using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmTrabajosRemitos : Form

    {
        private TrabajosNeg nuevoRemito = new TrabajosNeg();
        private Talonarios tarea = new Talonarios();
        private string talonario, destino, numero;
        private int NroRemitoActual, cantidad, modelo;
        private DateTime fecha = DateTime.Now.Date;
        public event EventHandler actualizarProduccion;
        private bool closeCheck = false;

        public frmTrabajosRemitos(string talonario)
        {
            InitializeComponent();
            this.talonario = talonario;
            Text = talonario.ToUpper() + "...";
            FormClosing += cerrarFrm;
        }
        private void frmTrabajosRemitos_Load(object sender, EventArgs e)
        {
            TalonariosNeg nuevo = new TalonariosNeg();
            tarea = nuevo.listarUnico(talonario);
            modelo = 0;
            cantidad = 0;

            NroRemitoActual = tarea.UltimoRemito + 1;
            lblNroRem.Text = tarea.Prefijo + "-" + NroRemitoActual.ToString("D5");
            numero = lblNroRem.Text.Trim();

            cboDestino();
            cboModeloLoad();
            detalle(numero, talonario);

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            btnContinuar.Enabled = false;

            cboDestinoRem.Enabled = true;
            cboDestinoRem.SelectedIndex = -1; //muesta el cbo en blanco por defecto
        }
        private void cboDestino() //Carga destinos preexistentes
        {
            try
            {
                cboDestinoRem.DataSource = new TrabajosNeg().cboDestino();
                cboDestinoRem.ValueMember = "Destino";
                cboDestinoRem.DisplayMember = "Destino";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void detalle(string remito, string talonario) //Detalles remito nuevo
        {
            TrabajosNeg negocio = new TrabajosNeg();

            try
            {
                List<TrabajosRemitos> trabajo = negocio.detalleTrabajo(remito, talonario);
                dgvRemito.DataSource = trabajo;
                diseColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void diseColumnas()//diseño de columnas
        {
            dgvRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRemito.Columns["Id"].Visible = false;
            dgvRemito.Columns["Talonario"].Visible = false;
            dgvRemito.Columns["Destino"].Visible = false;
            dgvRemito.Columns["FechaCreacion"].Visible = false;
            dgvRemito.Columns["Numero"].Visible = false;
            dgvRemito.Columns["Cantidad"].ReadOnly = false;
            dgvRemito.Columns["Produccion"].ReadOnly = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Size = new Size(875, Height);
        }
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Size = new Size(616, Height);
            txtCantidad.Text = "Cantidad...";
            cboModelo.SelectedIndex = -1;
            cboModelo.Text = "Modelos...";
        }
        private void btnAddDest_Click(object sender, EventArgs e)
        {
            destino = cboDestinoRem.Text.ToUpper().Trim();

            if (string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Debe ingresar un destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nuevoRemito.nuevoRemito(numero, fecha, tarea, cantidad, modelo);
            nuevoRemito.cargarDestino(destino, numero);
            cboDestino();

            btnAddDest.Enabled = false;
            btnAgregar.Enabled = true;
            btnAgregar.Focus();
            btnEliminar.Enabled = true;
            btnEliminarTodo.Enabled = true;
            btnContinuar.Enabled = true;
            cboDestinoRem.SelectedValue = destino;
            cboDestinoRem.Enabled = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    TrabajosRemitos seleccion = (TrabajosRemitos)dgvRemito.CurrentRow.DataBoundItem;
                    nuevoRemito.eliminarTrabajo(seleccion.Id);
                }
                else
                {
                    return;
                }

                detalle(numero, talonario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboModelo.SelectedItem != null)
            {
                Produccion selex = (Produccion)cboModelo.SelectedValue;
                modelo = selex.Id;
            }
            else
            {
                MessageBox.Show("Debe elegir un modelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                if (!int.TryParse(txtCantidad.Text, out cantidad))
                {
                    MessageBox.Show("Debe ingresar sólo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvRemito.RowCount < 1)
            {
                nuevoRemito.actualizarTrabajo(numero, cantidad, modelo);
            }
            else
            {
                List<TrabajosRemitos> existentes = nuevoRemito.detalleTrabajo(numero, talonario);
                var coincide = existentes.FirstOrDefault(x => x.Produccion.Id == modelo);

                if (coincide != null)
                {
                    cantidad += coincide.Cantidad;
                    nuevoRemito.cantidadUpd(numero, cantidad, modelo);
                }
                else
                {
                    nuevoRemito.nuevoTrabajo(numero, fecha, tarea, cantidad, modelo, destino);
                }
            }

            detalle(lblNroRem.Text, talonario);
            diseColumnas();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //añadir ultimo al talonario
            //mandar a imprimir reporte
            //descontar del stock

            if (dgvRemito.RowCount > 0)
            {
                TalonariosNeg tlNegocio = new TalonariosNeg();
                tlNegocio.modificarUltimo(tarea.Id, NroRemitoActual);

                //lista de los trabajos del remito, pero cargando los datos en Producto
                List<Produccion> prods = new List<Produccion>();

                for (int i = 0; i < dgvRemito.RowCount; i++)
                {
                    TrabajosRemitos trabajo = (TrabajosRemitos)dgvRemito.Rows[i].DataBoundItem;
                    Produccion prod = new Produccion();
                    prod.Modelo = trabajo.Produccion.Modelo;
                    cantidad = trabajo.Cantidad;

                    switch (tarea.Prefijo)
                    {
                        case "A":
                            prod.Armados = cantidad;
                            break;
                        case "S":
                            prod.Soldados = cantidad;
                            break;
                        case "L":
                            prod.Lijados = cantidad;
                            break;
                    }

                    prods.Add(prod);
                }

                //modificacion tabla carcasas

                ProduccionNeg prodNegocio = new ProduccionNeg();
                Carcasa modificar = new Carcasa();
                CarcasaNeg carcasaNeg = new CarcasaNeg();
                List<Produccion> existentes = prodNegocio.listar();

                foreach (Produccion item in existentes)
                {
                    var coincide = prods.FirstOrDefault(prod => prod.Modelo == item.Modelo);
                    bool armadoFlag = false;

                    if (coincide != null)
                    {
                        if (coincide.Armados > 0)
                        {
                            item.Carcasas -= coincide.Armados;
                            item.Armados += coincide.Armados;
                            armadoFlag = true;
                        }
                        if (coincide.Soldados > 0)
                        {
                            item.Armados -= coincide.Soldados;
                            item.Soldados += coincide.Soldados;
                        }
                        if (coincide.Lijados > 0)
                        {
                            item.Soldados -= coincide.Lijados;
                            item.Lijados += coincide.Lijados;
                        }

                        if (armadoFlag == true)
                        {
                            modificar.Modelo = item.Modelo;
                            modificar.Cantidad = item.Carcasas;
                            carcasaNeg.modificarCarcasaProd(modificar);
                        }

                        prodNegocio.actualizarValor(item);
                    }
                }

                if (MessageBox.Show("¿Desea imprimir el reporte?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmReporte reporte = new frmReporte(numero, talonario);
                    reporte.ShowDialog();
                }

                closeCheck = true;
                actualizarProduccion?.Invoke(this, EventArgs.Empty);
                Close(); //Deberia cerrar el formulario?
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                txtCantidad.Text = "Cantidad...";
            }
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (dgvRemito.RowCount > 0)
            {
                if (MessageBox.Show("Quiere reutilizar el remito?", "Eliminar todo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TalonariosNeg tlNegocio = new TalonariosNeg();
                    TrabajosRemitos trabajo = new TrabajosRemitos();

                    nuevoRemito.reutilizar(numero);

                    NroRemitoActual = NroRemitoActual - 1;
                    tlNegocio.modificarUltimo(tarea.Id, NroRemitoActual);

                    detalle(numero, talonario);
                }
            }
        }
        private void dgvRemito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TrabajosNeg trabajo = new TrabajosNeg();

            int cantidadIndex = dgvRemito.Columns["Cantidad"].Index;
            int idIndex = dgvRemito.Columns["Id"].Index;
            int fila = e.RowIndex;
            int celda = e.ColumnIndex;

            if (celda == cantidadIndex && fila >= 0)
            {
                DataGridViewCell celdaCantidad = dgvRemito.Rows[fila].Cells[celda];

                if (celdaCantidad.Value != null && int.TryParse(celdaCantidad.Value.ToString(), out int cantUpd))
                {
                    int id = (int)dgvRemito.Rows[fila].Cells[idIndex].Value;
                    trabajo.modificarCant(id, cantUpd);
                }
            }
        }
        private void dgvRemito_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvRemito.Columns[e.ColumnIndex].Name == "Cantidad" && e.FormattedValue.ToString() != "")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad))
                {
                    dgvRemito.Rows[e.RowIndex].ErrorText = "Sólo números";
                    e.Cancel = true;
                    MessageBox.Show("El valor debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvRemito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvRemito.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void cboModeloLoad()
        {
            try
            {
                ProduccionNeg prod = new ProduccionNeg();
                cboModelo.DataSource = prod.obtModelo();
                cboModelo.SelectedIndex = -1;
                cboModelo.Text = "Modelos...";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cerrarFrm(object sender, FormClosingEventArgs e)
        {
            cerrarCheck();
        }
        private void cerrarCheck()
        {
            if (dgvRemito.RowCount == 0 || closeCheck == false)
            {
                nuevoRemito.reutilizar(numero);
            }
        }
    }
}
