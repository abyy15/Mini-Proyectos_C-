using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP5_GRUPO_16
{
	public class Conexion
	{
        public const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True;TrustServerCertificate=True";

        public int ejecutarComando(string consultaSQL)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();        
            
            SqlCommand cmd =new SqlCommand(consultaSQL, conexion);

            int filasAfectadas = cmd.ExecuteNonQuery();


            conexion.Close();

            return filasAfectadas;///DEVUELVE LAS FILAS AFECTADAS (SI ES 1 SIGNIFICA QUE SE PUDO EJECUTAR EL COMANDO CORRECTAMENTE)
        }

        public DataSet listarTabla(string consultaSQL)
        {
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            sqlConnection.Open();
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSQL, sqlConnection);

            DataSet ds = new DataSet();

            sqlDataAdapter.Fill(ds, "tabla");

            sqlConnection.Close();

            return ds;
        }
    }
}