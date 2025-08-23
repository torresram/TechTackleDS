using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class TalonariosNeg
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Talonarios> listar()
        {
            List<Talonarios> lista = new List<Talonarios>();

            try
            {
                datos.setConsulta("SELECT id, nombre, prefijo, ultimo FROM TALONARIOS");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Talonarios talonario = new Talonarios()
                    {
                        Id = (int)datos.Lector["id"],
                        Nombre = (string)datos.Lector["nombre"],
                        Prefijo = (string)datos.Lector["prefijo"],
                        UltimoRemito = (int)datos.Lector["ultimo"]
                    };

                    lista.Add(talonario);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public Talonarios listarUnico(string nombre)
        {
            Talonarios talonario = new Talonarios();

            try
            {
                datos.setConsulta("SELECT id, nombre, prefijo, ultimo FROM TALONARIOS WHERE nombre = @nombre");
                datos.setParametro("@nombre", nombre);
                datos.ejecLectura();
                datos.Lector.Read();
                
                talonario.Id = (int)datos.Lector["id"];
                talonario.Nombre = (string)datos.Lector["nombre"];
                talonario.Prefijo = (string)datos.Lector["prefijo"];
                talonario.UltimoRemito = (int)datos.Lector["ultimo"];
                
                return talonario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }        
        public int obtProxRem(string talonario)//Obtener número de remito siguiente
        {
            int ultRem = 0;

            try
            {
                datos.setConsulta("SELECT MAX(ultimo) AS Ultimo FROM Talonarios WHERE nombre = @tarea");
                datos.setParametro("@tarea", talonario);
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
            finally { datos.cerrarConexion(); }
        }
        public void modificarUltimo(int id, int ultimo)
        {
            try
            {
                datos.setConsulta("UPDATE TALONARIOS SET ultimo = @ultimo WHERE id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@ultimo", ultimo);
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
