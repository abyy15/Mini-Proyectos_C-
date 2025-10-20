using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TP6_GRUPO_16.Clases;

namespace TP6_GRUPO_16
{
    public class GestionProductos
    {
        public GestionProductos() // CONSTRUCTOR
        {
            /// CONSTRUCTOR VACÍO
        }

        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            AccesoBDD datos = new AccesoBDD();
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdaptador(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "SELECT * FROM Productos");
        }

        private void ArmarParametrosProductosEliminar(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = producto.IdProducto;
        }

        private void ArmarParametrosProducto(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = producto.IdProducto;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 50);
            SqlParametros.Value = producto.NombreProducto;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 50);
            SqlParametros.Value = producto.CantidadPorUnidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = producto.PrecioUnidad;
        }

        public bool ActualizarProducto(Producto producto)
        {
            AccesoBDD accesoBDD = new AccesoBDD();
            SqlCommand comando = new SqlCommand();
            comando.Connection = accesoBDD.ObtenerConexion();
            string consulta = "UPDATE Productos SET NombreProducto = @NombreProducto,CantidadPorUnidad = @CantidadPorUnidad,PrecioUnidad = @PrecioUnidad WHERE IdProducto = @IdProducto";
            comando.CommandText = consulta;
            ArmarParametrosProducto(ref comando, producto);
            int FilasInsertadas = comando.ExecuteNonQuery();
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool EliminarProducto(Producto producto)
        {
            AccesoBDD accesoBDD = new AccesoBDD();
            SqlConnection sqlConnection = accesoBDD.ObtenerConexion();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "DELETE FROM Productos WHERE IdProducto = @IdProducto";
            ArmarParametrosProductosEliminar(ref sqlCommand, producto);

            int FilasInsertadas = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}