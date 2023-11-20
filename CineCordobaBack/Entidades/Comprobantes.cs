using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Comprobantes
    {
        public int ComprobanteId { get; set; }
        public DateTime FechaComprobante { get; set; }
        public Clientes Cliente { get; set; }
        public Sucursales Sucursal { get; set; }
        public FormasPago FormaPagoId { get; set; }
        public Vendedores Vendedor { get; set; }
        public DetalleComprobante Detalle { get; set; }

        public Comprobantes()
        {
            Detalle = new DetalleComprobante();
            Sucursal = new Sucursales();
            Vendedor = new Vendedores();
            Cliente = new Clientes();

        }

    }
}
