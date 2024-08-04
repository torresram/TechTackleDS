using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;


namespace negocio
{
    public class StandarNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Standar> listar()
        {
            List<Standar> lista = new List<Standar>();

            try
            {
                datos.setConsulta("SELECT S.Id, S.Modelo, A.Tamaño AnillaA,Pit.Tamaño AnillaP, H.Numero AnzSimple, HT.Numero AnzTriple, C.Modelo Carton, B.Modelo Blister, P.Modelo Piton FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Carton C, Blister B, Standar S, Piton P WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.IdPiton = P.Id ORDER BY S.Modelo");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Standar aux = new Standar();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.AnzTriple = new Anzuelos();
                    aux.AnzTriple.Numero = (string)datos.Lector["AnzTriple"];
                    aux.AnzSimple = new Anzuelos();
                    aux.AnzSimple.Numero = (string)datos.Lector["AnzSimple"];
                    aux.AnillaAnz = new Anillas();
                    aux.AnillaAnz.Tamaño = (string)datos.Lector["AnillaA"];
                    aux.AnillaPal = new Anillas();
                    aux.AnillaPal.Tamaño = (string)datos.Lector["AnillaP"];
                    aux.Carton = new Carton();
                    aux.Carton.Modelo = (string)datos.Lector["Carton"];
                    aux.Blister = new Blister();
                    aux.Blister.Modelo = (string)datos.Lector["Blister"];
                    aux.Piton = new Piton();
                    aux.Piton.Modelo = (string)datos.Lector["Piton"];

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
        public List<Standar> listarConId()
        {
            List<Standar> lista = new List<Standar>();

            try
            {
                datos.setConsulta("SELECT S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton,P.modelo Piton, P.id idPiton FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C, PITON P WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.idPiton = P.id");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Standar aux = new Standar();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.AnzTriple = new Anzuelos();
                    aux.AnzTriple.Id = (int)datos.Lector["ATId"];
                    aux.AnzTriple.Numero = (string)datos.Lector["AnzTriple"];
                    aux.AnzSimple = new Anzuelos();
                    aux.AnzSimple.Id = (int)datos.Lector["ASId"];
                    aux.AnzSimple.Numero = (string)datos.Lector["AnzSimple"];
                    aux.AnillaAnz = new Anillas();
                    aux.AnillaAnz.Id = (int)datos.Lector["AnAnzId"];
                    aux.AnillaAnz.Tamaño = (string)datos.Lector["AnillaA"];
                    aux.AnillaPal = new Anillas();
                    aux.AnillaPal.Id = (int)datos.Lector["AnPitId"];
                    aux.AnillaPal.Tamaño = (string)datos.Lector["AnillaP"];
                    aux.Carton = new Carton();
                    aux.Carton.Id = (int)datos.Lector["idCarton"];
                    aux.Carton.Modelo = (string)datos.Lector["Carton"];
                    aux.Blister = new Blister();
                    aux.Blister.Id = (int)datos.Lector["idBlister"];
                    aux.Blister.Modelo = (string)datos.Lector["Blister"];
                    aux.Piton = new Piton();
                    aux.Piton.Id = (int)datos.Lector["idPiton"];
                    aux.Piton.Modelo = (string)datos.Lector["Piton"];

                    lista.Add(aux);
                }

                datos.cerrarConexion();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Anzuelos> cboAnzuelo()
        {
            List<Anzuelos> anzuelo = new List<Anzuelos>();

            try
            {
                datos.setConsulta("SELECT DISTINCT Id, Numero FROM Anzuelo ORDER BY Numero ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anzuelos aux = new Anzuelos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    if (aux.Numero == "0")
                        aux.Numero = "NO LLEVA";

                    anzuelo.Add(aux);
                }
                return anzuelo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Anillas> cboAnilla()
        {
            List<Anillas> anilla = new List<Anillas>();

            try
            {
                datos.setConsulta("SELECT distinct Id, Tamaño FROM Anilla order by Tamaño asc");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anillas aux = new Anillas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Tamaño = (string)datos.Lector["Tamaño"];
                    if (aux.Tamaño == "0")
                    {
                        aux.Tamaño = "NO LLEVA";
                    }

                    anilla.Add(aux);
                }
                return anilla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Carton> cboCarton()
        {
            List<Carton> carton = new List<Carton>();

            try
            {
                datos.setConsulta("SELECT DISTINCT id, modelo from CARTON ORDER BY modelo ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Carton aux = new Carton();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Modelo = (string)datos.Lector["modelo"];
                    if (aux.Modelo == "NINGUNO")
                    {
                        aux.Modelo = "NO LLEVA";
                    }

                    carton.Add(aux);
                }
                return carton;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Blister> cboBlister()
        {
            List<Blister> blister = new List<Blister>();

            try
            {
                datos.setConsulta("SELECT DISTINCT id, modelo from BLISTER ORDER BY modelo ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Blister aux = new Blister();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Modelo = (string)datos.Lector["modelo"];
                    if (aux.Modelo == "NINGUNO")
                    {
                        aux.Modelo = "NO LLEVA";
                    }

                    blister.Add(aux);
                }
                return blister;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Piton> cboPiton()
        {
            List<Piton> piton = new List<Piton>();

            try
            {
                datos.setConsulta("SELECT DISTINCT id, modelo from PITON ORDER BY modelo ASC");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Piton aux = new Piton();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Modelo = (string)datos.Lector["modelo"];
                    if (aux.Modelo == "NINGUNO")
                    {
                        aux.Modelo = "NO LLEVA";
                    }

                    piton.Add(aux);
                }
                return piton;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public Standar personalizar(string modelo)//configuracion standar de artificiales
        {
            Standar standar = new Standar();
            //string config;
            try
            {
                datos.setConsulta("SELECT S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.Modelo = @modelo");
                datos.setParametro("@modelo", modelo);
                datos.ejecLectura();

                datos.Lector.Read();

                standar.Id = (int)datos.Lector["Id"];
                standar.Modelo = (string)datos.Lector["Modelo"];
                standar.AnillaPal = new Anillas();
                standar.AnillaAnz = new Anillas();
                standar.AnillaPal.Id = (int)datos.Lector["AnPitId"];
                standar.AnillaPal.Tamaño = (string)datos.Lector["AnillaP"];
                standar.AnillaAnz.Id = (int)datos.Lector["AnAnzId"];
                standar.AnillaAnz.Tamaño = (string)datos.Lector["AnillaA"];
                standar.AnzSimple = new Anzuelos();
                standar.AnzTriple = new Anzuelos();
                standar.AnzSimple.Id = (int)datos.Lector["ASId"];
                standar.AnzSimple.Numero = (string)datos.Lector["AnzSimple"];
                standar.AnzTriple.Id = (int)datos.Lector["ATId"];
                standar.AnzTriple.Numero = (string)datos.Lector["AnzTriple"];
                standar.Carton = new Carton();
                standar.Carton.Id = (int)datos.Lector["idCarton"];
                standar.Carton.Modelo = (string)datos.Lector["Carton"];
                standar.Blister = new Blister();
                standar.Blister.Id = (int)datos.Lector["idBlister"];
                standar.Blister.Modelo = (string)datos.Lector["Blister"];

                string aniAnz = standar.AnillaAnz.Tamaño;
                string aniPal = standar.AnillaPal.Tamaño;
                string mod = standar.Modelo;

                return standar;
            }
            catch (Exception ex)
            {
                //hacer excepcion en caso de devolver null la consulta...
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public Standar personalizar(string modelo, int cantidad)//para usar con la Lista de suplentes
        {
            Standar standar = new Standar();
            //string config;
            try
            {
                datos.setConsulta("SELECT S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.Modelo = @modelo");
                datos.setParametro("@modelo", modelo);
                datos.ejecLectura();

                datos.Lector.Read();

                standar.Id = (int)datos.Lector["Id"];
                standar.Modelo = (string)datos.Lector["Modelo"];
                standar.AnillaPal = new Anillas();
                standar.AnillaAnz = new Anillas();
                standar.AnillaPal.Id = (int)datos.Lector["AnPitId"];
                standar.AnillaPal.Tamaño = (string)datos.Lector["AnillaP"];
                standar.AnillaAnz.Id = (int)datos.Lector["AnAnzId"];
                standar.AnillaAnz.Tamaño = (string)datos.Lector["AnillaA"];
                standar.AnzSimple = new Anzuelos();
                standar.AnzTriple = new Anzuelos();
                standar.AnzTriple.Numero = (string)datos.Lector["AnzTriple"];
                standar.AnzTriple.Id = (int)datos.Lector["ATId"];
                standar.AnzSimple.Numero = (string)datos.Lector["AnzSimple"];
                standar.AnzSimple.Id = (int)datos.Lector["ASId"];
                standar.Carton = new Carton();
                standar.Carton.Id = (int)datos.Lector["idCarton"];
                standar.Carton.Modelo = (string)datos.Lector["Carton"];
                standar.Blister = new Blister();
                standar.Blister.Id = (int)datos.Lector["idBlister"];
                standar.Blister.Modelo = (string)datos.Lector["Blister"];
                standar.Cantidad = cantidad;

                //string aniAnz = standar.AnillaAnz.Tamaño; //Esto para que esta??
                //string aniPal = standar.AnillaPal.Tamaño;
                //string mod = standar.Modelo;

                return standar;
            }
            catch (Exception ex)
            {
                //hacer excepcion en caso de devolver null la consulta...
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public string obtImg(string color, string model) //pensar bien
        {
            string imagen;

            try
            {
                datos.setConsulta("SELECT A.Id,Imagen FROM Artificial A, Color C WHERE A.Modelo = @model AND C.Color = @color AND A.Id_color = C.Id");
                datos.setParametro("@model", model);
                datos.setParametro("@color", color);
                datos.ejecLectura();

                if (datos.Lector.Read())
                {
                    imagen = (string)datos.Lector["Imagen"];
                }
                else
                {
                    imagen = "C:/Users/ramir/Documents/programacion/Practicas/01 Tech/imgs/noImageIcon.jpg";
                }

                return imagen;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<string> obtModelo()
        {
            List<string> lista = new List<string>();

            try
            {
                datos.setConsulta("SELECT DISTINCT modelo FROM ARTIFICIAL");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    string modelo = (string)datos.Lector["modelo"];
                    lista.Add(modelo);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        }
        public void agregarStandar(string modelo)
        {
            try
            {
                AccesoDatos data = new AccesoDatos();
                data.setConsulta("INSERT INTO STANDAR (modelo,idAnillasA,idAnillasP,idAnzueloS,idAnzueloT, idBlister,idCarton,idPiton) VALUES (@modelo,4,4,4,4,4,4,4)");
                data.setParametro("@modelo", modelo);
                data.ejecAccion();
                data.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarStandar(Dictionary<string, int> valores)
        {
            int id = valores["id"];
            int aniAnzuelo = valores["aniAnzuelo"];
            int aniPaleta = valores["aniPaleta"];
            int anzSimple = valores["anzSimple"];
            int anzTriple = valores["anzTriple"];
            int blister = valores["blister"];
            int carton = valores["carton"];
            int piton = valores["piton"];

            try
            {
                datos.setConsulta("UPDATE STANDAR SET idAnillasA = @aniAnzuelo, idAnillasP = @aniPaleta, idAnzueloS = @anzSimple, idAnzueloT = @anzTriple, idBlister = @blister, idCarton = @carton, idPiton = @piton WHERE id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@aniAnzuelo", aniAnzuelo);
                datos.setParametro("@aniPaleta", aniPaleta);
                datos.setParametro("@anzSimple", anzSimple);
                datos.setParametro("@anzTriple", anzTriple);
                datos.setParametro("@blister", blister);
                datos.setParametro("@carton", carton);
                datos.setParametro("@piton", piton);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminarStandar(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM STANDAR WHERE id = @id");
                datos.setParametro("@id", id);
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
