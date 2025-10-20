using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_GRUPO_16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                ddlLocalidades.Items.Add("-Seleccione una opcion");
                ddlLocalidades.Items.Add("Tigre");
                ddlLocalidades.Items.Add("Pacheco");
                ddlLocalidades.Items.Add("San Fernando");
                ddlLocalidades.Items.Add("Beccar");
                ddlLocalidades.Items.Add("San Isidro");

            }
        }

        protected void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                return;
            }
            

            txtLocalidad.Text = "";
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido/a " + tbNombreUsuario.Text;
        }

        protected void btnIrInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void cvLocalidad_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool localidadNueva = true;
            foreach (ListItem localidad in ddlLocalidades.Items)
            {
                if (txtLocalidad.Text == localidad.Text)
                {
                    localidadNueva = false;

                }
            }

            if (localidadNueva)
            {
                ddlLocalidades.Items.Add(txtLocalidad.Text);
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }

        }
    }
}