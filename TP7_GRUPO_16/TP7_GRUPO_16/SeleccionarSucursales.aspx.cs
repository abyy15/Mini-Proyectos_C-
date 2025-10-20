using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP7_GRUPO_16
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //CargarListView();
                CargarDataList();
            }
        }

        private void CargarListView()
        {
            GestionSucursales gestionSucursales = new GestionSucursales();
            DataTable sucursales = gestionSucursales.ObtenerTodasLasSucursales();

            // Vincular el DataTable al ListView
            ListViewSucursales.DataSource = sucursales;
            ListViewSucursales.DataBind();
        }

        private void CargarDataList()
        {
            GestionProvincias gestionProvincia = new GestionProvincias();
            DataTable provincias = gestionProvincia.ObtenerTodasLasProvincias();
            DataListProvincias.DataSource = provincias;
            DataListProvincias.DataBind();
        }

        protected void ListViewSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            bool existe = false;
            if (e.CommandName == "seleccionarSucursal")
            {
                string idSucursal = e.CommandArgument.ToString();
                GestionSucursales gestionSucursales = new GestionSucursales();
                if (Session["tabla"] == null)
                {
                    Session["tabla"] = CrearTabla();
                }
                foreach (DataRow row in ((DataTable)Session["tabla"]).Rows)
                {
                    if (row["Id Sucursal"].ToString() == idSucursal)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    agregarFila((DataTable)Session["tabla"], idSucursal);
                }
            }
        }

        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();

            DataColumn dataColumn = new DataColumn("Id Sucursal", typeof(string));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Nombre", typeof(string));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Descripcion", typeof(string));
            dataTable.Columns.Add(dataColumn);

            return dataTable;
        }

        private DataTable agregarFila(DataTable dataTable, string IdSucursal)
        {
            GestionSucursales gestionSucursales = new GestionSucursales();
            DataRow fila = dataTable.NewRow();
            DataRow dataRow = gestionSucursales.ObtenerFila(IdSucursal, "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal FROM Sucursal");

            fila["Id Sucursal"] = dataRow["Id_Sucursal"];
            fila["Nombre"] = dataRow["NombreSucursal"];
            fila["Descripcion"] = dataRow["DescripcionSucursal"];

            dataTable.Rows.Add(fila);

            return dataTable;
        }

        protected void btnSeleccionar_Command1(object sender, CommandEventArgs e)
        {
            bool existe = false;
            if (e.CommandName == "seleccionarSucursal")
            {
                string idSucursal = e.CommandArgument.ToString();
                GestionSucursales gestionSucursales = new GestionSucursales();
                if (Session["tabla"] == null)
                {
                    Session["tabla"] = CrearTabla();
                }

                foreach(DataRow row in ((DataTable)Session["tabla"]).Rows)
                {
                    if (row["Id Sucursal"].ToString() == idSucursal)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    agregarFila((DataTable)Session["tabla"], idSucursal);
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreSucursal = txtBuscar.Text;
            if (nombreSucursal == string.Empty)
            {
                string consulta = "SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal], [Id_ProvinciaSucursal] FROM [Sucursal]";
                SqlDataSourceSucursales.SelectCommand = consulta;
                ListViewSucursales.DataBind();
            }
            else
            {
                string consulta = "SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal], [Id_ProvinciaSucursal] FROM [Sucursal] WHERE [NombreSucursal] LIKE '" + nombreSucursal + "%'";
                SqlDataSourceSucursales.SelectCommand = consulta;
                ListViewSucursales.DataBind();
            }
        }

        protected void btnProvincias_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "botonProvincia")
            {
                ListViewSucursales.Visible = true;
                lblMensaje.Text = string.Empty;
                string idProvincia = e.CommandArgument.ToString();

                SqlDataSourceSucursales.SelectCommand = "SELECT [NombreSucursal], [DescripcionSucursal], " +
                                                        "[URL_Imagen_Sucursal], [Id_Sucursal], [Id_ProvinciaSucursal] " +
                                                        "FROM [Sucursal]  " +
                                                        "WHERE Id_ProvinciaSucursal = " + idProvincia;

                DataView dv = (DataView)SqlDataSourceSucursales.Select(DataSourceSelectArguments.Empty);
                
                if (dv.Count == 0)
                {
                    ListViewSucursales.Visible = false;
                    
                    lblMensaje.Text = "¡Atención! No se encontraron sucursales para la provincia seleccionada";

                    ListViewSucursales.DataSource = null;
                    ListViewSucursales.DataBind();
                    
                }
                
            }
        }
    }
}