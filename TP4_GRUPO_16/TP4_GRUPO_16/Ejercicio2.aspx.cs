using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP4_GRUPO_16
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;TrustServerCertificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlIdProducto.Items.Clear();
                ddlIdProducto.Items.Add(new ListItem("--Seleccione una Opcion--", "0"));
                ddlIdProducto.Items.Add(new ListItem("Igual a:", "1"));
                ddlIdProducto.Items.Add(new ListItem("Mayor a:", "2"));
                ddlIdProducto.Items.Add(new ListItem("Menor a:", "3"));

                ddlIdCategoria.Items.Clear();
                ddlIdCategoria.Items.Add(new ListItem("--Seleccione una Opcion--", "0"));
                ddlIdCategoria.Items.Add(new ListItem("Igual a:", "1"));
                ddlIdCategoria.Items.Add(new ListItem("Mayor a:", "2"));
                ddlIdCategoria.Items.Add(new ListItem("Menor a:", "3"));

            
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string query = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gvResultado.DataSource = dt;
                gvResultado.DataBind();

                conexion.Close();
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            ddlIdProducto.SelectedIndex = 0;
            ddlIdCategoria.SelectedIndex = 0;

            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            
            string query = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            gvResultado.DataSource = dt;
            gvResultado.DataBind();

            txtCategoria.Text = "";
            txtProducto.Text = "";

            conexion.Close();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ddlIdProducto.SelectedValue != "0" && txtProducto.Text != "" && txtCategoria.Text == "")
            {

                string query = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE 1=1";

                if (string.IsNullOrEmpty(txtCategoria.Text) && !string.IsNullOrEmpty(txtProducto.Text) && ddlIdProducto.SelectedValue != "0")
                {
                    switch (ddlIdProducto.SelectedValue)
                    {
                        case "1": // Igual a
                            query += " AND IdProducto = @IdProducto";
                            break;
                        case "2": // Mayor a
                            query += " AND IdProducto > @IdProducto";
                            break;
                        case "3": // Menor a
                            query += " AND IdProducto < @IdProducto";
                            break;
                    }
                }

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    if (!string.IsNullOrEmpty(txtProducto.Text) && ddlIdProducto.SelectedValue != "0")
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", int.Parse(txtProducto.Text));
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    gvResultado.DataSource = dt;
                    gvResultado.DataBind();
                }

            }
            else if (ddlIdCategoria.SelectedValue != "0" && txtCategoria.Text != "" && txtProducto.Text == "")
            {

                ///FILTRO SOLAMENTE POR CATEGORIA

                string constultaIdCategoria = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos ";

                if ((ddlIdCategoria.SelectedValue != "0") && (txtCategoria.Text != string.Empty) && (txtProducto.Text == string.Empty))
                {
                    switch (ddlIdCategoria.SelectedValue)
                    {
                        case "1":
                            constultaIdCategoria += " WHERE IdCategoría = @IdCategoria";
                            break;
                        case "2":
                            constultaIdCategoria += " WHERE IdCategoría > @IdCategoria";
                            break;
                        case "3":
                            constultaIdCategoria += " WHERE IdCategoría < @IdCategoria";
                            break;
                    }
                }

                SqlConnection conexion2 = new SqlConnection(cadenaConexion);
                conexion2.Open();
                SqlCommand comando = new SqlCommand(constultaIdCategoria, conexion2);

                if ((txtCategoria.Text != string.Empty) && ddlIdCategoria.SelectedValue != "0")
                {
                    comando.Parameters.AddWithValue("@IdCategoria", int.Parse(txtCategoria.Text));
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                gvResultado.DataSource = dataTable;
                gvResultado.DataBind();

                conexion2.Close();

            }
            else if (ddlIdProducto.SelectedValue != "0" && ddlIdCategoria.SelectedValue != "0" && txtProducto.Text != "" && txtCategoria.Text != "")
            {

                ///filtro ambos

                string constultaAmbos = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos ";


                    switch (ddlIdCategoria.SelectedValue)
                    {
                        case "1":
                            constultaAmbos += " WHERE IdCategoría = @IdCategoria";
                            break;
                        case "2":
                            constultaAmbos += " WHERE IdCategoría > @IdCategoria";
                            break;
                        case "3":
                            constultaAmbos += " WHERE IdCategoría < @IdCategoria";
                            break;
                    }

                    switch (ddlIdProducto.SelectedValue)
                    {
                        case "1": // Igual a
                            constultaAmbos += " AND IdProducto = @IdProducto";
                            break;
                        case "2": // Mayor a
                            constultaAmbos += " AND IdProducto > @IdProducto";
                            break;
                        case "3": // Menor a
                            constultaAmbos += " AND IdProducto < @IdProducto";
                            break;
                    }

                SqlConnection conexion3 = new SqlConnection(cadenaConexion);
                conexion3.Open();
                SqlCommand comando2 = new SqlCommand(constultaAmbos, conexion3);

                if ((txtCategoria.Text != string.Empty) && (ddlIdCategoria.SelectedValue != "0") && (txtProducto.Text != string.Empty) && (ddlIdProducto.SelectedValue != "0"))
                {
                    comando2.Parameters.AddWithValue("@IdCategoria", int.Parse(txtCategoria.Text));
                    comando2.Parameters.AddWithValue("@IdProducto", int.Parse(txtProducto.Text));
                }

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(comando2);
                DataTable dataTable1 = new DataTable();

                dataAdapter1.Fill(dataTable1);

                gvResultado.DataSource = dataTable1;
                gvResultado.DataBind();

                conexion3.Close();
            }

            
        }


    }
}