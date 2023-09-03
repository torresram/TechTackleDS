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

        public void agregarAnzuelo(Anzuelos nuevo)
        {            
            try
            {
                datos.setConsulta("INSERT INTO Anzuelo(Numero,Descripcion,Cantidad,Peso) VALUES (@Numero,@Descripcion,@Cantidad,@Peso)");

                datos.setParametro("@Numero", nuevo.Numero);
                datos.setParametro("@Descripcion", nuevo.Descripcion);
                datos.setParametro("@Cantidad", nuevo.Cantidad);
                datos.setParametro("@Peso", nuevo.Peso);

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

        public void modificarAnzuelo(Anzuelos anzuelo)
        {            
            try
            {
                datos.setConsulta("UPDATE Anzuelo SET Numero = @numero,Descripcion = @desc, Cantidad = @cantidad, Peso = @peso WHERE Id = @id ");
                datos.setParametro("@numero", anzuelo.Numero);
                datos.setParametro("@desc", anzuelo.Descripcion);
                datos.setParametro("@cantidad", anzuelo.Cantidad);
                datos.setParametro("@peso", anzuelo.Peso);
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
