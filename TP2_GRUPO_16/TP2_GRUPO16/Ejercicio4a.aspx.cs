using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO16
{
    public partial class Ejercicio4a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            bool hayError = false;
            /// VALIDACION USUARIO ///
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                lblErrorUsuario.Text = "Debe ingresar un usuario.";
                hayError = true;
            }
            else
            {
                lblErrorUsuario.Text = "";
            }
            /// VALIDACION CLAVE ///
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                lblErrorClave.Text = "Debe ingresar una clave.";
                hayError = true;
            }
            else
            {
                lblErrorClave.Text = "";
            }

            if (hayError) return;

            if (txtUsuario.Text == "claudio" && txtClave.Text == "casas")
            {
         
                lblEstadoUsuario.Text = "Usuario válido";
                Session["usuario"] = txtUsuario.Text;
                Server.Transfer("Ejercicio4b.aspx");
            }
            else
            {
                lblEstadoUsuario.Text = "Usuario invalido";
                Server.Transfer("Ejercicio4c.aspx");
            }
        }

        
    }
}
