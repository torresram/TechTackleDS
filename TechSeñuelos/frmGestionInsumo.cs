using dominio;
using Microsoft.SqlServer.Types;
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
        private string tabla;
        private int indice;
        private List<TextBox> txtNombres = new List<TextBox>();
        private Dictionary<string, string> propiedades = null;
        private Type tipo = null;
        private Produccion prod = new Produccion();
        public event EventHandler actualizarDgv;

        public frmGestionInsumo(List<string> lista, string item, int indiceTabla)
        {
            InitializeComponent();
            lblNombreTabla.Text = item.ToUpper();
            columnas = lista;
            tabla = item;
            indice = indiceTabla;
        }
        public frmGestionInsumo(string item, Dictionary<string, string> propiedades, Type tipo, Produccion prod)
        {
            InitializeComponent();
            lblNombreTabla.Text = item.ToUpper();
            Text = "MODIFICAR";
            tabla = item;
            this.propiedades = propiedades;
            this.tipo = tipo;
            this.prod = prod;
            //MessageBox.Show("El tipo de tipo es " + tipo);
        }
        private void frmGestionInsumo_Load(object sender, EventArgs e)
        {
             try
            {
                if (tipo != null)
                {
                    modificarTextBoxs();
                }
                else
                {
                    crearTextBoxs();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tipo == null)
            {
                Dictionary<string, string> datosTextBox = new Dictionary<string, string>();

                foreach (TextBox text in txtNombres)
                {
                    string nombre = text.Name;

                    if (nombre.ToUpper() != "ID") // poner todo esto en un método
                    {
                        var valor = text.Text.ToUpper();

                        if (string.IsNullOrEmpty(valor))
                        {
                            MessageBox.Show("Complete todos los campos para continuar", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (nombre.ToUpper() == "PESO")
                        {
                            valor = valor.Replace('.', ',');
                            if (!soloNumeros(valor))
                            {
                                MessageBox.Show("El peso debe ser un valor numérico solamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        if (nombre.ToUpper() == "CANTIDAD")
                        {
                            if (!soloNumeros(valor))
                            {
                                MessageBox.Show("La cantidad debe ser un valor numérico solamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        datosTextBox.Add(nombre, valor);
                    }
                }

                switch (indice)
                {
                    case 0:
                        AnillaNeg anilla = new AnillaNeg();
                        anilla.agregarAnilla(datosTextBox);
                        break;
                    case 1:
                        AnzueloNeg anzuelo = new AnzueloNeg();
                        anzuelo.agregarAnzuelo(datosTextBox);
                        break;
                    case 2:
                        BlisterNeg blister = new BlisterNeg();
                        blister.agregarBlister(datosTextBox);
                        break;
                    case 3:
                        CarcasaNeg carcasa = new CarcasaNeg();
                        carcasa.agregarCarcasa(datosTextBox);
                        break;
                    case 4:
                        CartonNeg carton = new CartonNeg();
                        carton.agregarCarton(datosTextBox);
                        break;
                    case 5:
                        PitonNeg piton = new PitonNeg();
                        piton.agregarPiton(datosTextBox);
                        break;
                }

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

                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show("Complete todos los campos para continuar", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (nombre.ToUpper() == "PESO")
                    {
                        valor = valor.Replace('.', ',');
                        if (!soloNumeros(valor))
                        {
                            MessageBox.Show("El peso debe ser un valor numérico solamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (nombre.ToUpper() == "CANTIDAD")
                    {
                        if (!soloNumeros(valor))
                        {
                            MessageBox.Show("La cantidad debe ser un valor numérico solamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //mientras que el tipo no sea dominio.Carcasas no se realiza ninguna acción con esta línea
                        prod.Carcasas = int.Parse(valor);
                    }

                    datosTextBox.Add(nombre, valor);
                }

                switch (tipo.ToString())
                {
                    case "dominio.Anillas":
                        AnillaNeg anilla = new AnillaNeg();
                        anilla.modificarAnilla(datosTextBox);
                        break;
                    case "dominio.Anzuelos":
                        AnzueloNeg anzuelo = new AnzueloNeg();
                        anzuelo.modificarAnzuelo(datosTextBox);
                        break;
                    case "dominio.Blister":
                        BlisterNeg blister = new BlisterNeg();
                        blister.modificarBlister(datosTextBox);
                        break;
                    case "dominio.Carcasa":
                        CarcasaNeg carcasa = new CarcasaNeg();
                        ProduccionNeg negocio = new ProduccionNeg();
                        carcasa.modificarCarcasa(datosTextBox);
                        negocio.actualizarValorInsumos(prod);
                        break;
                    case "dominio.Carton":
                        CartonNeg carton = new CartonNeg();
                        carton.modificarCarton(datosTextBox);
                        break;
                    case "dominio.Piton":
                        PitonNeg piton = new PitonNeg();
                        piton.modificarPiton(datosTextBox);
                        break;
                }

                MessageBox.Show("Modificado correctamente", "Éxito");
                Close();
            }
            actualizarDgv?.Invoke(this, EventArgs.Empty);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void crearTextBoxs()
        {
            Font lblFont = new Font("Century Gothic", 10, FontStyle.Bold);
            Font txtFont = new Font("Century Gothic", 10, FontStyle.Regular);
            int k = 0;

            for (int i = 0; i < columnas.Count; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(19, 94 + (k * 40));
                lbl.Name = "lbl" + columnas[i];
                lbl.Text = columnas[i].ToUpper() + ":";                
                lbl.Font = lblFont;

                TextBox txt = new TextBox();
                txt.Location = new Point(150, 94 + (k * 40));
                txt.Name = columnas[i];
                txt.Text = "";
                txt.Size = new Size(150, 20);                
                txt.Font = txtFont;

                txtNombres.Add(txt);

                if (txt.Name.ToUpper() != "ID")
                {
                    Controls.Add(lbl);
                    Controls.Add(txt);
                    k++;
                }
            }
        }
        private void modificarTextBoxs()
        {
            Font lblFont = new Font("Century Gothic", 10, FontStyle.Bold);
            Font txtFont = new Font("Century Gothic", 10, FontStyle.Regular);
            int i = 0;

            foreach (string campo in propiedades.Keys)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(19, 94 + (i * 40));
                lbl.Name = "lbl" + campo;
                lbl.Text = campo.ToUpper() + ":";                
                lbl.Font = lblFont;

                TextBox txt = new TextBox();
                txt.Location = new Point(150, 94 + (i * 40));
                txt.Name = campo;
                txt.Text = propiedades[campo];
                txt.Size = new Size(150, 20);                
                txt.Font = txtFont;

                txtNombres.Add(txt);

                if (campo.ToUpper() != "ID")
                {
                    Controls.Add(lbl);
                    Controls.Add(txt);
                    i++;
                }
            }
        }
        private bool soloNumeros(string cadena) //mover a una clase general porque lo voy a usar varias veces, creo
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter) || caracter == ','))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
