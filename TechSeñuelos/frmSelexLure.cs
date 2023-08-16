using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private Standar suplenteRec = null; //para el suplente que viene de frmPersonalizar

        public event EventHandler AgregarUpd;//evento para actualizar dgvRemito

        public event EventHandler FormClosedEvent;//acciones luego de cerrar este form

        //private void frmPersonalizar_pasarSuplente(object sender, EventArgs e)
        //{
        //    StandarSuplente.suplentes.Add(suplente);
        //}
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        public frmSelexLure()
        {
            InitializeComponent();
        }        

        private void frmSelexLure_Load(object sender, EventArgs e)
        {
            cargaCbos();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string artificial = cboArtificialNR.SelectedValue.ToString();
            string color = cboColorNR.SelectedValue.ToString();
            int cantidad = int.Parse(txtCantidad.Text);
            bool optAnz = rbTriple.Checked;
            
            ArmadoNeg armado = new ArmadoNeg();
            armado.nuevoRemArmado(artificial, color, cantidad);

            Standar suplenteNoMod = new Standar();
            StandarNeg negocioSupl = new StandarNeg();

            if (suplenteRec != null)
            {
                if (rbTriple.Checked)//hacer metodo
                    suplenteRec.AnzSimple.Numero = null;
                else
                    suplenteRec.AnzTriple.Numero = null;
                
                suplenteRec.Cantidad = cantidad;
                StandarSuplente.suplentes.Add(suplenteRec);
            }
            else
            {
                suplenteNoMod = negocioSupl.personalizar(artificial,cantidad);

                if(optAnz)//hacer en un metodo
                {
                    suplenteNoMod.AnzSimple.Numero = null;
                    if (suplenteNoMod.AnzTriple.Numero == "0")
                    {
                        if (MessageBox.Show("Por defecto, este señuelo no lleva triples...¿Personalizar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Standar standar;
                            StandarNeg negocio = new StandarNeg();

                            standar = negocio.personalizar(artificial);
                            string imagen = negocio.obtImg(color, artificial);

                            frmPersonalizar custom = new frmPersonalizar(standar, optAnz, imagen);
                            custom.ShowDialog();

                            if (custom.suplente != null)
                            {
                                suplenteRec = custom.suplente;
                                suplenteRec.Cantidad = cantidad;
                                suplenteNoMod = suplenteRec;
                            }
                        }
                        else
                        {
                            suplenteNoMod.AnzTriple.Numero = null;
                        }
                    }
                }
                else
                {
                    suplenteNoMod.AnzTriple.Numero = null;
                    if (suplenteNoMod.AnzSimple.Numero == "0")
                    {
                        if (MessageBox.Show("Por defecto, este señuelo no lleva simples...¿Personalizar?","Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Standar standar;
                            StandarNeg negocio = new StandarNeg();

                            standar = negocio.personalizar(artificial);
                            string imagen = negocio.obtImg(color, artificial);

                            frmPersonalizar custom = new frmPersonalizar(standar, optAnz, imagen);
                            custom.ShowDialog();

                            if (custom.suplente != null)
                            {
                                suplenteRec = custom.suplente;
                                suplenteRec.Cantidad = cantidad;
                                suplenteNoMod = suplenteRec;
                            }
                        }
                        else
                        {
                            suplenteNoMod.AnzSimple.Numero = null;
                        }
                    }
                }

                if (suplenteNoMod.AnillaAnz.Tamaño == "0")
                    suplenteNoMod.AnillaAnz.Tamaño = "No lleva";

                if (suplenteNoMod.AnillaPal.Tamaño == "0")
                    suplenteNoMod.AnillaPal.Tamaño = "No lleva";

                StandarSuplente.suplentes.Add(suplenteNoMod);
            }

            AgregarUpd?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Agregado exitosamente!","Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);

            suplenteRec = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (suplenteRec  != null)
            {
                
                if(MessageBox.Show("¿Esta seguro que desea terminar? Hay un señuelo modificado", "Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    suplenteRec = null;
                    Close();
                }
                else
                {
                    return;
                }
            }                        
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)//Se pasa como parámetro el objeto al frmPersonalizar
        {
            string mod = cboArtificialNR.SelectedValue.ToString();
            string col = cboColorNR.SelectedValue.ToString();
            bool anz = rbTriple.Checked;

            Standar standar;
            StandarNeg negocio = new StandarNeg();

            standar = negocio.personalizar(mod);
            string imagen = negocio.obtImg(col,mod);

            frmPersonalizar custom = new frmPersonalizar(standar, anz, imagen);
            custom.ShowDialog();

            if(custom.suplente != null)
            {
                suplenteRec = custom.suplente;
            }
        }
    }
}
