using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_16.Clases
{
    public class AccesoBDD
    {
        string rutaLibreria = @"Data Source=localhost\sqlexpress;Initial Catalog = Neptuno; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        public AccesoBDD() { }
        public SqlConnection ObtenerConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(rutaLibreria);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador (string consultaSQL)
        {
            SqlDataAdapter sqldataAdapter;

            try
            {
                sqldataAdapter = new SqlDataAdapter(consultaSQL, ObtenerConexion());
                return sqldataAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
    }
}