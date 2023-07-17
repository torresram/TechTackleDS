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

        public event EventHandler AgregarUpd;//evento para actualizar dgvRemito

        public event EventHandler FormClosedEvent;//acciones luego de cerrar este form
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

            ArmadoNeg armado = new ArmadoNeg();
            armado.nuevoRemArmado(artificial, color, cantidad);

            AgregarUpd?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Agregado exitosamente!","Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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
        }
    }
}
