using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ColorNeg
    {
        public List<Color> listar()
        {
            List<Color> lista = new List<Color>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id, Color, Descripcion from Color");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Color aux = new Color();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Color"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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

        public void agregarColor(Color nuevo) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Color(Color,Descripcion) values (@Color,@Desc)");

                datos.setParametro("@Color", nuevo.Modelo);
                datos.setParametro("@Desc", nuevo.Descripcion);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Color> cboColores() 
        {
            List<Color> colores = new List<Color>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select distinct Id,Color from Color");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Color aux = new Color();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Color"];

                    colores.Add(aux);
                }
                return colores;
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
