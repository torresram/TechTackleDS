using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace TechSeñuelos
{
    public partial class frmGestionInsumo : Form
    {
        private List<string> columnas;
        private string tabla = "";
        private List<TextBox> txtNombres = new List<TextBox>();
        private Dictionary<string,string> propiedades = null;        
        
        public frmGestionInsumo(List<string> lista, string item)
        {
            InitializeComponent();
            lblNombreTabla.Text = item.ToUpper();
            this.columnas = lista;
            this.tabla = item;
        }

        public frmGestionInsumo(string item, Dictionary<string,string> propiedades)
        {
            InitializeComponent();
            lblNombreTabla.Text = item.ToUpper();
            Text = "Modificar...";            
            this.tabla = item;
            this.propiedades = propiedades;
        }

        private void frmGestionInsumo_Load(object sender, EventArgs e)
        {            
            try
            {
                if (propiedades != null)
                {
                    modificarTextBoxs();
                }
                else
                {
                    crearTextBoxs();
                }
            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            if(propiedades == null)
            {
                Dictionary<string, string> datosTextBox = new Dictionary<string, string>();

                foreach (TextBox text in txtNombres)
                {
                    string nombre = text.Name;
                    var valor = text.Text;
                
                    datosTextBox.Add(nombre, valor);
                }

                AnillaNeg negocio = new AnillaNeg();
                negocio.agregarAnilla(datosTextBox);

                MessageBox.Show("Agregado correctamente", "Éxito");

                foreach (TextBox text in txtNombres)
                {
                    text.Text = "";
                }
            }
            else
            {
                Dictionary<string, string> datosTextBox = new Dictionary<string, string>();

                foreach (TextBox text in txtNombres)
                {
                    string nombre = text.Name;
                    var valor = text.Text;

                    datosTextBox.Add(nombre, valor);
                }

                AnillaNeg negocio = new AnillaNeg();
                negocio.modificarAnilla(datosTextBox);

                MessageBox.Show("Modificado correctamente!", "Éxito");

                Close();
            }
        }

        private void crearTextBoxs()
        {
            for (int i = 0; i < columnas.Count; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(19, 94 + (i * 40));
                lbl.Name = "lbl" + columnas[i];
                lbl.Text = columnas[i].ToUpper() + ":";
                Font fuenteActual = lbl.Font;
                Font newFont = new Font(fuenteActual.FontFamily, 10, fuenteActual.Style);
                lbl.Font = newFont;

                TextBox txt = new TextBox();
                txt.Location = new Point(150, 94 + (i * 40));
                txt.Name = columnas[i];
                txt.Text = "";
                txt.Size = new Size(150, 20);

                txtNombres.Add(txt);

                this.Controls.Add(lbl);
                this.Controls.Add(txt);
            }
        }

        private void modificarTextBoxs()
        {
            int i = 0;
            foreach (string campo in propiedades.Keys)
            {                
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(19, 94 + (i * 40));
                lbl.Name = "lbl" + campo;
                lbl.Text = campo.ToUpper() + ":";
                Font fuenteActual = lbl.Font;
                Font newFont = new Font(fuenteActual.FontFamily, 10, fuenteActual.Style);
                lbl.Font = newFont;

                TextBox txt = new TextBox();
                txt.Location = new Point(150, 94 + (i * 40));
                txt.Name = campo;
                txt.Text = propiedades[campo];
                txt.Size = new Size(150, 20);
                
                txtNombres.Add(txt);
                
                if(campo != "Id")
                {
                    this.Controls.Add(lbl);
                    this.Controls.Add(txt);
                    
                    i++;
                }                    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool soloNumeros(string cadena) //mover a una clase general porque lo voy a usar varias veces
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
