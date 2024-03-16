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
    public partial class frmSetStandar : Form
    {
        public frmSetStandar()
        {
            InitializeComponent();
        }

        private void frmSetStandar_Load(object sender, EventArgs e)
        {
            StandarNeg standar = new StandarNeg();
            List<Standar> lista = standar.listar();
            dgvStandar.DataSource = lista;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
