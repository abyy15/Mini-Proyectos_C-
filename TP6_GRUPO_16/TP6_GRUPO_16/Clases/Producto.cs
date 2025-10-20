using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_16.Clases
{
	public class Producto
	{
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public Producto()
        {
            this.IdProducto = 0;
            this.NombreProducto = string.Empty;
            this.CantidadPorUnidad = string.Empty;
            this.PrecioUnidad = 0m;
        }
        public Producto(int id, string nombre, string cantidad, decimal precio)
        {
            this.IdProducto = id;
            this.NombreProducto = nombre;
            this.CantidadPorUnidad = cantidad;
            this.PrecioUnidad = precio;
        }

    }
}