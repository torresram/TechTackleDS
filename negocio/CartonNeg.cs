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
        private AccesoDatos datos = new AccesoDatos();
        public List<Carton> listar()
        {
            List<Carton> lista = new List<Carton>();
            
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

        public void eliminarCarton(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Carton WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarCarton(Carton carton)
        {
            try
            {
                datos.setConsulta("UPDATE Carton SET Modelo = @modelo, Descripcion = @desc, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@modelo", carton.Modelo);
                datos.setParametro("@desc", carton.Descripcion);
                datos.setParametro("@cantidad", carton.Cantidad);
                datos.setParametro("@peso", carton.Peso);
                datos.setParametro("@id", carton.Id);

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
