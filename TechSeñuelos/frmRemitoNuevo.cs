using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace TechSeñuelos
{
    public partial class frmRemitoNuevo : Form
    {
        private RemitoNeg nuevoRem = new RemitoNeg();
        private List<Armado> armados;
        private List<Armado> armadoConCodigo = new List<Armado>();
        private Dictionary<int, string> codigos = new Dictionary<int, string>();

        public frmRemitoNuevo()
        {
            InitializeComponent();

            dgvRemito.CellValidating += dgvRemito_CellValidating;
            dgvRemito.CellEndEdit += dgvRemito_CellEndEdit;
            FormClosing += cerrarFrm;
        }
        private void frmRemitoNuevo_Load(object sender, EventArgs e)
        {
            RemitoNeg nuevo = new RemitoNeg();

            int nroRemitoActual = nuevo.obtProxRem();
            lblNroRem.Text = nroRemitoActual.ToString();

            cboDestino();
            detalle(nroRemitoActual);

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            btnContinuar.Enabled = false;

            cboDestinoRem.Enabled = true;
            cboDestinoRem.SelectedIndex = -1; //muesta el cbo en blanco por defecto
        }
        private void btnAddDest_Click(object sender, EventArgs e)
        {
            string dest = cboDestinoRem.Text.ToUpper().Trim();
            int num = int.Parse(lblNroRem.Text);
            DateTime fecha = DateTime.Today;

            if (string.IsNullOrEmpty(dest))
            {
                MessageBox.Show("Debe ingresar un destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nuevoRem.addDestiNro(dest, num, fecha);

            cboDestino();
            detalle(num);

            btnAddDest.Enabled = false;
            btnAgregar.Enabled = true;
            btnAgregar.Focus();
            btnEliminar.Enabled = true;
            btnEliminarTodo.Enabled = true;
            btnContinuar.Enabled = true;
            cboDestinoRem.SelectedValue = dest;
            cboDestinoRem.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSelexLure elegir = new frmSelexLure();
            elegir.AgregarUpd += FrmSelexLure_AgregarUpd;
            elegir.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (dgvRemito.RowCount > 0)
            {
                if (MessageBox.Show("Quiere reutilizar el remito?", "Eliminar todo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ArmadoNeg armado = new ArmadoNeg();
                    RemitoNeg remito = new RemitoNeg();

                    int remitoActual = int.Parse(lblNroRem.Text);
                    int idRemito = remito.obtenerId(remitoActual);

                    armado.reutilizar(idRemito);
                    detalle(remitoActual);

                    StandarSuplente.suplentes.Clear();
                    armadoConCodigo.Clear();

                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnEliminarTodo.Enabled = true;
                    btnAddDest.Enabled = false;
                }
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (dgvRemito.Rows.Count > 0)
            {
                int rto = int.Parse(lblNroRem.Text);
                frmInsumos insumos = new frmInsumos(rto);
                insumos.ShowDialog();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            StandarSuplente.suplentes.Clear();
            Close();
        }
        private void FrmSelexLure_AgregarUpd(object sender, EventArgs e)
        {
            int remito = int.Parse(lblNroRem.Text);
            int? indiceQ = 0;

            detalle(remito);
            dgvRemito.Refresh();

            if (armadoConCodigo.Count < 1)
            {
                armadoConCodigo.Add(armados[0]);
                armadoConCodigo[0].codArmado = new List<int>();
            }
            else if (armadoConCodigo.Count == armados.Count)
            {
                for (int x = 0; x < armadoConCodigo.Count; x++)
                {
                    if (armadoConCodigo[x].Cantidad != armados[x].Cantidad)
                    {
                        armadoConCodigo[x].Cantidad = armados[x].Cantidad;
                        indiceQ = x;
                        break;
                    }
                }
            }
            else
            {
                armadoConCodigo.Add(armados.Last());
                armadoConCodigo[armadoConCodigo.Count - 1].codArmado = new List<int>();
                indiceQ = null;
            }

            foreach (Standar item in StandarSuplente.suplentes)
            {
                if (!codigos.Any(x => x.Key == item.codigoArmado))
                {
                    codigos.Add(item.codigoArmado, item.Modelo);

                    for (int i = 0; i < armadoConCodigo.Count; i++)
                    {
                        bool control = false;

                        if (armadoConCodigo[i].Artificial.Modelo == armados.Last().Artificial.Modelo && armadoConCodigo[i].Color.Modelo == armados.Last().Color.Modelo)
                        {
                            if (indiceQ != null)
                            {
                                armadoConCodigo[(int)indiceQ].codArmado.Add(item.codigoArmado);
                            }
                            else
                            {
                                armadoConCodigo[i].codArmado.Add(item.codigoArmado);
                            }

                            control = true;
                        }
                        else if (control)
                        {
                            armadoConCodigo.Last().codArmado.Add(item.codigoArmado);
                        }
                    }
                }
            }
        }
        private void dgvRemito_CellValueChanged(object sender, DataGridViewCellEventArgs e) //evento para editar cantidad dentro del dgvRemito
        {
            ArmadoNeg armado = new ArmadoNeg();

            int cantidadIndex = dgvRemito.Columns["Cantidad"].Index;
            int idIndex = dgvRemito.Columns["Id"].Index;
            int fila = e.RowIndex;
            int celda = e.ColumnIndex;

            if (celda == cantidadIndex && fila >= 0)
            {
                DataGridViewCell celdaCantidad = dgvRemito.Rows[fila].Cells[celda];
                int cantUpd;
                Armado seleccion = armadoConCodigo[fila];
                List<int> codigos = seleccion.codArmado;
                //codigos.Sort((x,y) => string.Compare(y.ToString(), x.ToString()));

                if (celdaCantidad.Value != null && int.TryParse(celdaCantidad.Value.ToString(), out cantUpd))
                {
                    int id = (int)dgvRemito.Rows[fila].Cells[idIndex].Value;
                    List<Standar> lista = StandarSuplente.suplentes;

                    armado.modificarCant(id, cantUpd);

                    if (seleccion.Cantidad < cantUpd)
                    {
                        int total = cantUpd - seleccion.Cantidad;
                        lista[lista.FindIndex(x => x.codigoArmado == seleccion.codArmado[0])].Cantidad += total;
                        seleccion.Cantidad = cantUpd;
                    }
                    else if (seleccion.Cantidad > cantUpd)
                    {
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (codigos.Contains(lista[i].codigoArmado))
                            {
                                if ((seleccion.Cantidad - lista[i].Cantidad) >= cantUpd)
                                {
                                    seleccion.Cantidad -= lista[i].Cantidad;
                                    seleccion.codArmado.Remove(lista[i].codigoArmado);
                                    lista.RemoveAt(i);
                                    i--;
                                }
                                else
                                {
                                    lista[i].Cantidad = cantUpd;
                                    seleccion.Cantidad = cantUpd;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
         }
        private void dgvRemito_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)//Ingresar solo números en la celda Cantidad
        {
            if (dgvRemito.Columns[e.ColumnIndex].Name == "Cantidad" && e.FormattedValue.ToString() != "")
            {
                int cantidad;
                if (!int.TryParse(e.FormattedValue.ToString(), out cantidad))
                {
                    dgvRemito.Rows[e.RowIndex].ErrorText = "Sólo números";
                    e.Cancel = true;
                    MessageBox.Show("El valor debe ser sólo numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvRemito_CellEndEdit(object sender, DataGridViewCellEventArgs e)//Limpia el mensaje de error
        {
            dgvRemito.Rows[e.RowIndex].ErrorText = string.Empty;
        }
        public void diseColumnas()//diseño de columnas
        {
            dgvRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRemito.Columns["Id"].Visible = false;
            dgvRemito.Columns["Remito"].Visible = false;
            dgvRemito.Columns["Cantidad"].ReadOnly = false;
            dgvRemito.Columns["Color"].ReadOnly = true;
            dgvRemito.Columns["Artificial"].ReadOnly = true;
        }
        public void detalle(int remito)//Detalles remito nuevo
        {
            ArmadoNeg negocio = new ArmadoNeg();
            //int rtoActual = remito;
            try
            {
                armados = negocio.detalleRemito(remito);
                dgvRemito.DataSource = armados;
                diseColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void eliminar()
        {
            ArmadoNeg negocio = new ArmadoNeg();
            Armado seleccion;
            int remito = int.Parse(lblNroRem.Text);

            try
            {
                if (MessageBox.Show("Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //Aca deberia saber si lo que deberia borrar lleva anzuelos simples o triples, de acuerdo la decision del usuario...
                    if (dgvRemito.CurrentRow != null)
                    {
                        seleccion = (Armado)dgvRemito.CurrentRow.DataBoundItem;
                        int indiceSeleccion = dgvRemito.CurrentRow.Index;
                        seleccion.codArmado = armadoConCodigo[indiceSeleccion].codArmado;

                        foreach (int code in seleccion.codArmado)
                        {
                            for (int x = 0; x < StandarSuplente.suplentes.Count; x++)
                            {
                                if (StandarSuplente.suplentes[x].codigoArmado == code)
                                {
                                    StandarSuplente.suplentes.RemoveAt(x);
                                    break;
                                }
                            }
                        }
                        armadoConCodigo.RemoveAt(indiceSeleccion);
                        negocio.eliminar(seleccion.Id);
                        detalle(remito);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cboDestino() //Carga destinos preexistentes
        {
            try
            {
                cboDestinoRem.DataSource = new RemitoNeg().cboDestino();
                cboDestinoRem.ValueMember = "Destino";
                cboDestinoRem.DisplayMember = "Destino";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cerrarFrm(object sender, FormClosingEventArgs e)//evento cuando se cierra este formulario
        {
            cerrarCheck();
        }
        private void cerrarCheck()
        {
            RemitoNeg remito = new RemitoNeg();
            int rto = int.Parse(lblNroRem.Text);


            if (remito.existe(rto))
            {
                if (dgvRemito.RowCount == 0)
                {
                    remito.eliminarRemito(rto);
                }
            }
        }
        private void descontarStock()
        {
            //dejar esto para más adelante...
        }
    }
}
