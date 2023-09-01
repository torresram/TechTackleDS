﻿using System;
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

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
