using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class AnzueloNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Anzuelos> listar()
        {
            List<Anzuelos> lista = new List<Anzuelos>();           

            try
            {
                datos.setConsulta("SELECT Id,Numero,Descripcion,Cantidad,Peso FROM Anzuelo");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anzuelos aux = new Anzuelos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.Peso = (double)datos.Lector["Peso"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarAnzuelo(Dictionary<string, string> valoresParametros)
        {
            string numero = valoresParametros["numero"];
            string desc = valoresParametros["descripcion"];
            int cantidad = int.Parse(valoresParametros["cantidad"]);
            double peso = double.Parse(valoresParametros["peso"]);

            try
            {
                datos.setConsulta("INSERT INTO Anzuelo(Numero,Descripcion,Cantidad,Peso) VALUES (@Numero,@Descripcion,@Cantidad,@Peso)");

                datos.setParametro("@Numero", numero);
                datos.setParametro("@Descripcion", desc);
                datos.setParametro("@Cantidad", cantidad);
                datos.setParametro("@Peso", peso);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarAnzuelo (int id)
        {            
            try
            {
                datos.setConsulta("DELETE FROM Anzuelo WHERE Id =@id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarAnzuelo(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string numero = valoresParametros["Numero"];
            string desc = valoresParametros["Descripcion"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("UPDATE Anzuelo SET Numero = @numero,Descripcion = @desc, Cantidad = @cantidad, Peso = @peso WHERE Id = @id ");
                datos.setParametro("@id", id);
                datos.setParametro("@numero", numero);
                datos.setParametro("@desc", desc);
                datos.setParametro("@cantidad", cantidad);
                datos.setParametro("@peso", peso);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
    }
}
