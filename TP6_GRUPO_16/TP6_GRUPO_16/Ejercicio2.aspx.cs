using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_16
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbMostarProductos_Click(object sender, EventArgs e)
        {

        }

        protected void lbEliminarProductoSeleccionado_Click(object sender, EventArgs e)
        {
            Session["tabla"] = null;
        }
    }
}