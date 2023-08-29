using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dominio;
using Microsoft.Win32.SafeHandles;

namespace negocio
{
    public class CartonNeg
    {
        public List<Carton> listar()
        {
            List<Carton> lista = new List<Carton>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id, Modelo, Descripcion, Cantidad,Peso from Carton");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Carton aux = new Carton();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
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
            finally { datos.cerrarConexion(); }
        }

        public void agregarCarton(Carton nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into Carton(Modelo,Descripcion,Cantidad,Peso) values (@Modelo,@Desc,@Cantidad,@Peso)");

                datos.setParametro("@Modelo", nuevo.Modelo);
                datos.setParametro("@Desc", nuevo.Descripcion);
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
