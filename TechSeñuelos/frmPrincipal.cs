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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemitir_Click(object sender, EventArgs e)
        {
            frmRemitoNuevo nuevo = new frmRemitoNuevo();
            nuevo.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockInsumos stock = new frmStockInsumos();
            stock.ShowDialog();
        }

        private void btnListaRemitos_Click(object sender, EventArgs e)
        {
            frmListaRemitos remitos = new frmListaRemitos();
            remitos.ShowDialog();
        }
    }
}
