using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        int ObtenerProximoCliente();
        bool CrearCliente(Clientes oClientes);
        List<Barrios> obtenerBarrio(int idProvincia);
        List<Ciudades> obtenerCiudades();
        List<TipoDoc> obtenerDocumentos();
    }
}
