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

        public frmGestionInsumo(List<string> lista, string item)
        {
            InitializeComponent();
            lblNombreTabla.Text = item.ToUpper();
            this.columnas = lista;
        }

        private void frmGestionInsumo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < columnas.Count ; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(19, 94 + (i * 40));
                lbl.Name = "lbl" + columnas[i];
                lbl.Text = columnas[i].ToUpper();                
                Font fuenteActual = lbl.Font;
                Font newFont = new Font(fuenteActual.FontFamily, 10, fuenteActual.Style);
                lbl.Font = newFont;
                
                TextBox txt = new TextBox();
                txt.Location = new Point(204, 85 + (i * 40));
                txt.Name = "txt" + columnas[i];
                txt.Text = "";
                txt.Size = new Size(233,20);

                this.Controls.Add(lbl);
                this.Controls.Add(txt);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
