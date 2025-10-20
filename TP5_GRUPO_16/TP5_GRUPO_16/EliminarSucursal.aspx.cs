using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_GRUPO_16
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True;TrustServerCertificate=True";
        private Conexion conexion = new Conexion();
        private string consulta;

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblAviso.Text = "";
            consulta = "DELETE FROM Sucursal WHERE Id_Sucursal = " + txtSucursal.Text;

            int filasAfectadas = conexion.ejecutarComando(consulta);

            mostrarAviso(filasAfectadas);

            txtSucursal.Text = string.Empty;

        }

        private void mostrarAviso (int filasAfectadas)
        {
            if (filasAfectadas > 0)
            {
                lblAviso.Text = "La sucursal se ha eliminado con exito";
            }
            else
            {
                lblAviso.Text = "El ID ingresado no existe en la base de datos.";
            }
        }
    }
}