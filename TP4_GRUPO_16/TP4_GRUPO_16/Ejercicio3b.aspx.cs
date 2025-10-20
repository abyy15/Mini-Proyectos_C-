using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_16
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
        private string consulta = "SELECT * FROM Libros WHERE";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PreviousPage!=null)
                {
                    try
                    {
                        string seleccionado = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;

                        switch (seleccionado)
                        {
                            case "1":
                                consulta += " IdTema = 1";
                                break;
                            case "2":
                                consulta += " IdTema = 2";
                                break;
                            case "3":
                                consulta += " IdTema = 3";
                                break;
                        }
                        SqlConnection conexion = new SqlConnection(cadenaConexion);
                        conexion.Open();

                        SqlCommand comando = new SqlCommand(consulta, conexion);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        gvResultados.DataSource = dataTable;
                        gvResultados.DataBind();

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        lblErrorDos.Text = "Error al cargar los libros: " + ex.Message; 
                        lblErrorDos.Visible = true;
                    }
                }
                else
                {
                    lblErrorDos.Text = "Esta página debe abrirse desde Ejercicio3.aspx."; 
                    lblErrorDos.Visible = true;
                }
            }
            
                    

        }
        protected void lbOtroTema_Click(object sender, EventArgs e)
        {
         
            Server.Transfer("Ejercicio3.aspx");

        }
    }
}