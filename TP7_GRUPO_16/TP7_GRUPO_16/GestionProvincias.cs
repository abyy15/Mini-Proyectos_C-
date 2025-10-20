using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_16
{
    public class GestionProvincias
    {

        public GestionProvincias() 
        { 
        
        }
        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            AccesoBDD datos = new AccesoBDD();
            SqlDataAdapter sqlDataAdapter = datos.ObtenerAdaptador(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerTodasLasProvincias()
        {
            return ObtenerTabla("Provincia", "SELECT * FROM Provincia");
        }
    }
}
