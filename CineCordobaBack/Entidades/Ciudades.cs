using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Ciudades
    {
        public int Id_ciudad { get; set; }
        public string NombreCiudad{ get; set; }

        public Ciudades(int id_ciudad, string nombre)
        {

            Id_ciudad = id_ciudad;
            NombreCiudad = nombre;
        }

        public override string ToString()
        {
            return NombreCiudad;
        }
    }
}
