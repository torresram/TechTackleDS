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
    public partial class frmNuevoStandar : Form
    {
        private List<string> modelos = new List<string>();
        private Standar standar = new Standar();
        public event EventHandler ActualizarNuevo;

        public frmNuevoStandar(Standar seleccion)
        {
            InitializeComponent();
            standar = seleccion;
            lblModelo.Text = seleccion.Modelo.ToUpper();
            cargarCbos();
        }

        private void frmNuevoStandar_Load(object sender, EventArgs e)
        {
            cboAniAnzuelo.SelectedValue = standar.AnillaAnz.Id;
            cboAniPaleta.SelectedValue = standar.AnillaPal.Id;
            cboAnzSimple.SelectedValue = standar.AnzSimple.Id;
            cboAnzTriple.SelectedValue = standar.AnzTriple.Id;
            cboBlister.SelectedValue = standar.Blister.Id;
            cboCarton.SelectedValue = standar.Carton.Id;
            cboPiton.SelectedValue = standar.Piton.Id;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StandarNeg negocio = new StandarNeg();

            if (MessageBox.Show("¿Guardar cambios?", "Guardar...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dictionary<string, int> valores = new Dictionary<string, int>()
                {
                    {"id", standar.Id},
                    {"aniPaleta", (int)cboAniPaleta.SelectedValue},
                    {"aniAnzuelo", (int)cboAniAnzuelo.SelectedValue},
                    {"anzSimple", (int)cboAnzSimple.SelectedValue},
                    {"anzTriple", (int)cboAnzTriple.SelectedValue},
                    {"blister", (int)cboBlister.SelectedValue},
                    {"carton", (int)cboCarton.SelectedValue},
                    {"piton", (int)cboPiton.SelectedValue},
                };

                negocio.modificarStandar(valores);
                ActualizarNuevo?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("¡Cambios guardados correctamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void cargarCbos()
        {
            StandarNeg anilla = new StandarNeg();
            StandarNeg anzuelo = new StandarNeg();
            StandarNeg blister = new StandarNeg();
            StandarNeg carton = new StandarNeg();
            StandarNeg piton = new StandarNeg();

            try
            {
                cboAniAnzuelo.DataSource = anilla.cboAnilla();
                cboAniAnzuelo.ValueMember = "id";
                cboAniAnzuelo.DisplayMember = "tamaño";

                cboAniPaleta.DataSource = anilla.cboAnilla();
                cboAniPaleta.ValueMember = "id";
                cboAniPaleta.DisplayMember = "tamaño";

                cboAnzSimple.DataSource = anzuelo.cboAnzuelo();
                cboAnzSimple.ValueMember = "id";
                cboAnzSimple.DisplayMember = "numero";

                cboAnzTriple.DataSource = anzuelo.cboAnzuelo();
                cboAnzTriple.ValueMember = "id";
                cboAnzTriple.DisplayMember = "numero";

                cboBlister.DataSource = blister.cboBlister();
                cboBlister.ValueMember = "id";
                cboBlister.DisplayMember = "modelo";

                cboCarton.DataSource = carton.cboCarton();
                cboCarton.ValueMember = "id";
                cboCarton.DisplayMember = "modelo";

                cboPiton.DataSource = piton.cboPiton();
                cboPiton.ValueMember = "id";
                cboPiton.DisplayMember = "modelo";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
