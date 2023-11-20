using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class DetalleComprobante
    {
        public int DetalleComprobanteId { get; set; }
        public Funciones FuncionId { get; set; }
        //public Comprobantes ComprobantesId { get; set; }
        public decimal Precio { get; set; }
        public Promociones PromocionesId { get; set; }

        public DetalleComprobante()
        {
            FuncionId = new Funciones();
        }
    }
}
