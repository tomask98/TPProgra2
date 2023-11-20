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
        public Clientes ClienteId { get; set; }
        public Sucursales SucursalId { get; set; }
        public FormasPago FormaPagoId { get; set; }
        public Vendedores VendedorId { get; set; }

        public Comprobantes()
        { 
        }
    }
}
