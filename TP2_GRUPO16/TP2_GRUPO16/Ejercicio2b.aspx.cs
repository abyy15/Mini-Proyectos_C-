using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO16
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Form["txtNombre"];
            string apellido = Request.Form["txtApellido"];
            string zona = Request["ddlCiudad"];
            foreach (ListItem tema in ((CheckBoxList)PreviousPage.FindControl("ckbTemas")).Items)
            {
                if (tema.Selected)
                {
                    lblTemasSelecionados.Text += "-" + tema.Text + "<br>";
                }
            }

            lblNombreIngresado.Text = nombre;
            lblApellidoIngresado.Text = apellido;
            lblZonaSeleccionada.Text = zona;
        }
    }
}
