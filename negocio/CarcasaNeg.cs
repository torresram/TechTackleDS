using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CarcasaNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Carcasa> listar()
        {
            List<Carcasa> lista = new List<Carcasa>();
            
            try
            {
                datos.setConsulta("SELECT Id,Modelo,Peso, Cantidad FROM CARCASA");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Carcasa aux = new Carcasa();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Peso = (double)datos.Lector["Peso"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];

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

        public void agregarCarcasa(Dictionary<string, string> valoresParametros)
        {
            string modelo = valoresParametros["modelo"];
            double peso = double.Parse(valoresParametros["peso"]);
            int cantidad = int.Parse(valoresParametros["cantidad"]);
            
            try
            {
                datos.setConsulta("INSERT INTO CARCASA(Modelo,Peso,Cantidad) VALUES (@Modelo,@Peso,@Cantidad)");
                datos.setParametro("@Modelo", modelo);
                datos.setParametro("@Peso", peso);
                datos.setParametro("@Cantidad", cantidad);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarCarcasa(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM CARCASA WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarCarcasa(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string modelo = valoresParametros["Modelo"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("UPDATE CARCASA SET Modelo = @modelo, Peso = @peso, Cantidad = @cantidad WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@modelo", modelo);
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

        public void modificarCarcasaProd(Carcasa carcasa)
        {
            string modelo = carcasa.Modelo;
            int cantidad = carcasa.Cantidad;

            try
            {
                datos.setConsulta("UPDATE CARCASA SET cantidad = @cantidad WHERE modelo = @modelo");
                datos.setParametro("@modelo", modelo);
                datos.setParametro("@cantidad", cantidad);
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
