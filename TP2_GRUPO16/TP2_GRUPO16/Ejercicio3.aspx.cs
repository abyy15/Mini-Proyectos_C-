using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO16
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }
        protected void lbAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lbVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Green;
        }

        protected void lbVioleta_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Violet;
        }

        protected void lbAmarillo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Yellow;
        }

        protected void lbNaranja_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Orange;
        }
    }
}