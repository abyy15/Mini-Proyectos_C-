using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_16
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        private const string conexion = @"Data Source=localhost\sqlexpress;Initial Catalog = BDSucursales; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        private readonly string consultaSQL = "SELECT * FROM Provincia"; 
        private readonly Conexion objConexion = new Conexion(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection); 
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                ddlProvincia.Items.Add(new ListItem("--Seleccionar provincia--", "0"));

                while (sqlDataReader.Read())
                {
                    ddlProvincia.Items.Add(new ListItem(sqlDataReader["DescripcionProvincia"].ToString(), sqlDataReader["Id_Provincia"].ToString()));
                }

                connection.Close();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
          
            string consultaSQl = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, DireccionSucursal, Id_ProvinciaSucursal) VALUES ('" + txtNombreSucursal.Text + "', '" + txtDescripcion.Text + "', '" + txtDireccion.Text + "', " + ddlProvincia.SelectedValue + ")";

            int filasAfectadas = objConexion.ejecutarComando(consultaSQl);

            mostrarMensaje(filasAfectadas);

            LimpiarCampos();

        }
        protected void LimpiarCampos()
        {
            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
        }
        private void mostrarMensaje(int filasAfectadas)
        {
            if (filasAfectadas == 1)
            {
                lblSeIngresoLaSucursal.Text = "La sucursal se ingresó correctamente";
            }
            else
            {
                lblSeIngresoLaSucursal.Text = "No se pudo ingresar la sucursal";
            }
        }
    }
}