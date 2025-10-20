using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP6_GRUPO_16
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        private void CargarGridView()
        {
            GestionProductos productos = new GestionProductos();
            gvProductos.DataSource = productos.ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }



        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            string IdProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string NombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string IdProveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            string PrecioUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text;

            DataTable tabla;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = CrearTabla();
            }
            bool existe = false;
            tabla = (DataTable)Session["tabla"];
            foreach (DataRow fila in tabla.Rows)        
            {
                if (fila["IdProducto"].ToString() == IdProducto)
                {
                    existe = true;
                    return;
                }
            }
            if (!existe)
            {
                agregarFila((DataTable)Session["tabla"], IdProducto, NombreProducto, IdProveedor, PrecioUnidad);  
            }
        
            lblProdAgreg.Text = "Productos agregados: ";
            lblProdAgreg.Text += NombreProducto;

        }


        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();

            DataColumn dataColumn = new DataColumn("IdProducto", typeof(int));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("NombreProducto", typeof(string));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("IdProveedor", typeof(int));
            dataTable.Columns.Add(dataColumn);
            
            dataColumn = new DataColumn("PrecioUnidad", typeof(decimal));
            dataTable.Columns.Add(dataColumn);

            return dataTable;
        }

        private DataTable agregarFila(DataTable dataTable, string IdProducto, string NombreProducto, string IdProveedor, string PrecioUnidad)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow["IdProducto"] = IdProducto;
            dataRow["NombreProducto"] = NombreProducto;
            dataRow["IdProveedor"] = IdProveedor;
            dataRow["PrecioUnidad"] = PrecioUnidad;

            dataTable.Rows.Add(dataRow);

            return dataTable;
        }
    }
}