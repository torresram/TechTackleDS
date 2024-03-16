using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmColorNuevo : Form
    {
        private dominio.Color color = null;
        public event EventHandler Actualizar;
        public frmColorNuevo()
        {
            InitializeComponent();
        }
        public frmColorNuevo(dominio.Color color)
        {
            InitializeComponent();
            this.color = color;
            Text = "MODIFICAR COLOR";
        }

        private void frmColorNuevo_Load(object sender, EventArgs e)
        {
            txtModelo.Focus();
            try
            {
                if (color != null)
                {
                    txtModelo.Text = color.Modelo;
                    txtDescripcion.Text = color.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (color == null)
            {
                color = new dominio.Color();
            }
            ColorNeg negocio = new ColorNeg();
            string modelo = txtModelo.Text;
            string desc = txtDescripcion.Text;

            if (!string.IsNullOrEmpty(modelo))
            {
                if (modelo != color.Modelo)
                {
                    if (negocio.validarColor(modelo))
                    {
                        MessageBox.Show("El color ingresado ya existe, ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtModelo.Focus();
                        return;
                    }
                }

                color.Modelo = modelo.ToUpper();
                color.Descripcion = desc;

                if (color.Id != 0)
                {
                    negocio.modificarColor(color);
                    MessageBox.Show("¡Modificado exitosamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    negocio.agregarColor(color);
                    MessageBox.Show("¡Color agregado exitosamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtModelo.Text = "";
                txtDescripcion.Text = "";
                txtModelo.Focus();

                Actualizar?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Ingrese el código del color", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtModelo.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
