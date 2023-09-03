using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CarcasaNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Carcasa> listar()
        {
            List<Carcasa> lista = new List<Carcasa>();
            
            try
            {
                datos.setConsulta("select Id,Modelo,PesoArmado, Cantidad from Carcasa");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Carcasa aux = new Carcasa();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Peso = (double)datos.Lector["PesoArmado"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];

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

        public void agregarCarcasa(Carcasa nuevo)
        {
            
            try
            {
                datos.setConsulta("insert into Carcasa(Modelo,PesoArmado,Cantidad) values (@Modelo,@Peso,@Cantidad)");

                datos.setParametro("@Modelo", nuevo.Modelo);
                datos.setParametro("@Peso", nuevo.Peso);
                datos.setParametro("@Cantidad", nuevo.Cantidad);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarCarcasa(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Carcasa WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarCarcasa(Carcasa carcasa)
        {
            try
            {
                datos.setConsulta("UPDATE Carcasa SET Modelo = @modelo,PesoArmado = @peso, Cantidad = @cantidad WHERE Id = @id");
                datos.setParametro("@modelo", carcasa.Modelo);
                datos.setParametro("@peso", carcasa.Peso);
                datos.setParametro("@cantidad", carcasa.Cantidad);
                datos.setParametro("@id", carcasa.Id);

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
