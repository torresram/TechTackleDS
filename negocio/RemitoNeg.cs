using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class RemitoNeg
    {
        public List<Remito> listar()
        {
            List<Remito> lista = new List<Remito>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id, Numero, Destino from Remito");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Remito aux = new Remito();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Destino = (string)datos.Lector["Destino"];

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

        public void agregarRemito(Remito nuevo)//lo que dice ahí...
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Remito(Numero,Destino) values (@Numero,@Destino)");

                datos.setParametro("@Numero", nuevo.Id);
                datos.setParametro("@Destino", nuevo.Destino);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarRemito(int remito)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setConsulta("delete from Remito where Numero = @remito");
                datos.setParametro("@remito", remito);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        
        public bool existe(int remito)
        {
            AccesoDatos datos = new AccesoDatos();
            int banRemito;

            try
            {
                datos.setConsulta("select MAX(Numero) as Ultimo from Remito");
                datos.ejecLectura();
                datos.Lector.Read();


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Ultimo")))//si no es dbnull entonces...
                {
                    banRemito = (int)datos.Lector["Ultimo"];
                    
                    if(remito == banRemito)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public int obtProxRem()//Obtener número de remito siguiente
        {
            AccesoDatos datos = new AccesoDatos();
            int ultRem = 0;
            try
            {
                datos.setConsulta("select MAX(Numero) as Ultimo from Remito");
                datos.ejecLectura();
                datos.Lector.Read();

               
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Ultimo")))//si no es dbnull entonces...
                {
                    ultRem = (int)datos.Lector["Ultimo"];
                    ultRem++;
                }
                else
                {
                    ultRem = 1;
                }
                return ultRem;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int obtenerId(int idRemito)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id from Remito where Numero = @remito");
                datos.setParametro("@remito", idRemito);
                datos.ejecLectura();

                datos.Lector.Read();
                int Id = (int)datos.Lector["Id"];
                
                return Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Remito> cboDestino()//Devuelve solo destinos distintos
        {
            List<Remito> remito = new List<Remito> ();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setConsulta("select distinct Destino from Remito");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Remito aux = new Remito();
                    aux.Destino = (string)datos.Lector["Destino"];

                    remito.Add(aux);
                }

                return remito;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void addDestiNro(string destino, int numero, DateTime fecha)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Remito (Numero,Destino,FechaCreacion) values (@Numero,@Destino,@Fecha)");

                datos.setParametro("@Numero", numero);
                datos.setParametro("@Destino", destino);
                datos.setParametro("@Fecha", fecha);

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
