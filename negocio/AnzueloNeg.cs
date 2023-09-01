﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class AnzueloNeg
    {
        public List<Anzuelos> listar()
        {
            List<Anzuelos> lista = new List<Anzuelos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id,Numero,Descripcion,Cantidad,Peso from Anzuelo");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Anzuelos aux = new Anzuelos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (string)datos.Lector["Numero"];
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
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarAnzuelo(Anzuelos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into Anzuelo(Numero,Descripcion,Cantidad,Peso) values (@Numero,@Descripcion,@Cantidad,@Peso)");

                datos.setParametro("@Numero", nuevo.Numero);
                datos.setParametro("@Descripcion", nuevo.Descripcion);
                datos.setParametro("@Cantidad", nuevo.Cantidad);
                datos.setParametro("@Peso", nuevo.Peso);

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

        public void eliminarAnzuelo (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("delete from Anzuelo where Id =@id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarAnzuelo(Anzuelos anzuelo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("update Anzuelo set Numero = @numero,Descripcion = @desc, Cantidad = @cantidad, Peso = @peso where Id = @id ");
                datos.setParametro("@numero", anzuelo.Numero);
                datos.setParametro("@desc", anzuelo.Descripcion);
                datos.setParametro("@cantidad", anzuelo.Cantidad);
                datos.setParametro("@peso", anzuelo.Peso);
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
