using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_16
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True;TrustServerCertificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cadena de conexión a la bdd
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();


                SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM Provincias", conexion);
                using (SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader())
                {

                    ddlProvinciaInicio.Items.Clear();
                    ddlProvinciaInicio.Items.Add(new ListItem("--Seleccione provincia--", "0"));

                    while (sqlDataReader1.Read())
                    {
                        ddlProvinciaInicio.Items.Add(new ListItem(
                            sqlDataReader1["nombreProvincia"].ToString(),
                            sqlDataReader1["idProvincia"].ToString()
                        )); 
                    }
                }
                conexion.Close();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            int idProvinciaSeleccionada = Convert.ToInt32(ddlProvinciaInicio.SelectedValue);

            string consulta = "SELECT * FROM Localidades";


            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            ddlLocalidadInicio.Items.Clear();
            ddlLocalidadInicio.Items.Add(new ListItem("--Seleccione Localidad--", "0"));

            while (dataReader.Read())
            {
                if (Convert.ToInt32(dataReader["IdProvincia"]) == idProvinciaSeleccionada)
                {
                     ddlLocalidadInicio.Items.Add(dataReader["NombreLocalidad"].ToString());
                }
            }

            dataReader.Close();

            string consultaProvincia = "SELECT * FROM Provincias";
            SqlCommand sqlCommandProvincia = new SqlCommand(consultaProvincia, conexion);
    
            SqlDataReader sqlDataReaderDF= sqlCommandProvincia.ExecuteReader();

            ddlProvinciaDF.Items.Clear();
            ddlProvinciaDF.Items.Add(new ListItem("--Seleccione Provincia--", "0"));

            while (sqlDataReaderDF.Read())
            {
                if (Convert.ToInt32(sqlDataReaderDF["IdProvincia"]) != idProvinciaSeleccionada)
                {
                    ddlProvinciaDF.Items.Add(new ListItem(
                        sqlDataReaderDF["NombreProvincia"].ToString(),
                        sqlDataReaderDF["IdProvincia"].ToString()
                    ));
                }
            }
            sqlDataReaderDF.Close();

            conexion.Close();
        }

        protected void ddlProvinciaDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            int idProvinciaSeleccionada = Convert.ToInt32(ddlProvinciaDF.SelectedValue);

            string consulta = "SELECT * FROM Localidades";


            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            ddlLocalidadFinal.Items.Clear();
            ddlLocalidadFinal.Items.Add(new ListItem("--Seleccione Localidad--", "0"));

            while (dataReader.Read())
            {
                if (Convert.ToInt32(dataReader["IdProvincia"]) == idProvinciaSeleccionada)
                {
                    ddlLocalidadFinal.Items.Add(dataReader["NombreLocalidad"].ToString());
                }
            }

            dataReader.Close();
            conexion.Close();
        }
    }
}