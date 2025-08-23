using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TrabajosNeg
    {
        AccesoDatos datos = new AccesoDatos();
        
        public List<TrabajosRemitos> cboDestino() //Devuelve solo destinos distintos
        {
            List<TrabajosRemitos> remito = new List<TrabajosRemitos>();

            try
            {
                datos.setConsulta("SELECT DISTINCT Destino FROM TRABAJOS");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    TrabajosRemitos aux = new TrabajosRemitos();
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
        public List<TrabajosRemitos> detalleTrabajo(string remito, string talonario)
        {
            List<TrabajosRemitos> lista = new List<TrabajosRemitos>();

            try
            {
                datos.setConsulta("SELECT T.id Id, TL.nombre Nombre,TL.prefijo Prefijo,P.id IdMod, P.modelo Modelo, T.cantidad Cantidad, T.fecha FechaCreacion, T.destino Destino, T.numero FROM TRABAJOS T, TALONARIOS TL, PRODUCCION P WHERE T.id_talonario = TL.id AND P.id = T.id_modelo AND T.numero = @remito AND TL.nombre = @talonario");
                datos.setParametro("@remito", remito);
                datos.setParametro("@talonario", talonario);
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    TrabajosRemitos tarea = new TrabajosRemitos()
                    {
                        Id = (int)datos.Lector["Id"],
                        Cantidad = (int)datos.Lector["Cantidad"],
                        Destino = (string)datos.Lector["Destino"],
                        FechaCreacion = (DateTime)datos.Lector["FechaCreacion"],
                        Numero = remito,
                        Produccion = new Produccion()
                        {
                            Id = (int)datos.Lector["IdMod"],
                            Modelo = (string)datos.Lector["Modelo"],
                        },
                        Talonario = new Talonarios()
                        {
                            Nombre = (string)datos.Lector["Nombre"],
                            Prefijo = (string)datos.Lector["Prefijo"]
                        }
                    };

                    lista.Add(tarea);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void nuevoRemito(string numero, DateTime fecha, Talonarios talonario, int cantidad, int idModelo)
        {
            try
            {                
                datos.setConsulta("INSERT INTO trabajos (id_talonario, id_modelo, cantidad, fecha, destino, numero) VALUES (@idTalonario, @idModelo, @Cantidad, @Fecha, 'ninguno', @Numero)");
                datos.setParametro("@idTalonario", talonario.Id);
                datos.setParametro("@idModelo", idModelo);
                datos.setParametro("@Numero", numero);
                datos.setParametro("@Fecha", fecha);
                datos.setParametro("@Cantidad", cantidad);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void cargarDestino(string destino, string numero)
        {
            try
            {
                datos.setConsulta("UPDATE TRABAJOS SET destino = @Destino WHERE numero = @Numero");
                datos.setParametro("@Numero", numero);
                datos.setParametro("@Destino", destino);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void nuevoTrabajo(string numero, DateTime fecha, Talonarios talonario, int cantidad, int idModelo, string destino)
        {
            try
            {
                datos.setConsulta("INSERT INTO trabajos (id_talonario, id_modelo, cantidad, fecha, destino, numero) VALUES (@idTalonario, @idModelo, @Cantidad, @Fecha, @Destino, @Numero)");
                datos.setParametro("@idTalonario", talonario.Id);
                datos.setParametro("@idModelo", idModelo);
                datos.setParametro("@Numero", numero);
                datos.setParametro("@Fecha", fecha);
                datos.setParametro("@Cantidad", cantidad);
                datos.setParametro("@Destino", destino);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void actualizarTrabajo(string numero, int cantidad, int idModelo)
        {
            try
            {
                datos.setConsulta("UPDATE TRABAJOS SET id_modelo = @idModelo, cantidad = @Cantidad WHERE numero = @Numero");                
                datos.setParametro("@idModelo", idModelo);
                datos.setParametro("@Numero", numero);                
                datos.setParametro("@Cantidad", cantidad);                

                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminarTrabajo(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM TRABAJOS WHERE id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void reutilizar(string numero)
        {
            try
            {
                datos.setConsulta("DELETE FROM TRABAJOS WHERE numero = @numero");
                datos.setParametro("@numero", numero);
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