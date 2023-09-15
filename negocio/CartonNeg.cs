using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dominio;
using Microsoft.Win32.SafeHandles;

namespace negocio
{
    public class CartonNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Carton> listar()
        {
            List<Carton> lista = new List<Carton>();
            
            try
            {
                datos.setConsulta("SELECT Id, Modelo, Descripcion, Cantidad,Peso FROM Carton");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Carton aux = new Carton();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
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
            finally { datos.cerrarConexion(); }
        }

        public void agregarCarton(Dictionary<string, string> valoresParametros)
        {
            string modelo = valoresParametros["Modelo"];
            string desc = valoresParametros["Descripcion"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("INSERT INTO Carton(Modelo,Descripcion,Cantidad,Peso) VALUES (@Modelo,@Desc,@Cantidad,@Peso)");

                datos.setParametro("@Modelo", modelo);
                datos.setParametro("@Desc", desc);
                datos.setParametro("@Cantidad", cantidad);
                datos.setParametro("@Peso", peso);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarCarton(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Carton WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarCarton(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string modelo = valoresParametros["Modelo"];
            string desc = valoresParametros["Descripcion"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("UPDATE Carton SET Modelo = @modelo, Descripcion = @desc, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@modelo", modelo);
                datos.setParametro("@desc", desc);
                datos.setParametro("@cantidad", cantidad);
                datos.setParametro("@peso", peso);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

    }
}
