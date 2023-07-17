﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;


namespace negocio
{
    public class StandarNeg
    {
        public List<Standar> listar()
        {
            List<Standar> lista = new List<Standar>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select S.Id, S.Modelo, A.Tamaño AnillaAnz, Pit.Tamaño AnillaPal, H.Numero AnzSimple, HP.Numero AnzTriple, C.Modelo Carton, B.Modelo Blister from Anilla A, Anilla Pit, Anzuelo H, Anzuelo HP, Carton C, Blister B, Standar S where S.IdAnzueloA = H.Id and S.IdAnzueloP = HP.Id and S.IdAnillasA = A.Id and S.IdAnillasP = Pit.Id and S.IdCarton = C.Id and S.IdBlister = B.Id");
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
                    aux.AnillaAnz.Tamaño = (string)datos.Lector["AnillaAnz"];
                    aux.AnillaPal = new Anillas();
                    aux.AnillaPal.Tamaño = (string)datos.Lector["AnillaPal"];
                    aux.Carton = new Carton();
                    aux.Carton.Modelo = (string)datos.Lector["Carton"];
                    aux.Blister = new Blister();
                    aux.Blister.Modelo = (string)datos.Lector["Blister"];

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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select distinct Id, Numero from Anzuelo order by Numero asc");
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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select distinct Id, Tamaño from Anilla order by Tamaño asc");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anillas aux = new Anillas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Tamaño = (string)datos.Lector["Tamaño"];
                    if (aux.Tamaño == "0")
                        aux.Tamaño = "No lleva";

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
            AccesoDatos datos = new AccesoDatos();
            Standar standar = new Standar();
            //string config;
            
            try
            {
                datos.setConsulta("select S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPalId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId from Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S where S.IdAnzueloS = H.Id and S.IdAnzueloT = HT.Id and S.IdAnillasA = A.Id and S.IdAnillasP = Pit.Id and S.Modelo = @modelo");
                datos.setParametro("@modelo", modelo);
                datos.ejecLectura();

                datos.Lector.Read();

                standar.Id = (int)datos.Lector["Id"];
                standar.Modelo = (string)datos.Lector["Modelo"];
                standar.AnillaPal = new Anillas();
                standar.AnillaAnz = new Anillas();
                standar.AnillaPal.Tamaño = (string)datos.Lector["AnillaA"];
                standar.AnillaPal.Id = (int)datos.Lector["AnPalId"];
                standar.AnillaAnz.Tamaño = (string)datos.Lector["AnillaP"];
                standar.AnillaAnz.Id = (int)datos.Lector["AnAnzId"];
                standar.AnzSimple = new Anzuelos();
                standar.AnzTriple = new Anzuelos();
                standar.AnzTriple.Numero = (string)datos.Lector["AnzTriple"];
                standar.AnzTriple.Id = (int)datos.Lector["ATId"];
                standar.AnzSimple.Numero = (string)datos.Lector["AnzSimple"];
                standar.AnzSimple.Id = (int)datos.Lector["ASId"];

                //if (anzuelo == true)
                //    config = standar.AnzTriple.Numero;
                //else
                //    config = standar.AnzSimple.Numero;

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

        public string obtImg(string color, string modelo) //pensar bien
        {
            AccesoDatos datos = new AccesoDatos();
            string imagen;

            try
            {
                datos.setConsulta("select A.Id,Imagen from Artificial A, Color C where A.Modelo = @modelo and C.Color = @color and A.Id_color = C.Id");
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