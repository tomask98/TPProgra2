using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Barrios
    {
        public int Id_barrio { get; set; }
        public string NombreBarrio { get; set; }
        

        public Barrios(int barriosId,string nombreBarrio)
        {
            Id_barrio = barriosId;
            NombreBarrio = nombreBarrio;
        }

        public Barrios()
        {
        }
    }
}
