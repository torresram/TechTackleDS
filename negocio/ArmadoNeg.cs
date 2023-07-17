﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
	public class ArmadoNeg
	{
		public List<Armado> listar()
		{
			List<Armado> lista = new List<Armado>();
			AccesoDatos datos = new AccesoDatos();

			try
			{

				datos.setConsulta("select A.Id Id, R.Numero, S.Modelo, C.Color, A.Cantidad from Armado A, Color C, Artificial S,Remito R where Id_artificial = S.Id and A.Id_color = C.Id and Id_remito = R.Id ");
				datos.ejecLectura();

				while (datos.Lector.Read())
				{
					Armado aux = new Armado();
					aux.Id = (int)datos.Lector["Id"];
					aux.Artificial = new Artificial();
					aux.Artificial.Modelo = (string)datos.Lector["Modelo"];
					aux.Color = new Color();
					aux.Color.Modelo = (string)datos.Lector["Color"];
					aux.Remito = new Remito();
					aux.Remito.Numero = (int)datos.Lector["Remito"];
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

		public List<Armado> detalleRemito(int remito)
		{
			AccesoDatos datos = new AccesoDatos();
			List<Armado> armado = new List<Armado>();

			try
			{
				datos.setConsulta("select A.Id,R.Numero, S.Modelo, C.Color,A.Cantidad from Armado A,Color C,Artificial S,Remito R where Id_remito = R.Id and A.Id_artificial = S.Id and A.Id_color = C.Id and R.Numero = @remito");
				datos.setParametro("@remito", remito);
				datos.ejecLectura();

				while (datos.Lector.Read())
				{
					Armado aux = new Armado();
					aux.Id = (int)datos.Lector["Id"];
					aux.Remito = new Remito();
					aux.Remito.Numero = (int)datos.Lector["Numero"];
					aux.Artificial = new Artificial();
					aux.Artificial.Modelo = (string)datos.Lector["Modelo"];
					aux.Color = new Color();
					aux.Color.Modelo = (string)datos.Lector["Color"];
					aux.Cantidad = (int)datos.Lector["Cantidad"];

					armado.Add(aux);
				}
				return armado;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void addItem(int modelo, int color, int cantidad)
		{
			AccesoDatos datos = new AccesoDatos();
			int remito = 0;
			int cantExist = 0;
			int cantUpd = 0;

			try
			{
				datos.setConsulta("select MAX(Id) as Ultimo from Remito");
				datos.ejecLectura();
				datos.Lector.Read();

				remito = (int)datos.Lector["Ultimo"];
				datos.cerrarConexion();

				datos.setConsulta("SELECT COUNT(*) AS Total FROM Armado WHERE Id_artificial = @modelo AND Id_color = @color and Id_remito = @remito");
				datos.setParametro("@modelo", modelo);
				datos.setParametro("@color", color);
				datos.setParametro("@remito", remito);
				datos.ejecLectura();

				bool existe = false;

				if (datos.Lector.Read())
				{
					if ((int)datos.Lector["Total"] > 0)
						existe = true;
				}
				datos.cerrarConexion();

				if (existe)
				{
					datos.setConsulta("select Cantidad from Armado where Id_artificial = @mod and Id_color = @col and Id_remito = @rem");
					datos.setParametro("@mod", modelo);
					datos.setParametro("@col", color);
					datos.setParametro("@rem", remito);
					datos.ejecLectura();

					datos.Lector.Read();

					cantExist = (int)datos.Lector["Cantidad"];
					cantUpd = cantExist + cantidad;
					datos.cerrarConexion();

					datos.setConsulta("UPDATE Armado SET Cantidad = @cantidadUpd WHERE Id_artificial = @modeloUpd AND Id_color = @colorUpd AND Id_remito = @remitoUpd");
					datos.setParametro("@modeloUpd", modelo);
					datos.setParametro("@colorUpd", color);
					datos.setParametro("@remitoUpd", remito);
					datos.setParametro("@cantidadUpd", cantUpd);
					datos.ejecAccion();
				}
				else
				{
					datos.setConsulta("insert into Armado (Id_artificial, Id_color, Id_remito, Cantidad) values (@Art,@Col,@Rem,@Cant)");

					datos.setParametro("@Art", modelo);
					datos.setParametro("@Col", color);
					datos.setParametro("@Rem", remito);
					datos.setParametro("@Cant", cantidad);
					datos.ejecAccion();
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { datos.cerrarConexion(); }
		}

		public void nuevoRemArmado(string artificial, string color, int cantidad)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setConsulta("select A.Id, Codigo, Modelo,C.Color, Peso, Cantidad, C.Id IdColor from Artificial A, Color C where A.Id_color = C.Id and Modelo = @artificial and Color = @color");
				datos.setParametro("@artificial", artificial);
				datos.setParametro("@color", color);
				datos.ejecLectura();
				datos.Lector.Read();

				Artificial lure = new Artificial();
				lure.Id = (int)datos.Lector["Id"];
				lure.Codigo = (string)datos.Lector["Codigo"];
				lure.Color = new dominio.Color();
				lure.Color.Id = (int)datos.Lector["IdColor"];
				lure.Color.Modelo = (string)datos.Lector["Color"];
				lure.Peso = (double)datos.Lector["Peso"];
				lure.Cantidad = (int)datos.Lector["Cantidad"];

				int art = lure.Id;
				int col = lure.Color.Id;
				int cant = cantidad;

				//ArmadoNeg negocio = new ArmadoNeg();//agrega los valores a la tabla Armado
				addItem(art, col, cant);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally { datos.cerrarConexion(); }
		}

		public void eliminar(int id)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setConsulta("delete from Armado where Id = @Id");
				datos.setParametro("@Id", id);
				datos.ejecAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { datos.cerrarConexion(); }
		}

		public void modifCant(int id, int cantidad)
		{
			AccesoDatos datos = new AccesoDatos();
			
			try
			{
				datos.setConsulta("UPDATE Armado SET Cantidad = @Cantidad WHERE Id = @Id");
				datos.setParametro("@Id", id);
				datos.setParametro("@Cantidad", cantidad);
				datos.ejecAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { datos.cerrarConexion(); }
		}
		
		public void reutilizar(int remito)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setConsulta("delete from Armado where Id_remito = @remito");
				datos.setParametro("@remito", remito);
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
