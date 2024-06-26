﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PitonNeg
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Piton> listar()
        {
            List<Piton> lista = new List<Piton>();
            
            try
            {
                datos.setConsulta("SELECT Id, Modelo, Cantidad,Peso FROM Piton");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Piton aux = new Piton();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
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

        public void agregarPiton(Dictionary<string, string> valoresParametros)
        {
            string modelo = valoresParametros["modelo"];
            int cantidad = int.Parse(valoresParametros["cantidad"]);
            double peso = double.Parse(valoresParametros["peso"]);

            try
            {
                datos.setConsulta("INSERT INTO Piton(Modelo,Cantidad,Peso) VALUES (@Modelo,@Cantidad,@Peso)");

                datos.setParametro("@Modelo", modelo);
                datos.setParametro("@Cantidad", cantidad);
                datos.setParametro("@Peso", peso);

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

        public void eliminarPiton(int id)
        {
            try
            {
                datos.setConsulta("DELETE FROM Piton WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificarPiton(Dictionary<string,string> valoresParametros)
        {
            int id = int.Parse(valoresParametros["Id"]);
            string modelo = valoresParametros["Modelo"];
            int cantidad = int.Parse(valoresParametros["Cantidad"]);
            double peso = double.Parse(valoresParametros["Peso"]);

            try
            {
                datos.setConsulta("UPDATE Piton SET Modelo = @modelo, Cantidad = @cantidad, Peso = @peso WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.setParametro("@modelo", modelo);
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
