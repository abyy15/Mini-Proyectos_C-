using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_16
{
	public class AccesoBDD
    {
        private string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True;";
        public AccesoBDD () {}
        public SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(string consultaSQL)
        {
            SqlDataAdapter sqldataAdapter;
            try
            {
                sqldataAdapter = new SqlDataAdapter(consultaSQL, obtenerConexion());
                return sqldataAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
    }
}