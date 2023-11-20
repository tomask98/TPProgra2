using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Sucursales
    {
        public int Id_sucursal { get; set; }
        public string Nombre_Sucursal { get; set; }
        public Barrios BarrioId { get; set; }

        public Sucursales(int id_sucursal, string nombresucursal)
        {
            Id_sucursal = id_sucursal;
            Nombre_Sucursal = nombresucursal;
        }
        public Sucursales()
        {
            
        }



        public override string ToString()
        {
            return Nombre_Sucursal;
        }
    }
}
