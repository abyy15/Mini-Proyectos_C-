using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO16
{
	public partial class Ejercicio5 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                ListItemCollection memoria = new ListItemCollection();
                memoria.Add(new ListItem("Seleccione"));
                memoria.Add(new ListItem("2 GB", "200"));
                memoria.Add(new ListItem("4 GB", "375"));
                memoria.Add(new ListItem("6 GB", "500"));

                ddlMemoria.DataSource = memoria;
                ddlMemoria.DataTextField = "Text";
                ddlMemoria.DataValueField = "Value";
                ddlMemoria.DataBind();

                ListItemCollection accesorios = new ListItemCollection();
                accesorios.Add(new ListItem("Monitor LCD", "2000,50"));
                accesorios.Add(new ListItem("HD 500GB", "550,50"));
                accesorios.Add(new ListItem("Grabador DVD", "1200"));
                cblAccesorios.DataSource = accesorios;
                cblAccesorios.DataTextField = "Text";
                cblAccesorios.DataValueField = "Value";
                cblAccesorios.DataBind();
            }
        }

        protected void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            if (ddlMemoria.SelectedIndex > 0)
            {
                lblErrorMemoria.Text = "";
            }
            else
            {
                lblErrorMemoria.Text = "Debe seleccionar una memoria.";
                return;
            }

            bool accesorioSeleccionado = false;
            foreach (ListItem item in cblAccesorios.Items)
            {
                if (item.Selected)
                {
                    accesorioSeleccionado = true;
                    break;
                }
            }

            if (!accesorioSeleccionado)
            {
                lblErrorAccesorio.Text = "No se ha seleccionado accesorio.";
                return;
            }
            else
            {
                lblErrorAccesorio.Text = "";
            }

            float precio = 0;
            precio += float.Parse(ddlMemoria.SelectedValue);

            foreach (ListItem item in cblAccesorios.Items)
            {
                if (item.Selected)
                {
                    precio += float.Parse(item.Value);
                }
            }

            ///lblPrecioTotal.Text = $"{precio:N2}".Insert(0, "$");

            lblPrecioTotal.Text = precio % 1 == 0
            ? $"{precio:N0}".Insert(0, "$")
            : $"{precio:N2}".Insert(0, "$");
        }


    }
}