using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_16
{
    public partial class ListarSucursal : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                string consultaSQL = "SELECT s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal, p.DescripcionProvincia , s.DireccionSucursal FROM Sucursal s INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia";
                gvSucursales.DataSource = conexion.listarTabla(consultaSQL);
                gvSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (!string.IsNullOrWhiteSpace(txtIdSucursal.Text))
            {
                int idSucursal;
                if (int.TryParse(txtIdSucursal.Text, out idSucursal))
                {
                    string consultaSQL = "SELECT s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal, " +
                                         "p.DescripcionProvincia, s.DireccionSucursal " +
                                         "FROM Sucursal s INNER JOIN Provincia p " +
                                         "ON s.Id_ProvinciaSucursal = p.Id_Provincia " +
                                         "WHERE s.Id_Sucursal = " + idSucursal;

                    gvSucursales.DataSource = conexion.listarTabla(consultaSQL);
                    gvSucursales.DataBind();
                }
            } else lblError.Text = "Debe ingresar un ID de sucursal.";

            txtIdSucursal.Text = "";

        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal, p.DescripcionProvincia, s.DireccionSucursal FROM Sucursal s INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia";

            gvSucursales.DataSource = conexion.listarTabla(consulta);
            gvSucursales.DataBind();
        }
    }
}