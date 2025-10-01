using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using dominio;
using negocio;

namespace TechSeñuelos
{
    public partial class frmStockUpdate : Form
    {
        public frmStockUpdate()
        {
            InitializeComponent();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos Excel| *.xlsx;*.xls";
            ofd.Title = "Seleccione archivo";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                txtRuta.Text = ruta;
                prbBarra.Visible = true;
                lblPorcentaje.Visible = true;

                using (var workbook = new XLWorkbook(ruta))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);
                    int cantidadfilas = rows.Count();
                    ArtificialNeg negocio = new ArtificialNeg();
                    List<Artificial> lista = negocio.listar();

                    prbBarra.Minimum = 1;
                    // Set Maximum to the total number of files to copy.
                    prbBarra.Maximum = cantidadfilas;
                    // Set the initial value of the ProgressBar.
                    prbBarra.Value = 1;
                    // Set the Step property to a value of 1 to represent each file being copied.
                    prbBarra.Step = 1;                                        

                    foreach (var row in rows)
                    {
                        string modeloExcel = row.Cell(1).GetValue<string>(); //columna modelo
                        string stock = row.Cell(5).GetValue<string>(); //columna stock

                        // Perform the increment on the ProgressBar.
                        prbBarra.PerformStep();

                        lblPorcentaje.Text = prbBarra.Value / cantidadfilas * 100 + "%";

                        if (!string.IsNullOrEmpty(modeloExcel) && int.TryParse(stock, out int cantidad))
                        {
                            Artificial chequeado = lista.FirstOrDefault(x => x.Codigo ==  modeloExcel);

                            if (chequeado != null)
                            {
                                chequeado.Cantidad = cantidad;
                                negocio.actualizarStockArtificial(chequeado);
                            }
                        }
                    }
                }

                lblExito.Visible = true;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
