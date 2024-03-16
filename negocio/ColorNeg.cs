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
        AccesoDatos datos = new AccesoDatos();
        public List<Color> listar()
        {
            List<Color> lista = new List<Color>();

            try
            {
                datos.setConsulta("SELECT Id, Color, Descripcion FROM Color");
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
            try
            {
                datos.setConsulta("INSERT INTO Color(Color,Descripcion) VALUES (@Color,@Desc)");

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
        public void modificarColor(Color color)
        {
            try
            {
                datos.setConsulta("UPDATE COLOR SET color = @modelo, descripcion = @desc WHERE id = @id");
                datos.setParametro("@id", color.Id);
                datos.setParametro("@modelo", color.Modelo);
                datos.setParametro("@desc", color.Descripcion);
                datos.ejecAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminarColor(Color color)
        {
            try
            {
                datos.setConsulta("DELETE FROM COLOR WHERE Id =@id");
                datos.setParametro("@id", color.Id);
                datos.ejecAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Color> cboColores()
        {
            List<Color> colores = new List<Color>();
            try
            {
                datos.setConsulta("SELECT DISTINCT Id,Color FROM Color");
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
        public bool validarColor(string color)
        {
            List<Color> lista = new List<Color>();
            try
            {
                datos.setConsulta("SELECT color FROM COLOR");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Color aux = new Color();
                    aux.Modelo = (string)(datos.Lector["color"]);

                    lista.Add(aux);
                }

                for (int i = 0; i < lista.Count(); i++)
                {
                    string colorExistente = lista[i].Modelo;

                    if (colorExistente.ToUpper() == color.ToUpper())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
