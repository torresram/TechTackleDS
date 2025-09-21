using dominio;
using Microsoft.Reporting.WinForms;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSeñuelos
{
    public partial class frmPrincipal : Form
    {
        //private List<Artificial> artificiales;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmStockInsumos)
                {
                    form.BringToFront();
                    return;
                }
            }

            frmStockInsumos stock = new frmStockInsumos();
            stock.MdiParent = this;
            stock.btnColorUpdate += FormBtnColor_btnColorUpdate;
            stock.Show();
            stock.WindowState = FormWindowState.Maximized;
            frmPrincipalReload();
            btnStock.BackColor = System.Drawing.Color.MistyRose;
        }
        private void btnListaRemitos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmListaRemitos)
                {
                    form.BringToFront();
                    return;
                }
            }

            frmListaRemitos remitos = new frmListaRemitos();
            remitos.MdiParent = this;
            remitos.btnColorUpdate += FormBtnColor_btnColorUpdate;
            remitos.Show();
            remitos.WindowState = FormWindowState.Maximized;
            frmPrincipalReload();
            btnListaRemitos.BackColor = System.Drawing.Color.MistyRose;
        }
        private void btnSetStandar_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmSetStandar)
                {
                    form.BringToFront();
                    return;
                }
            }

            frmSetStandar predefinidos = new frmSetStandar();
            predefinidos.MdiParent = this;
            predefinidos.btnColorUpdate += FormBtnColor_btnColorUpdate;
            predefinidos.Show();
            predefinidos.WindowState = FormWindowState.Maximized;
            frmPrincipalReload();
            btnSetStandar.BackColor = System.Drawing.Color.MistyRose;
        }
        private void btnArtificiales_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmArtificiales)
                {
                    form.BringToFront();
                    return;
                }
            }

            frmArtificiales artificiales = new frmArtificiales();
            artificiales.MdiParent = this;
            artificiales.btnColorUpdate += FormBtnColor_btnColorUpdate;
            artificiales.Show();
            artificiales.WindowState = FormWindowState.Maximized;
            frmPrincipalReload();
            btnArtificiales.BackColor = System.Drawing.Color.MistyRose;
        }
        private void btnColores_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmColores)
                {
                    form.BringToFront();
                    return;
                }
            }

            frmColores colores = new frmColores();
            colores.MdiParent = this;
            colores.btnColorUpdate += FormBtnColor_btnColorUpdate;
            colores.Show();
            colores.WindowState = FormWindowState.Maximized;
            frmPrincipalReload();
            btnColores.BackColor = System.Drawing.Color.MistyRose;
        }
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Center;
        }
        private void frmPrincipalReload()
        {
            var estadoOriginal = WindowState;
            WindowState = FormWindowState.Minimized;
            WindowState = estadoOriginal;
        }

        public void FormBtnColor_btnColorUpdate(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if(ActiveMdiChild == form)
                {
                    switch (form.Name)
                    {
                        case "frmStockInsumos":
                            btnStock.BackColor = System.Drawing.Color.White;
                            break;
                        case "frmListaRemitos":
                            btnListaRemitos.BackColor = System.Drawing.Color.White;
                            break;
                        case "frmSetStandar":
                            btnSetStandar.BackColor = System.Drawing.Color.White;
                            break;
                        case "frmArtificiales":
                            btnArtificiales.BackColor = System.Drawing.Color.White;
                            break;
                        case "frmColores":
                            btnColores.BackColor = System.Drawing.Color.White;
                            break;
                    }
                }
            }
        }
        private void tlmiSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockUpdate stock = new frmStockUpdate();
            stock.ShowDialog();
        }

        //private void cargarDGV()
        //{
        //    ArtificialNeg negocio = new ArtificialNeg();
        //    artificiales = negocio.listar();
        //    dgvListadoArtificialesMain.DataSource = artificiales;
        //}

        //private void formatoDGV()
        //{
        //    dgvListadoArtificialesMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvListadoArtificialesMain.Columns["id"].Visible = false;
        //    dgvListadoArtificialesMain.Columns["Imagen"].Visible = false;
        //    dgvListadoArtificialesMain.Columns["Peso"].Visible = false;
        //    dgvListadoArtificialesMain.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Modelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListadoArtificialesMain.Columns["Peso"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //}

        //private void frmPrincipal_Actualizar (object sender, EventArgs e)
        //{
        //    cargarDGV();
        //    formatoDGV();
        //    dgvListadoArtificialesMain.Refresh();
        //}
    }
}
