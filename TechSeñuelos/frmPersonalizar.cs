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
    public partial class frmPersonalizar : Form
    {
        private Standar standar = new Standar();
        public frmPersonalizar(Standar standar, bool optAnz,string imagen)
        {
            InitializeComponent();
            cargaCbos();
            cargarImg(imagen);

            this.standar = standar;
            lblArtificial.Text = standar.Modelo;
            int indice = cboAnillasA.FindString(standar.AnillaAnz.Tamaño);
            cboAnillasA.SelectedIndex = indice;
            indice = cboAnillasP.FindString(standar.AnillaPal.Tamaño);
            cboAnillasP.SelectedIndex = indice;

            if(optAnz)
            {
                if(standar.AnzTriple.Numero == "0")
                {
                    standar.AnzTriple.Numero = "No lleva";
                    int aux = cboAnzuelo.FindString(standar.AnzTriple.Numero);
                    cboAnzuelo.SelectedIndex = aux;
                }
                else
                {
                    int aux = cboAnzuelo.FindString(standar.AnzTriple.Numero);
                    cboAnzuelo.SelectedIndex = aux;
                }
            }
            else
            {
                if(standar.AnzSimple.Numero == "0")
                {
                    standar.AnzSimple.Numero = "No lleva";
                    int aux = cboAnzuelo.FindString(standar.AnzSimple.Numero);
                    cboAnzuelo.SelectedIndex = aux;
                }
                else
                {
                    int aux = cboAnzuelo.FindString(standar.AnzSimple.Numero);
                    cboAnzuelo.SelectedIndex = aux;
                }
            }
        }
      
        private void frmPersonalizar_Load(object sender, EventArgs e)
        {
             
        }

        private void cargaCbos()
        {
            StandarNeg anzuelo = new StandarNeg();
            StandarNeg anilla = new StandarNeg();

            try
            {
                cboAnzuelo.DataSource = anzuelo.cboAnzuelo();
                cboAnzuelo.ValueMember = "Id";
                cboAnzuelo.DisplayMember = "Numero";                

                cboAnillasA.DataSource = anilla.cboAnilla();
                cboAnillasA.ValueMember = "Id";
                cboAnillasA.DisplayMember = "Tamaño";

                cboAnillasP.DataSource = anilla.cboAnilla();
                cboAnillasP.ValueMember = "Id";
                cboAnillasP.DisplayMember = "Tamaño";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cargarImg(string imagen)
        {   
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbImagen.Load("http://sigpapelera.com.ar/Fotos/sin.jpg");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
