using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArtificialNeg
    {
        public List<Artificial> listar()
        {
            List<Artificial> lista = new List<Artificial>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select A.Id, Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion from Artificial A, Color C where A.Id_color = C.Id");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Artificial aux = new Artificial();
                    aux.Id = (int)datos.Lector["A.Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Color = new Color();
                    aux.Color.Id = (int)datos.Lector["IdColor"];
                    aux.Color.Modelo = (string)datos.Lector["Color"];
                    aux.Color.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.Peso = (float)datos.Lector["Peso"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];

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

        public void agregarArtificial(Artificial nuevo)//no implementado aun
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Artificial(Codigo,Modelo,Id_color, Imagen, Peso, Cantidad) values(@Codigo,@Modelo,@IdColor,@Imagen, @Peso, @Cantidad)");
                
                datos.setParametro("@Codigo", nuevo.Codigo);
                datos.setParametro("@Modelo", nuevo.Modelo);
                datos.setParametro("@IdColor", nuevo.Color.Id);
                datos.setParametro("@Imagen", nuevo.Imagen);
                datos.setParametro("@Cantidad", nuevo.Cantidad);

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

        public List<Artificial> cboArtificial() 
        {
            List<Artificial> lure = new List<Artificial>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select distinct Modelo from Artificial");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Artificial aux = new Artificial();
                    aux.Modelo = (string)datos.Lector["Modelo"];

                    lure.Add(aux);                    
                }
                
                return lure;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
    }
}
