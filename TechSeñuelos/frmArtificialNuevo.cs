using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using dominio;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using negocio;
using TechSeñuelos.Properties;

namespace TechSeñuelos
{
    public partial class frmArtificialNuevo : Form
    {
        Artificial artificial = null;
        private OpenFileDialog archivo = null;
        public event EventHandler Actualizar;
        public frmArtificialNuevo()
        {
            InitializeComponent();
        }

        public frmArtificialNuevo(Artificial artificial)
        {
            InitializeComponent();
            this.artificial = artificial;
            Text = "MODIFICAR ARTIFICIAL";
        }

        private void frmArtificialNuevo_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            cargarCbo();
            try
            {
                if (artificial != null)
                {
                    txtCodigo.Text = artificial.Codigo;
                    cboColor.SelectedValue = artificial.Color.Id;
                    txtModelo.Text = artificial.Modelo;
                    txtImagen.Text = artificial.Imagen;
                    cargarImg(artificial.Imagen);
                    txtCantidad.Text = artificial.Cantidad.ToString();
                    txtPeso.Text = artificial.Peso.ToString();
                }
                cargarImg(txtImagen.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> textBoxes = new Dictionary<string, string>()
            {
                {"codigo",txtCodigo.Text},
                {"modelo",txtModelo.Text},
                {"imagen", txtImagen.Text },
                {"cantidad", txtCantidad.Text.ToString()},
                {"peso", txtPeso.Text.ToString()},
            };

            ArtificialNeg negocio = new ArtificialNeg();
            try
            {
                if (artificial == null)
                {
                    artificial = new Artificial();
                }
                string chkCodigo = txtCodigo.Text;

                if (chkCodigo != artificial.Codigo)
                {
                    if (negocio.validarCodigo(chkCodigo))
                    {
                        MessageBox.Show("El código ingresado ya existe, ingrese el correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodigo.Focus();
                        return;
                    }
                }

                foreach (var campo in textBoxes)
                {
                    if (string.IsNullOrEmpty(campo.Value))
                    {
                        MessageBox.Show("Complete todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                artificial.Codigo = txtCodigo.Text.ToUpper();
                artificial.Color = (dominio.Color)cboColor.SelectedItem;
                artificial.Modelo = txtModelo.Text.ToUpper();
                artificial.Imagen = txtImagen.Text;
                cargarImg(artificial.Imagen);

                if (soloNumeros(txtCantidad.Text) && soloNumeros(txtPeso.Text))
                {
                    string reemplazo = txtPeso.Text.Replace('.', ',');

                    artificial.Cantidad = int.Parse(txtCantidad.Text);
                    artificial.Peso = double.Parse(reemplazo);
                }
                else
                {
                    MessageBox.Show("Los campos deben ser solamente númericos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (artificial.Id != 0)
                {
                    negocio.modificarArtificial(artificial);
                    MessageBox.Show("¡Modificado existosamente!", "¡Éxito!");
                    Close();
                }
                else
                {
                    negocio.agregarArtificial(artificial);
                    MessageBox.Show("¡Agregado exitosamente!", "¡Éxito!");
                    vaciarCampos();
                }

                if (archivo != null)
                {
                    if (archivo.FileName != "" && !txtImagen.Text.ToUpper().Contains("HTTP"))
                    {
                        string relativa = ConfigurationManager.AppSettings["artificiales-folder"];
                        string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativa);
                        string destino = Path.Combine(ruta, archivo.SafeFileName);

                        if (!Directory.Exists(ruta))
                        {
                            Directory.CreateDirectory(ruta);
                        }

                        if (!File.Exists(destino))
                        {
                            File.Copy(archivo.FileName, destino);
                        }
                    }
                }

                txtImagen.Text = "";
                Actualizar?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarCbo()
        {
            ColorNeg negocio = new ColorNeg();
            try
            {
                cboColor.DataSource = negocio.listar();
                cboColor.ValueMember = "Id";
                cboColor.DisplayMember = "Modelo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cargarImg(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbImagen.Image = Resources.noImageIcon;
                txtImagen.Text = "Sin imágen";
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char letra in cadena)
            {
                if (!(char.IsNumber(letra) || letra == ',' || letra == '.'))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImg(archivo.FileName);
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImg(txtImagen.Text);
        }

        private void vaciarCampos()
        {
            txtCodigo.Text = txtModelo.Text.Replace(" ", "") + "-";
            txtCodigo.Focus();
            //txtModelo.Text = "";
            //txtImagen.Text = "";
            txtCantidad.Text = "0";
            //txtPeso.Text = "";
        }
    }
}
