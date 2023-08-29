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
        public List<Anillas> listar()
        {
            List<Anillas> lista = new List<Anillas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("select Id, Marca,Tamaño,Cantidad,Peso from Anilla");
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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into Anilla(Marca,Tamaño,Cantidad,Peso) values (@Marca,@Tamaño,@Cantidad,@Peso)");
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
    }
}
