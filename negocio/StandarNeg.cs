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
                datos.setConsulta("SELECT S.Id, S.Modelo, A.Tamaño AnillaA,Pit.Tamaño AnillaP, H.Numero AnzSimple, HT.Numero AnzTriple, C.Modelo Carton, B.Modelo Blister, P.Modelo Piton FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Carton C, Blister B, Standar S, Piton P WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.IdPiton = P.Id");
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
        public List<Anzuelos> cboAnzuelo()
        {
            List<Anzuelos> anzuelo = new List<Anzuelos>();
            
            try
            {
                datos.setConsulta("SELECT distinct Id, Numero FROM Anzuelo order by Numero asc");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anzuelos aux = new Anzuelos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    if (aux.Numero == "0")
                        aux.Numero = "No lleva";

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
                        aux.Tamaño = "No lleva";
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
        public string obtImg(string color, string modelo) //pensar bien
        {
            string imagen;

            try
            {
                datos.setConsulta("SELECT A.Id,Imagen FROM Artificial A, Color C WHERE A.Modelo = @modelo AND C.Color = @color AND A.Id_color = C.Id");
                datos.setParametro("@modelo", modelo);
                datos.setParametro("@color", color);
                datos.ejecLectura();

                datos.Lector.Read();

                imagen = (string)datos.Lector["Imagen"];

                return imagen;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
