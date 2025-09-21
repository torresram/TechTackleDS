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
        AccesoDatos datos = new AccesoDatos();
        public List<Artificial> listar()
        {
            List<Artificial> lista = new List<Artificial>();

            try
            {
                datos.setConsulta("SELECT A.Id, Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion FROM Artificial A, Color C WHERE A.Id_color = C.Id ORDER BY modelo ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Artificial aux = new Artificial();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Color = new Color();
                    aux.Color.Id = (int)datos.Lector["IdColor"];
                    aux.Color.Modelo = (string)datos.Lector["Color"];
                    aux.Color.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.Peso = (double)datos.Lector["Peso"];
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
            try
            {
                datos.setConsulta("INSERT INTO Artificial(Codigo,Modelo,Id_color, Imagen, Peso, Cantidad) VALUES(@Cod,@Mod,@IdCol,@Img, @Pes, @Cant)");

                datos.setParametro("@Cod", nuevo.Codigo);
                datos.setParametro("@Mod", nuevo.Modelo);
                datos.setParametro("@IdCol", nuevo.Color.Id);
                datos.setParametro("@Img", nuevo.Imagen);
                datos.setParametro("@Cant", nuevo.Cantidad);
                datos.setParametro("@Pes", nuevo.Peso);

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
        public void modificarArtificial(Artificial artificial)
        {
            int id = artificial.Id;
            string codigo = artificial.Codigo;
            int idColor = artificial.Color.Id;
            string modelo = artificial.Modelo;
            string imagen = artificial.Imagen;
            int cantidad = artificial.Cantidad;
            double peso = artificial.Peso;

            try
            {
                datos.setConsulta("UPDATE ARTIFICIAL SET codigo = @codigoArt, id_color = @idColor, modelo = @modelo, imagen = @imagen, cantidad = @cantidad, peso = @peso WHERE id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@codigoArt", codigo);
                datos.setParametro("@idColor", idColor);
                datos.setParametro("@modelo", modelo);
                datos.setParametro("@imagen", imagen);
                datos.setParametro("@cantidad", cantidad);
                datos.setParametro("@peso", peso);
                datos.ejecAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void actualizarStockArtificial(Artificial artificial)
        {
            int id = artificial.Id;
            int cantidad = artificial.Cantidad;

            try
            {
                datos.setConsulta("UPDATE ARTIFICIAL SET cantidad = @cantidad WHERE id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@cantidad", cantidad);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminarArtificial(Artificial artificial)
        {
            int id = artificial.Id;
            try
            {
                datos.setConsulta("DELETE FROM ARTIFICIAL WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Artificial> cboArtificial()
        {
            List<Artificial> lure = new List<Artificial>();

            try
            {
                datos.setConsulta("SELECT DISTINCT Modelo FROM Artificial");
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
            finally { datos.cerrarConexion(); }
        }
        public bool validarCodigo(string codigo)
        {
            try
            {
                datos.setConsulta("SELECT codigo FROM ARTIFICIAL WHERE codigo = @codigo");
                datos.setParametro("@codigo", codigo);
                datos.ejecLectura();

                if (datos.Lector.Read())
                {
                    return true;
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
