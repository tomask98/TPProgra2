using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Promociones
    {
        public int PromoId { get; set; }
        public string NombrePromo { get; set; }
        public decimal Descuento { get; set; }

        public Promociones()
        {
        }
    }
}
