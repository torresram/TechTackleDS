using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmPersonalizar : Form
    {
        //public EventHandler pasarSuplente; //pensar mejor su uso

        private Standar standar = new Standar();
        public Standar suplente { get; set; }

        //public List<Standar> aPreparar = new List<Standar>();//reemplazado por clase dedicada
        public frmPersonalizar(Standar standar, bool optAnz, string imagen)
        {
            InitializeComponent();
            cargaCbos();
            cargarImg(imagen);

            this.standar = standar;
            lblArtificial.Text = standar.Modelo;

            if(standar.AnillaAnz.Tamaño == "0")//hacerlo mas simple con algun metodo o array
            {
                standar.AnillaAnz.Tamaño = "No lleva";
                int indice = cboAnillasA.FindString(standar.AnillaAnz.Tamaño);
                cboAnillasA.SelectedIndex = indice;
            }
            else
            {
                int indice = cboAnillasA.FindString(standar.AnillaAnz.Tamaño);
                cboAnillasA.SelectedIndex = indice;
            }

            if(standar.AnillaPal.Tamaño == "0")
            {
                standar.AnillaPal.Tamaño = "No lleva";
                int indice = cboAnillasP.FindString(standar.AnillaPal.Tamaño);
                cboAnillasP.SelectedIndex = indice;
            }
            else
            {
                int indice = cboAnillasP.FindString(standar.AnillaPal.Tamaño);
                cboAnillasP.SelectedIndex = indice;
            }
            
            if(optAnz)//hacer metodo
            {
                if(standar.AnzTriple.Numero == "0")
                {
                    standar.AnzTriple.Numero = "No lleva";//aca habria que ver como hacer en caso de que el valor de 0 sea puesto por el usuario en la tabla  
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

        private void checkStandar()
        {
            int anz = cboAnzuelo.SelectedIndex;
            int ania = cboAnillasA.SelectedIndex;
            int anip = cboAnillasP.SelectedIndex;

            Anzuelos AnzNum = (Anzuelos)cboAnzuelo.Items[anz];
            Anillas AniPal = (Anillas)cboAnillasP.Items[anip];
            Anillas AniAnz = (Anillas)cboAnillasA.Items[ania];

            string anzuelo = AnzNum.Numero;
            string anillaPal = AniPal.Tamaño;
            string anillaAnz = AniAnz.Tamaño;

            standar.AnzTriple.Numero = anzuelo;
            standar.AnzSimple.Numero = anzuelo;//hago trampa aca, solo interesa el nro de anzuelo elegido, no si es triple o simple.
            standar.AnillaAnz.Tamaño = anillaAnz;
            standar.AnillaPal.Tamaño = anillaPal;
        }

        //private void cboCheck(int indA, int IndB, int IndC)//no esta definido si se usa aun
        //{
            
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            checkStandar();
            suplente = standar;
            //pasarSuplente?.Invoke(this, EventArgs.Empty); no se si es necesario todavia
            
            Close();
        } 
    }
}
