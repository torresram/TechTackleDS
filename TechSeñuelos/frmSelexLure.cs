using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmSelexLure : Form
    {
        //private Armado armado = null;

        private Standar suplenteRecibido = null; //para el suplente que viene de frmPersonalizar
        public event EventHandler AgregarUpd;//evento para actualizar dgvRemito
        public event EventHandler FormClosedEvent;//acciones luego de cerrar este form
        int idArm = 0;
        
        public frmSelexLure()
        {
            InitializeComponent();
        }
        private void frmSelexLure_Load(object sender, EventArgs e)
        {
            cargaCbos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArmadoNeg armado = new ArmadoNeg();

            if (!soloNumeros(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar sólo números en el campo Cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string artificial = cboArtificialNR.SelectedValue.ToString();
            string color = cboColorNR.SelectedValue.ToString();
            int cantidad = int.Parse(txtCantidad.Text);
            bool tipoAnzuelo = rbTriple.Checked;
            int idStd;

            try
            {
                Standar suplenteNoMod = new Standar();
                StandarNeg negocioSupl = new StandarNeg();

                if (suplenteRecibido != null)
                {
                    if (tipoAnzuelo)
                    {
                        suplenteRecibido.AnzSimple.Numero = null;
                    }
                    else
                    {
                        suplenteRecibido.AnzTriple.Numero = null;
                    }

                    suplenteRecibido.tipoAnzuelo = tipoAnzuelo;
                    suplenteRecibido.Cantidad = cantidad;

                    idArm++;
                    idStd = suplenteRecibido.Id;
                    suplenteRecibido.codigoArmado = generarCodigo(idArm, idStd);
                    StandarSuplente.suplentes.Add(suplenteRecibido);
                }
                else
                {
                    suplenteNoMod = negocioSupl.personalizar(artificial, cantidad);
                    suplenteNoMod.tipoAnzuelo = tipoAnzuelo;

                    if (tipoAnzuelo)//hacer en un metodo
                    {
                        suplenteNoMod.AnzSimple.Numero = null;

                        if (suplenteNoMod.AnzTriple.Numero.ToUpper() == "NO LLEVA")
                        {
                            if (MessageBox.Show("Por defecto, este señuelo no lleva triples...¿Personalizar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Standar standar;
                                StandarNeg negocio = new StandarNeg();

                                standar = negocio.personalizar(artificial);
                                string imagen = negocio.obtImg(color, artificial);

                                frmPersonalizar custom = new frmPersonalizar(standar, tipoAnzuelo, imagen);
                                custom.ShowDialog();

                                if (custom.suplente != null)
                                {
                                    suplenteRecibido = custom.suplente;
                                    suplenteRecibido.Cantidad = cantidad;
                                    suplenteNoMod = suplenteRecibido;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        suplenteNoMod.AnzTriple.Numero = null;

                        if (suplenteNoMod.AnzSimple.Numero.ToUpper() == "NO LLEVA")
                        {
                            if (MessageBox.Show("Por defecto, este señuelo no lleva simples...¿Personalizar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Standar standar;
                                StandarNeg negocio = new StandarNeg();

                                standar = negocio.personalizar(artificial);
                                string imagen = negocio.obtImg(color, artificial);

                                frmPersonalizar custom = new frmPersonalizar(standar, tipoAnzuelo, imagen);
                                custom.ShowDialog();

                                if (custom.suplente != null)
                                {
                                    suplenteRecibido = custom.suplente;
                                    suplenteRecibido.Cantidad = cantidad;
                                    suplenteNoMod = suplenteRecibido;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    if (suplenteNoMod.AnillaAnz.Tamaño == "0")
                    {
                        suplenteNoMod.AnillaAnz.Tamaño = "No lleva";
                    }

                    if (suplenteNoMod.AnillaPal.Tamaño == "0")
                    {
                        suplenteNoMod.AnillaPal.Tamaño = "No lleva";
                    }

                    idArm++;
                    idStd = suplenteNoMod.Id;
                    suplenteNoMod.codigoArmado = generarCodigo(idArm, idStd);
                    StandarSuplente.suplentes.Add(suplenteNoMod);
                }

                armado.nuevoRemArmado(artificial, color, cantidad);
                AgregarUpd?.Invoke(this, EventArgs.Empty);
                suplenteRecibido = null;
                MessageBox.Show("¡Agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("El señuelo solicitado no se encuentra en la lista.\nAgreguelo antes de continuar", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e) //Se pasa como parámetro el objeto al frmPersonalizar
        {
            string mod = cboArtificialNR.SelectedValue.ToString();
            string col = cboColorNR.SelectedValue.ToString();
            bool anz = rbTriple.Checked;

            Standar standar;
            StandarNeg negocio = new StandarNeg();

            standar = negocio.personalizar(mod);
            string imagen = negocio.obtImg(col, mod);

            frmPersonalizar custom = new frmPersonalizar(standar, anz, imagen);
            custom.ShowDialog();

            if (custom.suplente != null)
            {
                suplenteRecibido = custom.suplente;
            }
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (suplenteRecibido != null)
            {
                if (MessageBox.Show("¿Esta seguro que desea terminar? Hay un señuelo modificado", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    suplenteRecibido = null;
                    Close();
                }
                else
                {
                    return;
                }
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }
        private bool chkLista(Standar suplente)
        {
            foreach (Standar standar in StandarSuplente.suplentes)
            {
                if (standar.Modelo.ToString() == suplente.Modelo.ToString())
                {
                    if (standar.AnzSimple.ToString() == suplente.AnzSimple.ToString() && standar.AnzTriple.ToString() == suplente.AnzTriple.ToString() && standar.AnillaAnz.ToString() == suplente.AnillaAnz.ToString() && standar.AnillaPal.ToString() == suplente.AnillaPal.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void addSuplenteRepetido(Standar suplente)
        {
            List<Standar> lista = StandarSuplente.suplentes;

            int index = lista.FindIndex(item => item.Modelo == suplente.Modelo && item.AnzSimple.ToString() == suplente.AnzSimple.ToString() && item.AnzTriple.ToString() == suplente.AnzTriple.ToString() && item.AnillaPal.ToString() == suplente.AnillaPal.ToString() && item.AnillaAnz.ToString() == suplente.AnillaAnz.ToString());

            if (index != -1)
            {
                lista[index].Cantidad += int.Parse(txtCantidad.Text);
            }
        }
        private void cargaCbos()
        {
            ArtificialNeg lure = new ArtificialNeg();
            ColorNeg color = new ColorNeg();

            try
            {
                cboArtificialNR.DataSource = lure.cboArtificial();
                cboArtificialNR.ValueMember = "Modelo";
                cboArtificialNR.DisplayMember = "Modelo";

                cboColorNR.DataSource = color.cboColores();
                cboColorNR.ValueMember = "Modelo";
                cboColorNR.DisplayMember = "Modelo";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool soloNumeros(string cadena) //mover a una clase general porque lo voy a usar varias veces, creo
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                {
                    return false;
                }
            }
            return true;
        }
        private void cboArtificialNR_SelectedValueChanged(object sender, EventArgs e)
        {
            StandarNeg negocio = new StandarNeg();
            Standar modelo = new Standar();
            int idSeleccion = cboArtificialNR.SelectedIndex;
            List<Standar> lista = new List<Standar>();
            lista = negocio.listar();
            //lista.Sort((x, y) => string.Compare(x.Modelo, y.Modelo));

            modelo = lista[idSeleccion];
            rbSimple.Text = "Simples (" + modelo.AnzSimple + ")";
            rbTriple.Text = "Triples (" + modelo.AnzTriple + ")";
        }
        private int generarCodigo(int idArm, int idStd)
        {
            Random random = new Random();
            int codigoFinal;
            int num = random.Next(10, 100);

            string cadenaCodigo;

            cadenaCodigo = idArm.ToString() + num.ToString() + idStd;
            codigoFinal = int.Parse(cadenaCodigo);

            return codigoFinal;
        }
    }
}
