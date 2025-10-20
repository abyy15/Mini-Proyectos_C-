using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto1.Text) || string.IsNullOrEmpty(tbCantProd1.Text) || string.IsNullOrEmpty(tbPrecioProd1.Text) ||
                string.IsNullOrEmpty(txtProducto2.Text) || string.IsNullOrEmpty(tbCantProd2.Text) || string.IsNullOrEmpty(tbPrecioProd2.Text) ||
                string.IsNullOrEmpty(txtProducto3.Text) || string.IsNullOrEmpty(tbCantProd3.Text) || string.IsNullOrEmpty(tbPrecioProd3.Text))
            {
                lblTabla.Text = "Debe ingresar los 3 productos con su cantidad y precio.";
                return;
            }

            if (!tbCantProd1.Text.All(char.IsDigit) || !tbPrecioProd1.Text.All(char.IsDigit) ||
                !tbCantProd2.Text.All(char.IsDigit) || !tbPrecioProd2.Text.All(char.IsDigit) ||
                !tbCantProd3.Text.All(char.IsDigit) || !tbPrecioProd3.Text.All(char.IsDigit))
            {
                lblValidacion.Text = "En los campos de cantidad y precio debe ingresar valores numericos";
                lblTabla.Text = "";
                return;
            }
            else
            {
                lblValidacion.Text = "";
            }

                int cantProd1 = int.Parse(tbCantProd1.Text);
            int precioProd1 = int.Parse(tbPrecioProd1.Text);
            int totalProd1 = cantProd1 * precioProd1;

            int cantProd2 = int.Parse(tbCantProd2.Text);
            int precioProd2 = int.Parse(tbPrecioProd2.Text);
            int totalProd2 = cantProd2 * precioProd2;

            int cantProd3 = int.Parse(tbCantProd3.Text);
            int precioProd3 = int.Parse(tbPrecioProd3.Text);
            int totalProd3 = cantProd3 * precioProd3;
            int cantTotal = cantProd1 + cantProd2 + cantProd3;
            int totalGeneral = totalProd1 + totalProd2 + totalProd3;

            string tabla = "<table border='1'>";

            tabla += "<tr><th>Producto</th><th>Cantidad</th><th>Precio</th><th>Total</th></tr>";

            tabla += "<tr><td>" + txtProducto1.Text + "</td><td>" + cantProd1 + "</td>";
            tabla += "<td>$" + precioProd1 + "</td><td>$" + totalProd1 + "</td></tr>";

            tabla += "<tr><td>" + txtProducto2.Text + "</td><td>" + cantProd2 + "</td>";
            tabla += "<td>$" + precioProd2 + "</td><td>$" + totalProd2 + "</td></tr>";

            tabla += "<tr><td>" + txtProducto3.Text + "</td><td>" + cantProd3 + "</td>";
            tabla += "<td>$" + precioProd3 + "</td><td>$" + totalProd3 + "</td></tr>";
            tabla += "<tr><td colspan='3'><b>Cantidad Total</b></td><td><b>" + cantTotal + "</b></td></tr>";
            tabla += "<tr><td colspan='3'><b>Total General</b></td><td><b>$" + totalGeneral + "</b></td></tr>";

            tabla += "</table>";

            lblTabla.Text = tabla;
        }
    }
}
