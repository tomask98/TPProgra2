using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Peliculas> traerPeliculas();
        int ProximaFuncion();

        List<Horarios> traerHorarios();
        List<Sucursales> traerSucursales();
        List<TipoSalas> traerSalas(int idSucursal);


        List<Barrios> TraerBarrios(int idProvincia);
        List<TipoDoc> TraerDocumentos();
        List<Ciudades> TraerCiudades();
        bool CrearCliente(Clientes oClientes);
        bool CrearFuncion(Funciones oFuncion);

        int ObtenerProximoCliente();

        int ObtenerUsuario(Usuarios oUsuario);




    }
}
