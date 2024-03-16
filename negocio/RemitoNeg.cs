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
        private AccesoDatos datos = new AccesoDatos();
        public List<Remito> listar()
        {
            List<Remito> lista = new List<Remito>();
           
            try
            {
                datos.setConsulta("SELECT Id, Numero, Destino, FechaCreacion FROM Remito");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Remito aux = new Remito();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Destino = (string)datos.Lector["Destino"];
                    aux.Fecha = (DateTime)datos.Lector["FechaCreacion"];

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
        public List<Remito> listar(int nro)
        {
            List<Remito> lista = new List<Remito>();
            
            try
            {
                datos.setConsulta("SELECT Id, Numero, Destino, FechaCreacion FROM Remito WHERE Numero = @nro");
                datos.setParametro("@nro", nro);
                datos.ejecLectura();
                

                while (datos.Lector.Read())
                {
                    Remito aux = new Remito();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Destino = (string)datos.Lector["Destino"];
                    aux.Fecha = (DateTime)datos.Lector["FechaCreacion"];

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
            try
            {
                datos.setConsulta("INSERT INTO Remito(Numero,Destino) VALUES (@Numero,@Destino)");

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
            try
            {
                datos.setConsulta("DELETE FROM Remito WHERE Numero = @remito");
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
            int banRemito;

            try
            {
                datos.setConsulta("SELECT MAX(Numero) AS Ultimo FROM Remito");
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
            int ultRem = 0;
            try
            {
                datos.setConsulta("SELECT MAX(Numero) AS Ultimo FROM Remito");
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
            try
            {
                datos.setConsulta("SELECT Id FROM Remito WHERE Numero = @remito");
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
            
            try
            {
                datos.setConsulta("SELECT DISTINCT Destino FROM Remito");
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
            try
            {
                datos.setConsulta("INSERT INTO Remito (Numero,Destino,FechaCreacion) VALUES (@Numero,@Destino,@Fecha)");

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
