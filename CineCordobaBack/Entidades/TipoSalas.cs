using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class TipoSalas
    {
        public int Id_sala { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public TipoSalas(int id_sala,string tipo)
        {
            Id_sala = id_sala;
            Tipo=tipo;
        }
       

    }
}
