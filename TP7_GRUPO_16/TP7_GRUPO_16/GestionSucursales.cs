using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_16
{
    public class GestionSucursales
    {
        public GestionSucursales()
        {

        }
        public DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            AccesoBDD datos = new AccesoBDD();
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdaptador(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataRow ObtenerFila(string IdSucursal, string consultaSQL)
        {
            DataTable dataTable = new DataTable();
            dataTable = ObtenerTabla("Sucursal", consultaSQL);
            DataRow dataRow = dataTable.NewRow();
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Id_Sucursal"].ToString() == IdSucursal)
                {
                    dataRow = row;
                    return dataRow;
                }
            }
            return null;
        }

        public DataTable ObtenerTodasLasSucursales()
        {
            return ObtenerTabla("Sucursal", "SELECT * FROM Sucursal");
        }

       
    }
}