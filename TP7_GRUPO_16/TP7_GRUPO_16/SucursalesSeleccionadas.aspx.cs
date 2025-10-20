using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP7_GRUPO_16
{
    public partial class SucursalesSeleccionados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"] != null){
                gvSucursalesSeleccionadas.DataSource = (DataTable)Session["tabla"];
                gvSucursalesSeleccionadas.DataBind();
            }
        }
    }
}