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

                using (var workbook = new XLWorkbook(ruta))
                {
                    var worksheet= workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                    ArtificialNeg negocio = new ArtificialNeg();
                    List<Artificial> lista = negocio.listar();

                    foreach (var row in rows)
                    {
                        string modeloExcel = row.Cell(1).GetValue<string>(); //columna modelo
                        string stock = row.Cell(5).GetValue<string>(); //columna stock

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
                
                MessageBox.Show("¡Stock actualizado correctamente!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
