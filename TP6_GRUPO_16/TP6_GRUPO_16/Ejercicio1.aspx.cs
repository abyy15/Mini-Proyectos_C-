using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_16;
using TP6_GRUPO_16.Clases;

namespace TP6_GRUPO_16
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridView();
            }
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);
            Producto producto = new Producto { IdProducto = idProducto };
            GestionProductos gestion = new GestionProductos();
            bool eliminado = gestion.EliminarProducto(producto);
            if (!eliminado)
            {
                Response.Write("<script>alert('Error al eliminar el producto.');</script>");
            }
            else
            {
                cargarGridView();
            }
        }

        protected void cargarGridView()
        {
            DataTable dataTable = new DataTable();
            GestionProductos productos = new GestionProductos();

            dataTable = productos.ObtenerTodosLosProductos();

            gvProductos.DataSource = dataTable;
            gvProductos.DataBind();
        }
        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            cargarGridView();
        }
        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string cantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            string precioPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            Producto producto = new Producto(Convert.ToInt32(idProducto), nombreProducto, cantidadPorUnidad, Convert.ToDecimal(precioPorUnidad));

            GestionProductos gP = new GestionProductos();
            gP.ActualizarProducto(producto);
            gvProductos.EditIndex = -1;
            cargarGridView();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            cargarGridView();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            cargarGridView();
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
