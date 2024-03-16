using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechSeñuelos
{
    public partial class frmRemitoNuevo : Form
    {
        private RemitoNeg nuevoRem = new RemitoNeg();
        private List<Armado> armados;

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

            cboDestinoRem.SelectedIndex = -1;//muesta el cbo en blanco por defecto
        }
        private void FrmSelexLure_AgregarUpd(object sender, EventArgs e)
        {
            int remito = int.Parse(lblNroRem.Text);
            detalle(remito);

            dgvRemito.Refresh();
        }
        //private void actualizar(object sender, EventArgs e)//reemplazado por otro metodo
        //{
        //    int remito = int.Parse(lblNroRem.Text);
        //    detalle(remito);
        //}
        private void dgvRemito_CellValueChanged(object sender, DataGridViewCellEventArgs e)//evento para editar cantidad dentro del dgvRemito
        {
            ArmadoNeg armado = new ArmadoNeg();

            int cantidadIndex = dgvRemito.Columns["Cantidad"].Index;
            int idIndex = dgvRemito.Columns["Id"].Index;

            if (e.ColumnIndex == cantidadIndex && e.RowIndex >= 0)
            {
                DataGridViewCell celdaCantidad = dgvRemito.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int cantUpd;

                if (celdaCantidad.Value != null && int.TryParse(celdaCantidad.Value.ToString(), out cantUpd))
                {
                    int id = (int)dgvRemito.Rows[e.RowIndex].Cells[idIndex].Value;
                    armado.modifCant(id, cantUpd);
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSelexLure elegir = new frmSelexLure();
            //elegir.FormClosedEvent += actualizar; reemplazado por el evento siguiente
            elegir.AgregarUpd += FrmSelexLure_AgregarUpd;
            elegir.ShowDialog();
        }
        private void btnAddDest_Click(object sender, EventArgs e)
        {
            string dest = cboDestinoRem.Text;
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
            btnEliminar.Enabled = true;
            btnEliminarTodo.Enabled = true;
            btnContinuar.Enabled = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if(dgvRemito.RowCount > 0)
            {
                if(MessageBox.Show("Quiere reutilizar el remito?","Eliminar todo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ArmadoNeg armado = new ArmadoNeg();
                    RemitoNeg remito = new RemitoNeg();

                    int remitoActual = int.Parse(lblNroRem.Text);
                    int idRemito = remito.obtenerId(remitoActual);

                    armado.reutilizar(idRemito);
                    detalle(remitoActual);

                    StandarSuplente.suplentes.Clear();

                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnEliminarTodo.Enabled = true;
                    btnContinuar.Enabled = false;
                    btnAddDest.Enabled = false;
                }
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int rto = int.Parse(lblNroRem.Text);
            frmInsumos insumos = new frmInsumos(rto);
            insumos.ShowDialog();
        }
        public void diseColumnas()//diseño de columnas
        {
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
                DialogResult eliminar = MessageBox.Show("Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (eliminar == DialogResult.Yes)
                {
                    seleccion = (Armado)dgvRemito.CurrentRow.DataBoundItem;
                    int indiceSelec = dgvRemito.CurrentRow.Index; 
                    negocio.eliminar(seleccion.Id);
                    detalle(remito);

                    StandarSuplente.suplentes.RemoveRange(indiceSelec,indiceSelec);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
        private void cboDestino() //Carga destinos preexistentes
        {
            RemitoNeg destino = new RemitoNeg();
            try
            {
                cboDestinoRem.DataSource = destino.cboDestino();
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

        }
    }
}
