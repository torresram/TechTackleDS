using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PitonNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Piton> listar()
        {
            List<Piton> lista = new List<Piton>();
            
            try
            {
                datos.setConsulta("select Id, Modelo, Cantidad,Peso from Piton");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Piton aux = new Piton();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
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

        public void agregarPiton(Piton nuevo)
        {            
            try
            {
                datos.setConsulta("insert into Piton(Modelo,Cantidad,Peso) values (@Modelo,@Cant,@Peso)");

                datos.setParametro("@Modelo", nuevo.Modelo);
                datos.setParametro("@Cant", nuevo.Cantidad);
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

        public void eliminarPiton(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Piton WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarPiton(Piton piton)
        {
            try
            {
                datos.setConsulta("UPDATE Piton SET Modelo = @modelo, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@modelo", piton.Modelo);
                datos.setParametro("@cantidad", piton.Cantidad);
                datos.setParametro("@peso", piton.Peso);
                datos.setParametro("@id", piton.Id);

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
