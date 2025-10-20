using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_16
{
    public class Sucursales
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; } 

        public Sucursales()
        {
            IdSucursal = 0;
            Nombre = "";
            IdProvincia = 0;
            Descripcion = ""; 
        }

        public Sucursales(int idSucursal, string nombre, int idProvincia, string descripcion)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            IdProvincia = idProvincia;
            Descripcion = descripcion; 
        }
    }
}