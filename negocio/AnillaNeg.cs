using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

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
        
        public void agregarAnilla(Anillas nueva)
        {
            try
            {
                datos.setConsulta("INSERT INTO Anilla(Marca,Tamaño,Cantidad,Peso) VALUES (@Marca,@Tamaño,@Cantidad,@Peso)");
                datos.setParametro("@Marca", nueva.Marca);
                datos.setParametro("@Tamaño", nueva.Tamaño);
                datos.setParametro("@Cantidad", nueva.Cantidad);
                datos.setParametro("@Peso", nueva.Peso);

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

        public void modificarAnilla(Anillas anilla)
        {
            try
            {
                datos.setConsulta("UPDATE Anilla SET Marca = @marca,Tamaño = @tamaño, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@marca", anilla.Marca);
                datos.setParametro("@tamaño", anilla.Tamaño);
                datos.setParametro("@cantidad", anilla.Cantidad);
                datos.setParametro("@peso", anilla.Peso);
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
