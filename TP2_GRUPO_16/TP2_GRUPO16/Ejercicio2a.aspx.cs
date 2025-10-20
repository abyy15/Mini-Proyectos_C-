using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace TP2_GRUPO16
{
    public partial class Ejercicio2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                ListItemCollection ciudades = new ListItemCollection();
                ciudades.Add(new ListItem("Gral. Pacheco ", "Norte"));
                ciudades.Add(new ListItem("San Miguel", "Oeste"));
                ciudades.Add(new ListItem("Boedo", "Sur"));
                
                ddlCiudad.DataSource = ciudades;
                ddlCiudad.DataTextField = "Text";
                ddlCiudad.DataValueField = "Value";
                ddlCiudad.DataBind();

                ckbTemas.Items.Add("Ciencias");
                ckbTemas.Items.Add("Literatura");
                ckbTemas.Items.Add("Historia");
            }
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
            {
                txtNombre.Text = "";
            }
        }

        protected void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+$"))
            {
                txtApellido.Text = "";
            }
        }

        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text == "" || txtNombre.Text == "")
            {
                lblValidacion.Text = "Debe escribir un nombre y apellido para avanzar";
            }
            else
            {
                lblValidacion.Text = "";
                Server.Transfer("Ejercicio2b.aspx");
            }
        }
    }
}
