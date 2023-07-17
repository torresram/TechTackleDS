using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class BlisterNeg
    {
        public List<Blister> listar()
        {
            List<Blister> lista = new List<Blister>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id, Modelo, Descripcion, Cantidad, Peso from Blister");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Blister aux = new Blister();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo= (string)datos.Lector["Modelo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.Peso= (float)datos.Lector["Peso"];

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

        public void agregarBlister(Blister nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Blister(Modelo,Descripcion,Cantidad,Peso) values (@Modelo,@Descripcion,@Cantidad,@Peso)");
                
                datos.setParametro("@Modelo", nuevo.Modelo);
                datos.setParametro("@Descripcion", nuevo.Descripcion);
                datos.setParametro("@Cantidad", nuevo.Cantidad);
                datos.setParametro("@Peso", nuevo.Peso);

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
