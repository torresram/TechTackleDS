using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class BlisterNeg
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Blister> listar()
        {
            List<Blister> lista = new List<Blister>();
           
            try
            {
                datos.setConsulta("SELECT Id, Modelo, Descripcion, Cantidad, Peso FROM Blister");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Blister aux = new Blister();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo= (string)datos.Lector["Modelo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.Peso= (double)datos.Lector["Peso"];

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

        public void agregarBlister(Dictionary<string, string> valoresParametros)
        {
            string modelo = valoresParametros["Modelo"];
            string desc = valoresParametros["Descripcion"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("INSERT INTO Blister(Modelo,Descripcion,Cantidad,Peso) VALUES (@Modelo,@Descripcion,@Cantidad,@Peso)");
                
                datos.setParametro("@Modelo", modelo);
                datos.setParametro("@Descripcion", desc);
                datos.setParametro("@Cantidad", cantidad);
                datos.setParametro("@Peso", peso);

                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarBlister(int id)
        {
           try
            {
                datos.setConsulta("DELETE FROM Blister WHERE Id =@id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarBlister(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string modelo = valoresParametros["Modelo"];
            string desc = valoresParametros["Descripcion"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

           try
            {
                datos.setConsulta("UPDATE Blister SET Modelo = @modelo, Descripcion = @desc, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@modelo", modelo);
                datos.setParametro("@desc", desc);
                datos.setParametro("@cantidad", cantidad);
                datos.setParametro("@peso", peso);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
    }
}
