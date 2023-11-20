using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Provincias
    {
        public int Id_provincia { get; set; }
        public string Nombre_Provincia { get; set; }
        public Provincias(int id_provincia, string nombre_provincia)
        {
             Id_provincia= id_provincia;
            Nombre_Provincia = nombre_provincia;
            
        }
        public Provincias()
        {
            
        }
    }
}
