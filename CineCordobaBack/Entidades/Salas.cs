using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Salas
    {
        public int SalaId { get; set; }
        public TipoSalas TipoSala { get; set; }

        public Salas()
        {
            SalaId = 0;
            TipoSala = new TipoSalas();
        }
    }
}
