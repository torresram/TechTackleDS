using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProduccionNeg
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Produccion> listar()
        {
            List<Produccion> lista = new List<Produccion>();

            try
            {
                datos.setConsulta("SELECT id,modelo,carcasas, armados, soldados, lijados FROM PRODUCCION");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Produccion produccion = new Produccion();
                    produccion.Id = (int)datos.Lector["id"];
                    produccion.Modelo = (string)datos.Lector["modelo"];
                    produccion.Carcasas = (int)datos.Lector["carcasas"];
                    produccion.Armados = (int)datos.Lector["armados"];
                    produccion.Soldados = (int)datos.Lector["soldados"];
                    produccion.Lijados = (int)datos.Lector["lijados"];

                    lista.Add(produccion);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void actualizarValor(Produccion produccion)
        {
            Produccion prod = produccion;
            int id = prod.Id;
            int carcasas = prod.Carcasas;
            int armados = prod.Armados;
            int soldados = prod.Soldados;
            int lijados = prod.Lijados;

            try
            {
                datos.setConsulta("UPDATE PRODUCCION SET carcasas = @carcasas, armados = @armados,soldados = @soldados,lijados = @lijados WHERE id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@carcasas", carcasas);
                datos.setParametro("@armados", armados);
                datos.setParametro("@soldados", soldados);
                datos.setParametro("@lijados", lijados);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void actualizarValorInsumos(Produccion produccion)
        {
            Produccion prod = produccion;
            string modelo = prod.Modelo;
            int cantidad = prod.Carcasas;

            try
            {
                datos.setConsulta("UPDATE PRODUCCION SET carcasas = @cantidad WHERE modelo = @modelo");
                datos.setParametro("@modelo",modelo);
                datos.setParametro("@cantidad", cantidad);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally{ datos.cerrarConexion(); }
        }
        public List<Produccion> obtModelo()
        {
            List<Produccion> lista = new List<Produccion>();

            try
            {
                datos.setConsulta("SELECT DISTINCT id, modelo FROM CARCASA ORDER BY Modelo ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Produccion prod = new Produccion()
                    {
                        Id = (int)datos.Lector["id"],
                        Modelo = (string)datos.Lector["modelo"],
                    };
                    lista.Add(prod);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void agregarModelo(Produccion modelo)
        {
            try
            {
                datos.setConsulta("INSERT INTO PRODUCCION (id, modelo, carcasas, armados, soldados, lijados) VALUES (@id,@modelo,0,0,0,0)");
                datos.setParametro("@id", modelo.Id);
                datos.setParametro("@modelo", modelo.Modelo);
                datos.ejecAccion();
                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
