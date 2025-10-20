using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_16
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string instruccionDdl = "SELECT * FROM Temas";
                        using (SqlCommand sqlCommandDdl = new SqlCommand(instruccionDdl, conexion))
                        using (SqlDataReader dataReaderDdl = sqlCommandDdl.ExecuteReader())
                        {
                            ddlTemas.Items.Add(new ListItem("-Seleccione un tema-", "0"));
                            while (dataReaderDdl.Read())
                            {
                                ddlTemas.Items.Add(new ListItem(
                                    dataReaderDdl["Tema"].ToString(),
                                    dataReaderDdl["IdTema"].ToString()));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = "Error al cargar los temas: " + ex.Message;
                    lblError.Visible = true;
                }
            }
        }

        protected void lbVerLibros_Click(object sender, EventArgs e)
        {
            if (ddlTemas.SelectedValue == "0")
            {
                lblError.Text = "Debe seleccionar un tema.";
                lblError.Visible = true;
            }
            else
            {
                Server.Transfer("Ejercicio3b.aspx");
            }
        }
    }
}