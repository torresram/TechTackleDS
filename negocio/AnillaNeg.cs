using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;
using Microsoft.Win32;

namespace negocio
{
    public class AnillaNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Anillas> listar()
        {
            List<Anillas> lista = new List<Anillas>();
            
            try
            {
                datos.setConsulta("SELECT Id, Marca,Tamaño,Cantidad,Peso FROM Anilla");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anillas aux = new Anillas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Marca = (string)datos.Lector["Marca"];
                    aux.Tamaño = (string)datos.Lector["Tamaño"];
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
        
        public void agregarAnilla(Dictionary<string,string> valoresParametros)
        {
            string marca = valoresParametros["marca"];
            string tamaño = valoresParametros["tamaño"];
            int cantidad = int.Parse(valoresParametros["cantidad"]);
            double peso = double.Parse(valoresParametros["peso"]);
            
            try
            {
                datos.setConsulta("INSERT INTO Anilla(Marca,Tamaño,Cantidad,Peso) VALUES (@Marca,@Tamaño,@Cantidad,@Peso)");
                datos.setParametro("@Marca", marca);
                datos.setParametro("@Tamaño", tamaño);
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

        public void eliminarAnilla(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Anilla WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarAnilla(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string marca = valoresParametros["Marca"];
            string tamaño = valoresParametros["Tamaño"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("UPDATE Anilla SET Marca = @marca,Tamaño = @tamaño, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@marca", marca);
                datos.setParametro("@tamaño", tamaño);
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
